using DataAccessLayer;
using SPOF.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomainModel.Models;

namespace SPOF.UI
{
    public partial class UkupnaStednja : Form
    {
        private readonly int _userId;
        public UkupnaStednja(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void UkupnaStednja_Load(object sender, EventArgs e)
        {

            PrikaziUkupnuStednju();
            GridHelper.CustomizeGridAppearance(UkupnaStednjaDataGrid);
            
        }

        private void OsvjeziGrid()
        {
            TransactionRepository repo = new TransactionRepository();
            var sve = repo.GetAllTransactions(_userId);

            UkupnaStednjaDataGrid.DataSource = sve
                .Where(t => t.Type == "Štednja" || t.Title == "Isplata štednje")
                .ToList();
        }

        private void IsplatiStednjuBtn_Click(object sender, EventArgs e)
        {
            TransactionRepository repo = new TransactionRepository();
            decimal ukupnaStednja = repo.GetNetStednja(_userId);

            if (ukupnaStednja <= 0)
            {
                MessageBox.Show("Nema sredstava na štednji.");
                return;
            }

            var result = MessageBox.Show(
                "Jeste li sigurni da želite isplatiti štednju?",
                "Potvrda isplate",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (result == DialogResult.No)
                return;

            else
            {
                repo.AddTransaction(new Transactions
                {
                    UserId = _userId,
                    Title = "Isplata štednje",
                    Amount = ukupnaStednja,
                    Type = "Prihod",
                    CreatedAt = DateTime.Now
                });


                PrikaziUkupnuStednju();
                

                MessageBox.Show("Štednja je isplaćena.");

            }
        }

        private void NazadBtn_Click(object sender, EventArgs e)
        {
            GlavniMeni glavniMeni = new GlavniMeni(_userId);
            glavniMeni.Show();
            this.Close();
        }

        private void PrikaziUkupnuStednju()
        {
            OsvjeziGrid();
            TransactionRepository repo = new TransactionRepository();
            decimal netoStednja = repo.GetNetStednja(_userId);
            UkupnaStednjaLbl.Text = netoStednja.ToString("N2") + " €";
        }
    }
}