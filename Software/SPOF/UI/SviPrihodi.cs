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

namespace SPOF.UI
{
    public partial class SviPrihodi : Form
    {
        private readonly int _userId;
        public SviPrihodi(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void SviPrihodi_Load(object sender, EventArgs e)
        {
            GridHelper.CustomizeGridAppearance(SviPrihodiDataGrid);

            TransactionRepository repo = new TransactionRepository();
            var sve = repo.GetAllTransactions(_userId);

            SviPrihodiDataGrid.DataSource = sve
            .Where(t => t.Type == "Prihod")
            .ToList();
        }

        private void NazadBtn_Click(object sender, EventArgs e)
        {
            GlavniMeni glavniIzbornik = new GlavniMeni(_userId);
            glavniIzbornik.Show();
            this.Close();
        }
    }
}
