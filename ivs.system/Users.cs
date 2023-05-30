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
    public partial class Users : Sample2
    {
        int edit = 0; // this is used indification for save buttton .... what is want to save 
        short Stat;
        int UserID;
        retrieval re = new retrieval();
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            
            Mainclass.disable(LeftPanel);
        //    re.showUser(UserdataGridView1, U_IdGv, U_NameGv, U_UsernameGv, U_EmailGv, passGv, U_StsGv);
        }
        public override void AddBtn_Click(object sender, EventArgs e)
        {
            Mainclass.enable_reset(LeftPanel);
            edit = 0;
            
        }

        public override void SaveBtn_Click(object sender, EventArgs e)
        {
           if(U_UsernameTxt.Text == "") { U_UsernameErrorLbl.Visible = true; }else { U_UsernameErrorLbl.Visible = false; }
            if (U_NameTxt.Text == "") { U_NameErrorLbl.Visible = true; } else { U_NameErrorLbl.Visible = false; }
            if (U_EmailTxt.Text == "") { U_EmailErrorLbl.Visible = true; } else { U_EmailErrorLbl.Visible = false; }
            if (U_PassTxt.Text == "") { U_PassErrorLbl.Visible = true; } else { U_PassErrorLbl.Visible = false; }
            if (U_StatusDD.SelectedIndex == -1) { U_StatusErrorLbl.Visible = true; } else { U_StatusErrorLbl.Visible = false; }
            if(U_StatusDD.SelectedIndex == 0)
            {
                Stat = 1; // its means user is active in database 1 == Active
            }else if (U_StatusDD.SelectedIndex==1)
            {
                Stat = 0;// its means user is un active in database 0 == unActive
            }
            if (U_PassErrorLbl.Visible | U_UsernameErrorLbl.Visible | U_NameErrorLbl.Visible| U_EmailErrorLbl.Visible| U_StatusErrorLbl.Visible)
            {
                Mainclass.showMsg("hello All Filed is required", "Caption", "Error");
            }
            else
            {
                if (edit == 0) // insering new record of user 
                {
                    
                    Insertion i = new Insertion();
                    i.insertUser( U_NameTxt.Text,U_UsernameTxt.Text, U_EmailTxt.Text, U_PassTxt.Text , Stat);
                    
                } else if (edit == 1)
                {
                    DialogResult dr = MessageBox.Show("Are you sure Update your record", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                   if(dr == DialogResult.Yes)
                    {
                        Updatation u = new Updatation();
                        u.updateUser(UserID, U_NameTxt.Text, U_UsernameTxt.Text, U_EmailTxt.Text, U_PassTxt.Text, Stat);
                        

                    }
                }
               re.showUser(UserdataGridView1, U_IdGv, U_NameGv, U_UsernameGv, U_EmailGv, U_PassGv, U_StsGv);
            }
            Mainclass.disable_reset(LeftPanel);
        }

        public override void DelBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure Delect your record", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Deletion delRecord = new Deletion();
                delRecord.deleting(UserID, "st_deleteUser", "@id");
            }
            re.showUser(UserdataGridView1, U_IdGv, U_NameGv, U_UsernameGv, U_EmailGv, U_PassGv, U_StsGv);
            Mainclass.disable(LeftPanel);
        }

        public override void EditBtn_Click(object sender, EventArgs e)
        {
            Mainclass.enable(LeftPanel);
            edit = 1;
        }
        public override void viewBtn_Click(object sender, EventArgs e)
        {
            re.showUser(UserdataGridView1, U_IdGv, U_NameGv, U_UsernameGv, U_EmailGv, U_PassGv, U_StsGv);
        }
        public override void searchtxt_TextChanged(object sender, EventArgs e)
        {
            if (searchtxt.Text != "")
            {
               re.showUser(UserdataGridView1, U_IdGv, U_NameGv, U_UsernameGv, U_EmailGv, U_PassGv, U_StsGv ,searchtxt.Text);
            }
            else
            {
                re.showUser(UserdataGridView1, U_IdGv, U_NameGv, U_UsernameGv, U_EmailGv, U_PassGv, U_StsGv, searchtxt.Text);
            }
        }


        private void UserdataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                DataGridViewRow row = UserdataGridView1.Rows[e.RowIndex];
                UserID = Convert.ToInt32(row.Cells["U_IdGv"].Value.ToString());
                U_NameTxt.Text = row.Cells["U_NameGv"].Value.ToString();
                U_UsernameTxt.Text = row.Cells["U_UsernameGv"].Value.ToString();
                U_EmailTxt.Text = row.Cells["U_EmailGv"].Value.ToString();
                U_PassTxt.Text = row.Cells["U_PassGv"].Value.ToString();
                U_StatusDD.SelectedItem = row.Cells["U_StsGv"].Value.ToString();

            }
            Mainclass.disable(LeftPanel);
        }
    }
}
