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
    public partial class Suppliers : Sample2
    {
        public Suppliers()
        {
            InitializeComponent();
        }
        //global varaibles
        int edit = 0; // this is used indification for save buttton .... what is want to save 
        short Stat;
        int SupplierID;
        retrieval re = new retrieval();

        private void Suppliers_Load(object sender, EventArgs e)
        {
            Mainclass.disable(LeftPanel);
        }
        public override void AddBtn_Click(object sender, EventArgs e)
        {
            Mainclass.enable_reset(LeftPanel);
            edit = 0;

        }

        public override void SaveBtn_Click(object sender, EventArgs e)
        {
            if (CompNameTxt.Text == "") { CompNameErrorLbl.Visible = true; } else { CompNameErrorLbl.Visible = false; }
            if (EmpNameTxt.Text == "") { EmpErrorLbl.Visible = true; } else { EmpErrorLbl.Visible = false; }
            if (AddressTxt.Text == "") { AddressErrorLbl.Visible = true; } else { AddressErrorLbl.Visible = false; }
            
            if (PhnTxt.Text == "") { PhnErrorLbl.Visible = true; } else { PhnErrorLbl.Visible = false; }
         
            if (StatusDD.SelectedIndex == -1) { StatusErrorLbl.Visible = true; } else { StatusErrorLbl.Visible = false; }
            if (StatusDD.SelectedIndex == 0)
            {
                Stat = 1; // its means user is active in database 1 == Active
            }
            else if (StatusDD.SelectedIndex == 1)
            {
                Stat = 0;// its means user is un active in database 0 == unActive
            }
            if (EmpErrorLbl.Visible   | CompNameErrorLbl.Visible | AddressErrorLbl.Visible  | PhnErrorLbl.Visible | StatusErrorLbl.Visible)
            {
                Mainclass.showMsg("All Filed is required", "Caption", "Error");
            }
            else
            {
                if (edit == 0) // insering new record of user 
                {

                    Insertion i = new Insertion();
                    if(Phn2Txt.Text =="" && NTNTxt.Text == "")
                    {
                        i.insertSuppliers(CompNameTxt.Text, EmpNameTxt.Text, AddressTxt.Text, Convert.ToInt32(PhnTxt.Text), Stat);
                    }
                    else if(Phn2Txt.Text != "" && NTNTxt.Text == "")
                    {
                        i.insertSuppliers(CompNameTxt.Text, EmpNameTxt.Text, AddressTxt.Text, Convert.ToInt32(PhnTxt.Text), Stat, Convert.ToInt32(Phn2Txt.Text));
                    }
                    else if (Phn2Txt.Text == "" && NTNTxt.Text != "")
                    {
                        i.insertSuppliers(CompNameTxt.Text, EmpNameTxt.Text, AddressTxt.Text, Convert.ToInt32(PhnTxt.Text), Stat,null,NTNTxt.Text);
                    }
                    else
                    {
                        i.insertSuppliers(CompNameTxt.Text, EmpNameTxt.Text, AddressTxt.Text, Convert.ToInt32(PhnTxt.Text), Stat, Convert.ToInt32(PhnTxt.Text),NTNTxt.Text);
                    }

                }
                else if (edit == 1)
                {
                    DialogResult dr = MessageBox.Show("Are you sure Update your record", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Updatation u = new Updatation();
                        u.updateCat(SupplierID, EmpNameTxt.Text, Stat);
                        if (Phn2Txt.Text == "" && NTNTxt.Text == "")
                        {
                            u.updateSuppliers(SupplierID, CompNameTxt.Text, EmpNameTxt.Text, AddressTxt.Text, Convert.ToInt32(PhnTxt.Text), Stat);
                        }
                        else if (Phn2Txt.Text != "" && NTNTxt.Text == "")
                        {
                            u.updateSuppliers(SupplierID, CompNameTxt.Text, EmpNameTxt.Text, AddressTxt.Text, Convert.ToInt32(PhnTxt.Text), Stat, Convert.ToInt32(Phn2Txt.Text));
                        }
                        else if (Phn2Txt.Text == "" && NTNTxt.Text != "")
                        {
                            u.updateSuppliers(SupplierID, CompNameTxt.Text, EmpNameTxt.Text, AddressTxt.Text, Convert.ToInt32(PhnTxt.Text), Stat, null, NTNTxt.Text);
                        }
                        else
                        {
                            u.updateSuppliers(SupplierID, CompNameTxt.Text, EmpNameTxt.Text, AddressTxt.Text, Convert.ToInt32(PhnTxt.Text), Stat, Convert.ToInt32(PhnTxt.Text), NTNTxt.Text);
                        }

                    }
                }
                re.showSuppliers(Suppliers_dataGridView, IdGv, CompNameGv,EmployeeGv,AddressGv,NTNGV,Phone1Gv,Phone2Gv, StsGv);
            }
            Mainclass.disable_reset(LeftPanel);
        }

        public override void DelBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure Delect your record", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Deletion delRecord = new Deletion();
                delRecord.deleting(SupplierID, "st_deleteSuppliers", "@id");
            }
            re.showSuppliers(Suppliers_dataGridView, IdGv, CompNameGv, EmployeeGv, AddressGv, NTNGV, Phone1Gv, Phone2Gv, StsGv);
            Mainclass.disable(LeftPanel);
        }

        public override void EditBtn_Click(object sender, EventArgs e)
        {
            Mainclass.enable(LeftPanel);
            edit = 1;
        }
        public override void viewBtn_Click(object sender, EventArgs e)
        {
            re.showSuppliers(Suppliers_dataGridView, IdGv, CompNameGv, EmployeeGv, AddressGv, NTNGV, Phone1Gv, Phone2Gv, StsGv);

            Mainclass.disable_reset(LeftPanel);
        }
        public override void searchtxt_TextChanged(object sender, EventArgs e)
        {

            if (searchtxt.Text != "")
            {
                re.showSuppliers(Suppliers_dataGridView, IdGv, CompNameGv, EmployeeGv, AddressGv, NTNGV, Phone1Gv, Phone2Gv, StsGv, searchtxt.Text);
            }
            else
            {
                re.showSuppliers(Suppliers_dataGridView, IdGv, CompNameGv, EmployeeGv, AddressGv, NTNGV, Phone1Gv, Phone2Gv, StsGv);
            }
        }


        private void Suppliers_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                DataGridViewRow row = Suppliers_dataGridView.Rows[e.RowIndex];
                SupplierID = Convert.ToInt32(row.Cells["IdGv"].Value.ToString());
                CompNameTxt.Text = row.Cells["CompNameGv"].Value.ToString();
                EmpNameTxt.Text = row.Cells["CompNameGv"].Value.ToString();
                AddressTxt.Text = row.Cells["AddressGv"].Value.ToString();
                NTNTxt.Text = row.Cells["NTNGV"].Value.ToString();
                PhnTxt.Text = row.Cells["Phone1Gv"].Value.ToString();
                Phn2Txt.Text = row.Cells["Phone2Gv"].Value.ToString();
                StatusDD.SelectedItem = row.Cells["StsGv"].Value.ToString();

            }
            Mainclass.disable(LeftPanel);

        }

        private void CompNameTxt_TextChanged(object sender, EventArgs e)
        {
            if (CompNameTxt.Text == "") { CompNameErrorLbl.Visible = true; } else { CompNameErrorLbl.Visible = false; }
        }

        private void EmpNameTxt_TextChanged(object sender, EventArgs e)
        {
            if (EmpNameTxt.Text == "") { EmpErrorLbl.Visible = true; } else { EmpErrorLbl.Visible = false; }
        }

        private void AddressTxt_TextChanged(object sender, EventArgs e)
        {
            if (AddressTxt.Text == "") { AddressErrorLbl.Visible = true; } else { AddressErrorLbl.Visible = false; }
        }

        private void PhnTxt_TextChanged(object sender, EventArgs e)
        {
            if (PhnTxt.Text == "") { PhnErrorLbl.Visible = true; } else { PhnErrorLbl.Visible = false; }
        }

        private void StatusDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StatusDD.SelectedIndex == -1) { StatusErrorLbl.Visible = true; } else { StatusErrorLbl.Visible = false; }
        }

    }
}
