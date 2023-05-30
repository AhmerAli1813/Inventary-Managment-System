using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace ivs.system
{
    public partial class setting : Sample
    {
        public setting()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void leftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string s;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (intS.Checked)
            {
                if (ServerTexbox.Text != "" && DbTexBox.Text != "")
                {
                    s = "Data Source="+ServerTexbox.Text+";Initial Catalog="+DbTexBox.Text+ ";Integrated Security=True;MultipleActiveResultSets=True;";
                    File.WriteAllText(path+"//connect", s);
                    DialogResult dr = MessageBox.Show("setting save successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (dr == DialogResult.OK)
                    {
                        Login log = new Login();
                        Mainclass.showWindow(log, this, MDI.ActiveForm);
                    }
                }
            }
            else
            {
                if (ServerTexbox.Text != "" && DbTexBox.Text != "" && uname.Text!="" )
                {
                    if (pwdTexbox.Text == "")
                    {
                        pwdTexbox.Text = null;
                    }
                    
                    s = "Data Source=" + ServerTexbox.Text + ";Initial Catalog=" + DbTexBox.Text + ";User ID="+uname.Text+";Password"+pwdTexbox.Text+ ";MultipleActiveResultSets=True;";
                    File.WriteAllText(path+"//connect", s);
                    DialogResult dr = MessageBox.Show("setting save successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (dr == DialogResult.OK)
                    {
                        Login log = new Login();
                        Mainclass.showWindow(log, this, MDI.ActiveForm);
                    }
                }
                else
                {
                    MessageBox.Show("all filed all requred");
                }
            }
           
        }
        private void intS_CheckedChange(object sender, EventArgs e)
        {
            if (intS.Checked)
            {
                uname.Enabled = false;
                pwdTexbox.Enabled = false;
                uname.Text = "";
                pwdTexbox.Text = "";
                uname.BackColor = Color.DarkGray;
                pwdTexbox.BackColor = Color.DarkGray;
            }
            else
            {
                uname.Enabled = true;
                pwdTexbox.Enabled = true;

            }
        }

    }
}
