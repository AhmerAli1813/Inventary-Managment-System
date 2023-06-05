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
    public partial class HomeScreen : Sample
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            MDI.logoutToolStripMenuItem.Enabled = true;
            WlcUserLbl.Text = retrieval._UName;
        }
        
        private void Users_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            Mainclass.showWindow(users, this, MDI.ActiveForm);
        }

        private void CatBtn_Click(object sender, EventArgs e)
        {
            Catagories windowOpen = new Catagories();
            Mainclass.showWindow(windowOpen, this, MDI.ActiveForm);
        }

        private void Products_Click(object sender, EventArgs e)
        {
            Products windowOpen = new Products();
            Mainclass.showWindow(windowOpen, this, MDI.ActiveForm);
        }

        private void SupplierBtn_Click(object sender, EventArgs e)
        {
            Suppliers windowOpen = new Suppliers();
            Mainclass.showWindow(windowOpen, this, MDI.ActiveForm);

        }

        private void Inv_purc_Click(object sender, EventArgs e)
        {
            PurchuaseInvoice windowOpen = new PurchuaseInvoice();
            Mainclass.showWindow(windowOpen, this, MDI.ActiveForm);
        }

        private void Stocks_Click(object sender, EventArgs e)
        {

            Stocks windowOpen = new Stocks();
            Mainclass.showWindow(windowOpen, this, MDI.ActiveForm);
        }
    }
}
