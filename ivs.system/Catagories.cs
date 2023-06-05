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
    public partial class Catagories : Sample2
    {
        public Catagories()
        {
            InitializeComponent();
        }
        //global varaibles
        int edit = 0; // this is used indification for save buttton .... what is want to save 
        short Stat;
        int CatID;public override void AddBtn_Click(object sender, EventArgs e)
        {
            Mainclass.enable_reset(LeftPanel);
            edit = 0;

        }
        retrieval re = new retrieval();

        private void Catagories_Load(object sender, EventArgs e)
        {
            Mainclass.disable(LeftPanel);
        }
        

        public override void SaveBtn_Click(object sender, EventArgs e)
        {
            if (Cat_NameTxt.Text == "") { CatErrorLbl.Visible = true; } else { CatErrorLbl.Visible = false; }
            if (StatusDD.SelectedIndex == -1) { StatusErrorLbl.Visible = true; } else { StatusErrorLbl.Visible = false; }
            if (StatusDD.SelectedIndex == 0)
            {
                Stat = 1; // its means user is active in database 1 == Active
            }
            else if (StatusDD.SelectedIndex == 1)
            {
                Stat = 0;// its means user is un active in database 0 == unActive
            }
            if (CatErrorLbl.Visible | StatusErrorLbl.Visible)
            {
                Mainclass.showMsg("All Filed is required", "Caption", "Error");
            }
            else
            {
                if (edit == 0) // insering new record of user 
                {

                    Insertion i = new Insertion();
                    i.insertCat(Cat_NameTxt.Text, Stat);

                }
                else if (edit == 1)
                {
                    DialogResult dr = MessageBox.Show("Are you sure Update your record", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Updatation u = new Updatation();
                        u.updateCat(CatID, Cat_NameTxt.Text, Stat);


                    }
                }
                re.showCat(Cat_dataGridView, IdGv, NameGv, StsGv);
            }
            Mainclass.disable_reset(LeftPanel);
        }

        public override void DelBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure Delect your record", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Deletion delRecord = new Deletion();
                delRecord.deleting(CatID, "st_DeleteCat", "@id");
            }
            re.showCat(Cat_dataGridView, IdGv, NameGv, StsGv);
            Mainclass.disable(LeftPanel);
        }

        public override void EditBtn_Click(object sender, EventArgs e)
        {
            Mainclass.enable(LeftPanel);
            edit = 1;
        }
        public override void viewBtn_Click(object sender, EventArgs e)
        {
            re.showCat(Cat_dataGridView, IdGv, NameGv, StsGv);

            Mainclass.disable_reset(LeftPanel);
        }
        public override void searchtxt_TextChanged(object sender, EventArgs e)
        {
            
            if (searchtxt.Text != "")
            {
                re.showCat(Cat_dataGridView, IdGv, NameGv, StsGv,searchtxt.Text);
            }
            else
            {
                re.showCat(Cat_dataGridView, IdGv, NameGv, StsGv);
            }
        }

        
        private void Cat_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                DataGridViewRow row = Cat_dataGridView.Rows[e.RowIndex];
                CatID = Convert.ToInt32(row.Cells["IdGv"].Value.ToString());
                Cat_NameTxt.Text = row.Cells["NameGv"].Value.ToString();
                StatusDD.SelectedItem = row.Cells["StsGv"].Value.ToString();

            }
            Mainclass.disable(LeftPanel);
        }

    }
}
