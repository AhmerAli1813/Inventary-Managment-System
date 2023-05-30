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
    public partial class Login : Sample
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            
            if  (unameTxt.Text == "") { unameErrorLbl.Visible = true; } else { unameErrorLbl.Visible = false; }
          
            if (PassTxt.Text == "") { PassErrorLbl.Visible = true; } else { PassErrorLbl.Visible = false; }

            if(unameErrorLbl.Visible | PassErrorLbl.Visible)
            {
                Mainclass.showMsg("All Flied are reqiured", "Caption", "Error");
            }
            else
            {
                if (retrieval.getUserDetail(unameTxt.Text, PassTxt.Text))
                {
                    HomeScreen homeScreen = new HomeScreen();
                    Mainclass.showWindow(homeScreen, this, MDI.ActiveForm);
                }
            }
            
        }

        private void unameTxt_TextChanged(object sender, EventArgs e)
        {
            if (unameTxt.Text == "") { unameErrorLbl.Visible = true; } else { unameErrorLbl.Visible = false; }
        }

        private void PassTxt_TextChanged(object sender, EventArgs e)
        {
            if (PassTxt.Text == "") { PassErrorLbl.Visible = true; } else { PassErrorLbl.Visible = false; }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            MDI.logoutToolStripMenuItem.Enabled = false;
            retrieval.checkLogin = false;
        }
    }
}
