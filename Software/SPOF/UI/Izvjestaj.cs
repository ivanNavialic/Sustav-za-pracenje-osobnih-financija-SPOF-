using DataAccessLayer;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPOF.UI
{
    public partial class Izvjestaj : Form
    {
        private readonly int _userId;

        public Izvjestaj(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void Izvjestaj_Load(object sender, EventArgs e)
        {
            
            TransactionRepository repo = new TransactionRepository();
            System.Collections.Generic.List<Transactions> sve = repo.GetAllTransactions(_userId);

            decimal prihodi = sve.Where(t => t.Type == "Prihod").Sum(t => t.Amount);
            decimal rashodi = sve.Where(t => t.Type == "Rashod").Sum(t => t.Amount);
            decimal stednja = sve.Where(t => t.Type == "Štednja" || t.Type == "Stednja").Sum(t => t.Amount);

            
            if (prihodi == 0m && rashodi == 0m && stednja == 0m)
            {
                pieChart.Series[0].Points.Clear();
                MessageBox.Show("Nema podataka za prikaz.");
                return;
            }

            
            pieChart.Series[0].Points.Clear();
            pieChart.Series[0].IsVisibleInLegend = true;

            pieChart.Series[0].Points.AddXY("Prihod", prihodi);
            pieChart.Series[0].Points.AddXY("Rashod", rashodi);
            pieChart.Series[0].Points.AddXY("Štednja", stednja);

            
            pieChart.Series[0].Label = "#PERCENT{P1}";          
            pieChart.Series[0].LegendText = "#VALX (#VAL{N2})"; 
            if (pieChart.Legends.Count > 0) pieChart.Legends[0].Enabled = true;


        }

        private void NazadBtn_Click(object sender, EventArgs e)
        {
            GlavniMeni glavniMeni = new GlavniMeni(_userId);
            glavniMeni.Show();
            this.Close();
        }
    }
}
