namespace BTC4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtNhapChuoi = new TextBox();
            btnInsert = new Button();
            label3 = new Label();
            cbChooseColor = new ComboBox();
            listLeft = new ListBox();
            listRight = new ListBox();
            btnChuyenPhai = new Button();
            btnChuyenTrai = new Button();
            btnRemove = new Button();
            btnClearAll = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(27, 22);
            label1.Name = "label1";
            label1.Size = new Size(156, 25);
            label1.TabIndex = 0;
            label1.Text = "Nhap mot chuoi:";
            // 
            // txtNhapChuoi
            // 
            txtNhapChuoi.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNhapChuoi.Location = new Point(27, 50);
            txtNhapChuoi.Name = "txtNhapChuoi";
            txtNhapChuoi.Size = new Size(179, 27);
            txtNhapChuoi.TabIndex = 1;
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsert.ForeColor = SystemColors.Highlight;
            btnInsert.Location = new Point(27, 93);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(80, 31);
            btnInsert.TabIndex = 2;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(325, 22);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 0;
            label3.Text = "Chon mau:";
            // 
            // cbChooseColor
            // 
            cbChooseColor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbChooseColor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbChooseColor.FormattingEnabled = true;
            cbChooseColor.Items.AddRange(new object[] { "Red", "Blue", "Green", "Black", "Yellow", "Green", "Pink" });
            cbChooseColor.Location = new Point(325, 50);
            cbChooseColor.Name = "cbChooseColor";
            cbChooseColor.Size = new Size(136, 29);
            cbChooseColor.TabIndex = 3;
            cbChooseColor.SelectedIndexChanged += cbChooseColor_SelectedIndexChanged;
            // 
            // listLeft
            // 
            listLeft.FormattingEnabled = true;
            listLeft.ItemHeight = 15;
            listLeft.Location = new Point(27, 144);
            listLeft.Name = "listLeft";
            listLeft.SelectionMode = SelectionMode.MultiSimple;
            listLeft.Size = new Size(192, 259);
            listLeft.TabIndex = 4;
            // 
            // listRight
            // 
            listRight.FormattingEnabled = true;
            listRight.ItemHeight = 15;
            listRight.Location = new Point(325, 144);
            listRight.Name = "listRight";
            listRight.Size = new Size(192, 259);
            listRight.TabIndex = 4;
            // 
            // btnChuyenPhai
            // 
            btnChuyenPhai.Location = new Point(235, 177);
            btnChuyenPhai.Name = "btnChuyenPhai";
            btnChuyenPhai.Size = new Size(75, 23);
            btnChuyenPhai.TabIndex = 5;
            btnChuyenPhai.Text = "==>";
            btnChuyenPhai.UseVisualStyleBackColor = true;
            btnChuyenPhai.Click += btnChuyenPhai_Click;
            // 
            // btnChuyenTrai
            // 
            btnChuyenTrai.Location = new Point(235, 222);
            btnChuyenTrai.Name = "btnChuyenTrai";
            btnChuyenTrai.Size = new Size(75, 23);
            btnChuyenTrai.TabIndex = 5;
            btnChuyenTrai.Text = "<==";
            btnChuyenTrai.UseVisualStyleBackColor = true;
            btnChuyenTrai.Click += btnChuyenTrai_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(235, 267);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 5;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnClearAll
            // 
            btnClearAll.Location = new Point(235, 312);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(75, 23);
            btnClearAll.TabIndex = 5;
            btnClearAll.Text = "Clear All";
            btnClearAll.UseVisualStyleBackColor = true;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(235, 357);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 450);
            Controls.Add(btnExit);
            Controls.Add(btnClearAll);
            Controls.Add(btnRemove);
            Controls.Add(btnChuyenTrai);
            Controls.Add(btnChuyenPhai);
            Controls.Add(listRight);
            Controls.Add(listLeft);
            Controls.Add(cbChooseColor);
            Controls.Add(btnInsert);
            Controls.Add(txtNhapChuoi);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNhapChuoi;
        private Button btnInsert;
        private Label label3;
        private ComboBox cbChooseColor;
        private ListBox listLeft;
        private ListBox listRight;
        private Button btnChuyenPhai;
        private Button btnChuyenTrai;
        private Button btnRemove;
        private Button btnClearAll;
        private Button btnExit;
    }
}