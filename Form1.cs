namespace BTC4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtNhapChuoi.Text != "")
            {
                listLeft.Items.Add(txtNhapChuoi.Text);
                txtNhapChuoi.Text = "";
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnChuyenPhai_Click(object sender, EventArgs e)
        {
            if (listLeft.SelectedIndex != -1)
            {
                while (listLeft.SelectedItems.Count > 0)
                {
                    listRight.Items.Add(listLeft.SelectedItems[0]);
                    listLeft.Items.Remove(listLeft.SelectedItems[0]);
                }
            }
        }

        private void btnChuyenTrai_Click(object sender, EventArgs e)
        {
            if (listRight.SelectedIndex != -1)
            {
                listLeft.Items.Add(listRight.SelectedItem);
                listRight.Items.Remove(listRight.SelectedItem);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listLeft.SelectedIndex != -1 && listRight.SelectedIndex != -1)
            {
                while (listLeft.SelectedItems.Count > 0)
                {
                    listLeft.Items.Remove(listLeft.SelectedItems[0]);
                }
                while (listRight.SelectedItems.Count > 0)
                {
                    listRight.Items.Remove(listRight.SelectedItems[0]);
                }
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            listLeft.Items.Clear();
            listRight.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbChooseColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbChooseColor.SelectedItem)
            {
                case "Red": listRight.BackColor = Color.Red; break;
                case "Blue": listRight.BackColor = Color.Blue; break;
            }
        }
    }
}