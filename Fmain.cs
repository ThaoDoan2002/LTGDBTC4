using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTC4
{
    public partial class Fmain : Form
    {
        public Fmain()
        {
            InitializeComponent();
        }

        private void FrChild_Load(object sender, EventArgs e)
        {

        }

        private void mnNew_Click(object sender, EventArgs e)
        {
            Form f = new Fchild();
            f.MdiParent = this;
            f.Show();
        }

        private void mnCloseAll_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
        }

        private void mnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
