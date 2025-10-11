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
    public partial class SviRashodi : Form
    {
        private readonly int _userId;
        public SviRashodi(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void SviRashodi_Load(object sender, EventArgs e)
        {
            GridHelper.CustomizeGridAppearance(SviRashodiDataGrid);

            TransactionRepository repo = new TransactionRepository();
            var sve = repo.GetAllTransactions(_userId);

            SviRashodiDataGrid.DataSource = sve
            .Where(t => t.Type == "Rashod")
            .ToList();
        }

        private void NazadBtn_Click(object sender, EventArgs e)
        {
            GlavniMeni glavniMeni = new GlavniMeni(_userId);
            glavniMeni.Show();
            this.Close();
        }
    }
}
