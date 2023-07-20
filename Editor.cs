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
    public partial class Editor : Form
    {
        Font f;
        FontStyle fs;
        public Editor()
        {
            InitializeComponent();
        }

        private void Editor_Load(object sender, EventArgs e)
        {

            cBSize.SelectedItem = "12";

            foreach (FontFamily fontF in FontFamily.Families)
            {
                listFontFamily.Items.Add(fontF.Name);
            }
            listFontFamily.SelectedItem = "Arial";
        }

        private void rTBContent_SelectionChanged(object sender, EventArgs e)
        {

            cBSize.SelectedItem = "12";
            listFontFamily.SelectedItem = "Arial";
        }

        private void listFontFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rTBContent.SelectedText != "")
            {
                f = new Font(listFontFamily.SelectedItem.ToString(),
                    int.Parse(cBSize.SelectedItem.ToString()));
                rTBContent.SelectionFont = f;
            }
        }

        private void cBSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rTBContent.SelectedText != "")
            {
                f = new Font(listFontFamily.SelectedItem.ToString(),
                    int.Parse(cBSize.SelectedItem.ToString()));
                rTBContent.SelectionFont = f;
            }
        }

        private void cbBold_CheckedChanged(object sender, EventArgs e)
        {
            if (rTBContent.SelectedText != "")
            {
                if (cbBold.Checked)
                {
                    if (!cBItalic.Checked && !cbUnderline.Checked)
                    {
                        fs = FontStyle.Bold;
                    }
                    else if (cBItalic.Checked && !cbUnderline.Checked)
                    {
                        fs = FontStyle.Bold | FontStyle.Italic;
                    }
                    else if (!cBItalic.Checked && cbUnderline.Checked)
                    {
                        fs = FontStyle.Bold | FontStyle.Underline;
                    }
                    else if (cBItalic.Checked && cbUnderline.Checked)
                    {
                        fs = FontStyle.Bold | FontStyle.Italic | FontStyle.Underline;
                    }
                }
                else if (!cbBold.Checked)
                {
                    if (!cBItalic.Checked && !cbUnderline.Checked)
                    {
                        fs = FontStyle.Regular;
                    }
                    else if (cBItalic.Checked && !cbUnderline.Checked)
                    {
                        fs = FontStyle.Italic;
                    }
                    else if (!cBItalic.Checked && cbUnderline.Checked)
                    {
                        fs = FontStyle.Underline;
                    }
                    else if (cBItalic.Checked && cbUnderline.Checked)
                    {
                        fs = FontStyle.Italic | FontStyle.Underline;
                    }
                }
                f = new Font(listFontFamily.SelectedItem.ToString(),
                       int.Parse(cBSize.SelectedItem.ToString()), fs);
                rTBContent.SelectionFont = f;
            }
        }

        private void cBItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (rTBContent.SelectedText != "")
            {
                if (cBItalic.Checked)
                {
                    if (!cbBold.Checked && !cbUnderline.Checked)
                    {
                        fs = FontStyle.Italic;
                    }
                    else if (cbBold.Checked && !cbUnderline.Checked)
                    {
                        fs = FontStyle.Bold | FontStyle.Italic;
                    }
                    else if (!cbBold.Checked && cbUnderline.Checked)
                    {
                        fs = FontStyle.Italic | FontStyle.Underline;
                    }
                    else if (cbBold.Checked && cbUnderline.Checked)
                    {
                        fs = FontStyle.Bold | FontStyle.Italic | FontStyle.Underline;
                    }
                }
                else if (!cBItalic.Checked)
                {
                    if (!cbBold.Checked && !cbUnderline.Checked)
                    {
                        fs = FontStyle.Regular;
                    }
                    else if (cbBold.Checked && !cbUnderline.Checked)
                    {
                        fs = FontStyle.Bold;
                    }
                    else if (!cbBold.Checked && cbUnderline.Checked)
                    {
                        fs = FontStyle.Underline;
                    }
                    else if (cbBold.Checked && cbUnderline.Checked)
                    {
                        fs = FontStyle.Bold | FontStyle.Underline;
                    }
                }
                f = new Font(listFontFamily.SelectedItem.ToString(),
                       int.Parse(cBSize.SelectedItem.ToString()), fs);
                rTBContent.SelectionFont = f;
            }
        }

        private void cbUnderline_CheckedChanged(object sender, EventArgs e)
        {
            if (rTBContent.SelectedText != "")
            {
                if (cbUnderline.Checked)
                {
                    if (!cBItalic.Checked && !cbBold.Checked)
                    {
                        fs = FontStyle.Underline;
                    }
                    else if (cBItalic.Checked && !cbBold.Checked)
                    {
                        fs = FontStyle.Underline | FontStyle.Italic;
                    }
                    else if (!cBItalic.Checked && cbBold.Checked)
                    {
                        fs = FontStyle.Bold | FontStyle.Underline;
                    }
                    else if (cBItalic.Checked && cbBold.Checked)
                    {
                        fs = FontStyle.Bold | FontStyle.Italic | FontStyle.Underline;
                    }
                }
                else if (!cbUnderline.Checked)
                {
                    if (!cBItalic.Checked && !cbBold.Checked)
                    {
                        fs = FontStyle.Regular;
                    }
                    else if (cBItalic.Checked && !cbBold.Checked)
                    {
                        fs = FontStyle.Italic;
                    }
                    else if (!cBItalic.Checked && cbBold.Checked)
                    {
                        fs = FontStyle.Bold;
                    }
                    else if (cBItalic.Checked && cbBold.Checked)
                    {
                        fs = FontStyle.Italic | FontStyle.Bold;
                    }
                }
                f = new Font(listFontFamily.SelectedItem.ToString(),
                       int.Parse(cBSize.SelectedItem.ToString()), fs);
                rTBContent.SelectionFont = f;
            }
        }
        private void hScrollRed_Scroll(object sender, ScrollEventArgs e)
        {
            if (hScrollRed.Value == 10)
            {
                lbColor.BackColor = Color.Red;
                rTBContent.SelectionColor = Color.Red;
            }
            else
            {
                lbColor.BackColor = Color.Black;
                rTBContent.SelectionColor = Color.Black;
            }
        }

        private void hScrollGreen_Scroll(object sender, ScrollEventArgs e)
        {
            if (hScrollGreen.Value == 10)
            {
                lbColor.BackColor = Color.Green;
                rTBContent.SelectionColor = Color.Green;
            }
            else
            {
                lbColor.BackColor = Color.Black;
                rTBContent.SelectionColor = Color.Black;
            }
        }

        private void hScrollBlue_Scroll(object sender, ScrollEventArgs e)
        {
            if (hScrollBlue.Value == 10)
            {
                lbColor.BackColor = Color.Blue;
                rTBContent.SelectionColor = Color.Blue;
            }
            else
            {
                lbColor.BackColor = Color.Black;
                rTBContent.SelectionColor = Color.Black;
            }
        }
    }
}
