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
    public partial class purchuaseInvoiceDetails : Sample2
    {
        public purchuaseInvoiceDetails()
        {
            InitializeComponent();
        }
        retrieval re = new retrieval();

        private void rightPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {
            re.ShowDropDownListWTRTwoParam("st_getPurIvnList" ,CompanyDD, "Company" , "ID" , "@month" ,DatePicker.Value.Month , "@year" ,DatePicker.Value.Year);
        }
        
        private void CompanyDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CompanyDD.SelectedIndex !=-1 && CompanyDD.SelectedIndex != 0)
            {
                re.showPurInvDetailWRTPurID(Convert.ToInt64(CompanyDD.SelectedValue), PurInv_dataGridView, ProIdGv, ProductGv, PrizePUGv, QtyGV, TotalAmtGv);
                float Gt = 0;
                foreach (DataGridViewRow row in PurInv_dataGridView.Rows)
                {
                    Gt += Convert.ToSingle(row.Cells["TotalAmtGv"].Value.ToString());
                }
                GrossAmtPrzTxt.Text = Gt.ToString();
                Gt = 0;
            }
        }

        private void purchuaseInvoiceDetails_Load(object sender, EventArgs e)
        {
            re.ShowDropDownListWTRTwoParam("st_getPurIvnList", CompanyDD, "Company", "ID", "@month", DatePicker.Value.Month, "@year", DatePicker.Value.Year);
        }
    }
}
