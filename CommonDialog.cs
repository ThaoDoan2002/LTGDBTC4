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
    public partial class CommonDialog : Form
    {
        public CommonDialog()
        {
            InitializeComponent();
        }

        private void CommonDialog_Load(object sender, EventArgs e)
        {
            timerStart.Enabled = true; ;
            init();
        }
        private void init()
        {
            txtNoiDung.Text = "Chương trình demo các hộp thoại thông dụng của Windows";
            txtNoiDung.ForeColor = Color.Blue;
            txtNoiDung.Font = new Font("Arial", 18, FontStyle.Bold);
        }

        private void timerStart_Tick(object sender, EventArgs e)
        {
            if (this.Opacity >= 1)
            {
                timerStart.Enabled = false;
            }
            else
            {
                this.Opacity += 0.05;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Close?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                timerClose.Start();
            }
        }

        private void timerClose_Tick(object sender, EventArgs e)
        {
            if (this.Opacity <= 0)
            {
                timerClose.Enabled = false;
                Application.Exit();
            }
            else
            {
                this.Opacity -= 0.05;
            }
        }

        private void btnChonMotTT_Click(object sender, EventArgs e)
        {
            txtNoiDung.Text = "";
            OpenFileDialog of = new OpenFileDialog();
            of.Title = "Choose a file";
            of.Filter = "Text file|*.txt";
            if (of.ShowDialog() == DialogResult.OK)
            {
                txtNoiDung.Text = of.FileName;
            }
        }

        private void btnChonNhieuTT_Click(object sender, EventArgs e)
        {
            txtNoiDung.Text = "";
            OpenFileDialog ofs = new OpenFileDialog();
            ofs.Multiselect = true;
            ofs.Title = "Choose some files";
            ofs.Filter = "Text file|*.txt|File Docx|*.docx|All file|*.*";
            if (ofs.ShowDialog() == DialogResult.OK)
            {
                txtNoiDung.Text += String.Format("Có {0} file:\r\n", ofs.FileNames.Length);
                foreach (string f in ofs.FileNames)
                {
                    txtNoiDung.Text += f + "\r\n";
                }
            }
        }

        private void btnChonThuMuc_Click(object sender, EventArgs e)
        {
            txtNoiDung.Text = "";
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.UseDescriptionForTitle = true;
            folder.Description = "Browser for folder";
            if (folder.ShowDialog() == DialogResult.OK)
            {
                txtNoiDung.Text += folder.SelectedPath;
            }
        }

        private void btnChonMauNen_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                txtNoiDung.BackColor = color.Color;
            }
        }

        private void btnChonMauChu_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.FullOpen = true;
            if (color.ShowDialog() == DialogResult.OK)
            {
                txtNoiDung.BackColor = color.Color;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            init();
        }

        private void btnChonFont_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            font.ShowApply = true;
            font.Apply += Font_Apply;
            if (font.ShowDialog() == DialogResult.OK)
            {
                txtNoiDung.Font = font.Font;
            }
        }

        private void Font_Apply(object? sender, EventArgs e)
        {
            FontDialog f = (FontDialog)sender;
            txtNoiDung.Font = f.Font;
        }

        private void CommonDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            timerClose.Enabled =true;
        }
    }
}
