using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace ivs.system
{
    class Mainclass
    {
        //create Database connection variable 
       private static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);




        private static string s = File.ReadAllText(path+"\\connect");
           
        

        //public static string S { get => s; set => s = value; }
        public static SqlConnection con = new SqlConnection(s);

        

        // Message box is function (method) created
        public static DialogResult showMsg(string msg , string heading , string type)
        {
            if(type == "success")
            {
               return MessageBox.Show(msg, heading, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else if (type == "Error")
            {
               return MessageBox.Show(msg, heading, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               return MessageBox.Show(msg, heading, MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        public static void showWindow(Form openWin, Form closeWin, Form MdIWin)
        {
            closeWin.Close();
            openWin.MdiParent = MdIWin;
            openWin.WindowState = FormWindowState.Maximized;
            openWin.Show();
        }
        public static void showWindow(Form openWin, Form MdIWin)
        {
            openWin.MdiParent = MdIWin;
            openWin.WindowState = FormWindowState.Maximized;
            openWin.Show();
        }
         
        public static void disable_reset(Panel p)
        {
            
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Text = "";
                    t.Enabled = false;
                    t.BackColor = System.Drawing.Color.DarkGray;
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Text = "";
                    cb.Enabled = false;
                    cb.SelectedIndex = -1;
                    cb.BackColor = System.Drawing.Color.DarkGray;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = false;
                    rb.Checked = false;
                }
                if (c is CheckBox)
                {
                    CheckBox ch = (CheckBox)c;
                    ch.Enabled = false;
                    ch.Checked = false;
                }
            }
        }
        public static void disable(Panel p)
        {

            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = false;
                    t.BackColor = System.Drawing.Color.DarkGray;
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = false;
                    cb.BackColor = System.Drawing.Color.DarkGray;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = false;
                }
                if (c is CheckBox)
                {
                    CheckBox ch = (CheckBox)c;
                    ch.Enabled = false;
                }
            }
        }

        public static void enable_reset(Panel p)
        {

            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Text = "";
                    t.Enabled = true;
                    t.BackColor = System.Drawing.Color.White;
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Text = "";
                    cb.Enabled = true;
                    cb.SelectedIndex = -1;
                    cb.BackColor = System.Drawing.Color.White;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = true;
                    rb.Checked = false;
                }
                if (c is CheckBox)
                {
                    CheckBox ch = (CheckBox)c;
                    ch.Enabled = true;
                    ch.Checked = false;
                   
                }
            }
        }
        public static void enable(Panel p)
        {

            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = true;
                    t.BackColor = System.Drawing.Color.White;
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;
                    cb.BackColor = System.Drawing.Color.White;

                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = true;
                }
                if (c is CheckBox)
                {
                    CheckBox ch = (CheckBox)c;
                    ch.Enabled =true ;
                }
            }
        }

    }
}
