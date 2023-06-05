using ivs.system.DbFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace ivs.system
{
    public partial class PurchuaseInvoice : Sample2
    {
        //global varaibles
        int? ProID;
        string _barcode, _Product, _Prize;
        string[] ProductDataArr = new string[4];
        float Qty, Prz, Tt,gt;
        int Count;
        Regex prReg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
        retrieval re = new retrieval();
        public PurchuaseInvoice()
        {
            InitializeComponent();
        }
        private void PurchuaseInvoice_Load(object sender, EventArgs e)
        {
            re.ShowDropDownList("st_getSuppliersDataList", CompanyDD, "Company", "ID");
            Mainclass.disable(LeftPanel);
        }
        private void BarcodeTxt_TextChanged(object sender, EventArgs e)
        {
            ProductDataArr = re.showProductWRTBarchoe(BarcodeTxt.Text);
            if (BarcodeTxt.Text != "")
            {
                _barcode = ProductDataArr[0];
                ProID = Convert.ToInt32(ProductDataArr[1]);
                _Product = ProductDataArr[2];
                ProductTxt.Text = _Product;
                _Prize = ProductDataArr[3];
                PPrizeTxt.Text = _Prize;
                BarErrorLbl.Visible = false;
                if (_barcode != null)
                {
                    QtyTxt.Focus();

                }
                else
                {
                    BarErrorLbl.Visible = true;
                    QtyTxt.Text = "";
                }

            }
            else
            {
                ProID = null;
                ProductTxt.Text = "";
                PPrizeTxt.Text = "";
                QtyTxt.Text = "";
                TtaAmtLbl.Text = "";
                Array.Clear(ProductDataArr, 0, ProductDataArr.Length);

            }
        }

        private void CompanyDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CompanyDD.SelectedIndex == -1) { CompanyErrorLbl.Visible = true; } else { CompanyErrorLbl.Visible = false; }
        }
        private void QtyTxt_TextChanged(object sender, EventArgs e)
        {
            if (QtyTxt.Text != "")
            {
                if (prReg.Match(QtyTxt.Text).Success)
                {
                    
                    Qty = Convert.ToSingle(QtyTxt.Text);
                    Prz = Convert.ToSingle(PPrizeTxt.Text);
                    Tt = Qty * Prz;
                    TtaAmtLbl.Text = Tt.ToString("#########.###");

                }
                else
                {
                    QtyTxt.SelectAll();
                }
            }
            else
            {
                QtyTxt.Text = "";
                TtaAmtLbl.Text = "0.00";
            }

        }
        public override void AddBtn_Click(object sender, EventArgs e)
        {
            Mainclass.enable_reset(LeftPanel);


        }
        private void AddCartBtn_Click(object sender, EventArgs e)
        {
            if (CompanyDD.SelectedIndex == -1) { CompanyErrorLbl.Visible = true; } else { CompanyErrorLbl.Visible = false; }
            if (BarcodeTxt.Text == "") { BarErrorLbl.Visible = true; } else { BarErrorLbl.Visible = false; }
            if (QtyTxt.Text == "") { QtyErrorLbl.Visible = true; } else { QtyErrorLbl.Visible = false; }

            if (BarErrorLbl.Visible | QtyErrorLbl.Visible | CompanyErrorLbl.Visible)
            {
                Mainclass.showMsg("All Filed is required", "Caption", "Error");
            }
            else
            {
                PurInv_dataGridView.Rows.Add(ProID,CompanyDD.Text,ProductTxt.Text,PPrizeTxt.Text,QtyTxt.Text, TtaAmtLbl.Text);

                gt += Tt;
                GrossAmtPrzTxt.Text = gt.ToString();
                BarcodeTxt.Text = "";
                ProID = null;
                ProductTxt.Text = "";
                PPrizeTxt.Text = "";
                QtyTxt.Text = "";
                TtaAmtLbl.Text = "";
                Array.Clear(ProductDataArr, 0, ProductDataArr.Length);
            }
        }
        private void PurInv_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex !=-1 && e.ColumnIndex != -1)
            {
                if(e.ColumnIndex == 6)
                {
                    DataGridViewRow row = PurInv_dataGridView.Rows[e.RowIndex];
                    gt -= Convert.ToSingle(row.Cells["TotalAmtGv"].Value.ToString());
                    GrossAmtPrzTxt.Text = gt.ToString();
                    PurInv_dataGridView.Rows.Remove(row);

                }
            }
        }
        public override void SaveBtn_Click(object sender, EventArgs e)
        {
            Int64 PurInvID;
            Insertion i = new Insertion();
            Updatation u = new Updatation();
            using (TransactionScope Trsc = new TransactionScope())
            {
                PurInvID =i.insertPurchaseInvoice(DateTime.Now.Date, retrieval._UId, Convert.ToInt32(CompanyDD.SelectedValue));
                foreach(DataGridViewRow row in PurInv_dataGridView.Rows)
                {
                    Count += i.insertPurchaseInvoiceDetails(PurInvID, Convert.ToInt32(row.Cells["ProIdGv"].Value.ToString()), Convert.ToInt32(row.Cells["QtyGV"].Value.ToString()), Convert.ToSingle(row.Cells["PrizePUGv"].Value.ToString()));
                    int q;
                    object ob = re.GetProductStockQuatity(Convert.ToInt32(row.Cells["ProIdGv"].Value.ToString()));
                    if (ob != null)
                    {
                        q = Convert.ToInt32(ob);
                        q += Convert.ToInt32(row.Cells["QtyGV"].Value.ToString());
                        u.updateStock(Convert.ToInt32(row.Cells["ProIdGv"].Value.ToString()), q);
                    }
                    else
                    {
                        i.insertStock(Convert.ToInt32(row.Cells["ProIdGv"].Value.ToString()), Convert.ToInt32(row.Cells["QtyGV"].Value.ToString()));
                    }
                }
                if(Count > 0)
                {

                    Mainclass.showMsg("Purchuase Succcessfully ", "Success", "Success");
                }
                else
                {
                    Mainclass.showMsg("Purchuase UnSucccessfully ", "Error", "Error");
                }
                Trsc.Complete();
            }
            


        }
        public override void viewBtn_Click(object sender, EventArgs e)
        {
            purchuaseInvoiceDetails win = new purchuaseInvoiceDetails();
            Mainclass.showWindow(win, this, MDI.ActiveForm);

            
        }
    }
}
