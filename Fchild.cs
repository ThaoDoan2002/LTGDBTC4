using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTC4
{
    public partial class Fchild : Form
    {
        Image img;
        public Fchild()
        {
            InitializeComponent();
        }

        private void Fchild_Load(object sender, EventArgs e)
        {
            img = Image.FromFile("meo.jpg");//duong dan tuong doi
            pic.Image = img;

        }

        private void mnLoad_Click(object sender, EventArgs e)
        {
            img = Image.FromFile("meo.jpg");//duong dan tuong doi
            pic.Image = img;
        }

        private void mnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Title = "Chose a Image";
            of.Filter = "File png|*.png|File jpg|*.jpg";
            if (of.ShowDialog() == DialogResult.OK)
            {
                img = Image.FromFile(of.FileName);
                pic.Image = img;
            }
        }

        private void mnClear_Click(object sender, EventArgs e)
        {
            pic.Image = null;
        }

        private void mnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Title = "Save a image";
            sf.Filter = "File anh|*.png|File anh|*.jpeg";
            if(sf.ShowDialog() == DialogResult.OK)
            {
                if (sf.FileName.ToLower().EndsWith("png"))
                {
                    img.Save(sf.FileName, ImageFormat.Png);
                }
                else if (sf.FileName.ToLower().EndsWith("jpeg"))
                {
                    img.Save(sf.FileName, ImageFormat.Jpeg);
                }
            }
        }
    }
}
