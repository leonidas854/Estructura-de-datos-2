using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optica_Tokio.UI.Formularios
{
    public partial class InformedelReport : Form
    {
        public InformedelReport()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            decimal totalStock = 0;
            decimal totalSold = 0;
            decimal totalCurrent = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["StockQuantity"].Value != null)
                    totalStock += Convert.ToDecimal(row.Cells["StockQuantity"].Value);

                if (row.Cells["SoldQuantity"].Value != null)
                    totalSold += Convert.ToDecimal(row.Cells["SoldQuantity"].Value);

                if (row.Cells["CurrentQuantity"].Value != null)
                    totalCurrent += Convert.ToDecimal(row.Cells["CurrentQuantity"].Value);
            }

            // Dibuja el total debajo del DataGridView
            if (e.RowIndex == dataGridView1.Rows.Count - 1) // Última fila pintada
            {
                using (Graphics g = dataGridView1.CreateGraphics())
                {
                    string totalText = $"Total = {totalStock} | {totalSold} | {totalCurrent}";
                    g.DrawString(totalText, dataGridView1.Font, Brushes.Black, new PointF(dataGridView1.Width - 200, dataGridView1.Height - 30));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
