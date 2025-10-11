using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using SPOF.Helper;
using DomainModel.Models;

namespace SPOF.UI
{
    public partial class GlavniMeni : Form
    {
        private readonly int _userId;
        public GlavniMeni(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void GlavniMeni_Load(object sender, EventArgs e)
        {
            TransactionRepository repo = new TransactionRepository();
            UplataIsplateDataGrid.DataSource = repo.GetAllTransactions(_userId);
            GridHelper.CustomizeGridAppearance(UplataIsplateDataGrid);
            UpdateUkupnoStanje();
            ImeKorisnika();
        }

        private void UpdateUkupnoStanje()
        {
            TransactionRepository repo = new TransactionRepository();
            decimal saldo = repo.GetBalance(_userId);
            UkupnoStanjeLbl.Text = saldo.ToString("N2") + " €";
        }
        
        private void ImeKorisnika()
        {
            UserDataAccess userRepo = new UserDataAccess();
            string ime = userRepo.GetUserName(_userId);
            ImeKorisnikaLbl.Text = ime;
        }

        private void DodajBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NazivTxt.Text) || string.IsNullOrEmpty(IznosTxt.Text))
            {

                MessageBox.Show("Unesite naziv i iznos.");
                return;
            }
            if (!PrihodCheckB.Checked && !RashodCheckB.Checked && !StednjaCheckB.Checked)
            {

                MessageBox.Show("Odaberite vrstu transakcije.");
                return;
            }

            decimal iznos;
            if (!decimal.TryParse(IznosTxt.Text.Trim(), out iznos))
            {
                MessageBox.Show("Unesite ispravan iznos.");
                return;
            }

            TransactionRepository repo = new TransactionRepository();
            decimal trenutnoStanje = repo.GetBalance(_userId);

            if ((RashodCheckB.Checked || StednjaCheckB.Checked) && (trenutnoStanje - iznos) < 0)
            {
                MessageBox.Show("Nemate dovoljno sredstava za ovu transakciju.");
                return;
            }

            string vrsta = "";
            if (PrihodCheckB.Checked) vrsta = "Prihod";
            else if (RashodCheckB.Checked) vrsta = "Rashod";
            else if (StednjaCheckB.Checked) vrsta = "Štednja";

            Transactions t = new Transactions();
            t.UserId = _userId;
            t.Title = NazivTxt.Text.Trim();
            t.Amount = iznos;
            t.Type = vrsta;
            t.CreatedAt = DateTime.Now;

            repo.AddTransaction(t);

            UplataIsplateDataGrid.DataSource = repo.GetAllTransactions(_userId);
            UpdateUkupnoStanje();

            NazivTxt.Clear();
            IznosTxt.Clear();
            PrihodCheckB.Checked = false;
            RashodCheckB.Checked = false;
            StednjaCheckB.Checked = false;

            UpdateUkupnoStanje();


        }

        private void OdjavaBtn_Click(object sender, EventArgs e)
        {
            Prijava loginForm = new Prijava();
            loginForm.Show();

            this.Close();
        }

        private void OcistiBtn_Click(object sender, EventArgs e)
        {
            NazivTxt.Clear();
            IznosTxt.Clear();

            PrihodCheckB.Checked = false;
            RashodCheckB.Checked = false;
            StednjaCheckB.Checked = false;

            NazivTxt.Focus();
        }

        private void ObrisiBtn_Click(object sender, EventArgs e)
        {
            if (UplataIsplateDataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite transakciju koju želite obrisati.");
                return;
            }
            Transactions bound = UplataIsplateDataGrid.SelectedRows[0].DataBoundItem as Transactions;
            int transactionId = bound.TransactionId;

            DialogResult result = MessageBox.Show("Jeste li sigurni da želite obrisati ovu transakciju?", "Potvrda brisanja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                TransactionRepository repo = new TransactionRepository();
                bool success = repo.DeleteTransaction(transactionId);
                if (success)
                {
                    UplataIsplateDataGrid.DataSource = repo.GetAllTransactions(_userId);
                }
                else
                {
                    MessageBox.Show("Greška prilikom brisanja transakcije.");
                }
                UpdateUkupnoStanje();
            }
        }

        private void PrihodiBtn_Click(object sender, EventArgs e)
        {
            SviPrihodi sviPrihodi = new SviPrihodi(_userId);
            sviPrihodi.Show();
            this.Close();
        }

        private void RashodiBtn_Click(object sender, EventArgs e)
        {
            SviRashodi sviRashodi = new SviRashodi(_userId);
            sviRashodi.Show();
            this.Close();
        }

        private void StednjaBtn_Click(object sender, EventArgs e)
        {
            UkupnaStednja ukupnaStednja = new UkupnaStednja(_userId);
            ukupnaStednja.Show();
            this.Close();
        }

        private void IzvjestajBtn_Click(object sender, EventArgs e)
        {
            Izvjestaj izvjestaj = new Izvjestaj(_userId);
            izvjestaj.Show();
            this.Close();
        }

        private void ExitAppLbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
