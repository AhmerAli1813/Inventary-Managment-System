using ivs.system.DbFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ivs.system
{
    public partial class Stocks : Sample2
    {
        retrieval re = new retrieval();
        public Stocks()
        {
            InitializeComponent();
        }

        private void Stocks_Load(object sender, EventArgs e)
        {

        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            re.showStocks(Stocks_dataGridView, stkdGv, ProIdGv, BarcodeGv,CatgoeryGv, ProductGv, PrizePrUntGv, QtyGv, TotalAmtGv, ExDateGv, StatusGv);
            float Gt = 0;
            foreach (DataGridViewRow row in Stocks_dataGridView.Rows)
            {
                Gt += Convert.ToSingle(row.Cells["TotalAmtGv"].Value.ToString());
            }
            GrossAmtPrzTxt.Text = Gt.ToString();
            Gt = 0;
        }
    }
}
