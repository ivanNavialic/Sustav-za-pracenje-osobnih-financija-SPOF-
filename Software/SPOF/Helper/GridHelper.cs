using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPOF.Helper
{
    public static class GridHelper
    {
        public static void CustomizeGridAppearance(DataGridView grid)
        {
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.AutoGenerateColumns = false;
            grid.RowTemplate.Height = 33;
            grid.Columns.Clear();

            DataGridViewColumn[] columns = new DataGridViewColumn[6];
            columns[0] = new DataGridViewTextBoxColumn() { DataPropertyName = "TransactionId", Visible = false };
            columns[1] = new DataGridViewTextBoxColumn() { DataPropertyName = "UserId", Visible = false };
            columns[2] = new DataGridViewTextBoxColumn() { DataPropertyName = "Title", HeaderText = "Naziv" };
            columns[3] = new DataGridViewTextBoxColumn() { DataPropertyName = "Amount", HeaderText = "Iznos" };
            columns[4] = new DataGridViewTextBoxColumn() { DataPropertyName = "Type", HeaderText = "Vrsta" };
            columns[5] = new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "CreatedAt",
                HeaderText = "Datum",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd.MM.yyyy" }
            };

            grid.Columns.AddRange(columns);
        }

    }
}