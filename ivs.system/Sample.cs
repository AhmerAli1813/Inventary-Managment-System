using System;
using System.Windows.Forms;

namespace ivs.system
{
    public partial class Sample : Form
    {
        public Sample()
        {
            InitializeComponent();
        }

        public virtual  void BackBtn_Click(object sender, EventArgs e)
        {

            HomeScreen hs = new HomeScreen();
            Mainclass.showWindow(hs, this, MDI.ActiveForm);
        }
    }
}
