namespace BTC4
{
    partial class Editor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            listFontFamily = new ListBox();
            label2 = new Label();
            cBSize = new ComboBox();
            cbBold = new CheckBox();
            cBItalic = new CheckBox();
            cbUnderline = new CheckBox();
            label3 = new Label();
            rTBContent = new RichTextBox();
            lbRed = new Label();
            lbGreen = new Label();
            lbBlue = new Label();
            hScrollRed = new HScrollBar();
            hScrollGreen = new HScrollBar();
            hScrollBlue = new HScrollBar();
            lbColor = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 9);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "Font List:";
            // 
            // listFontFamily
            // 
            listFontFamily.FormattingEnabled = true;
            listFontFamily.ItemHeight = 15;
            listFontFamily.Location = new Point(15, 37);
            listFontFamily.Name = "listFontFamily";
            listFontFamily.Size = new Size(205, 289);
            listFontFamily.TabIndex = 1;
            listFontFamily.SelectedIndexChanged += listFontFamily_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 349);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 0;
            label2.Text = "Size:";
            // 
            // cBSize
            // 
            cBSize.FormattingEnabled = true;
            cBSize.Items.AddRange(new object[] { "8", "9", "10", "11", "12", "14", "16", "18", "20", "22", "24", "30", "32", "48" });
            cBSize.Location = new Point(60, 341);
            cBSize.Name = "cBSize";
            cBSize.Size = new Size(61, 23);
            cBSize.TabIndex = 2;
            cBSize.SelectedIndexChanged += cBSize_SelectedIndexChanged;
            // 
            // cbBold
            // 
            cbBold.Appearance = Appearance.Button;
            cbBold.AutoSize = true;
            cbBold.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cbBold.Location = new Point(147, 339);
            cbBold.Name = "cbBold";
            cbBold.Size = new Size(24, 25);
            cbBold.TabIndex = 3;
            cbBold.Text = "B";
            cbBold.UseVisualStyleBackColor = true;
            cbBold.CheckedChanged += cbBold_CheckedChanged;
            // 
            // cBItalic
            // 
            cBItalic.Appearance = Appearance.Button;
            cBItalic.AutoSize = true;
            cBItalic.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            cBItalic.Location = new Point(177, 339);
            cBItalic.Name = "cBItalic";
            cBItalic.Size = new Size(20, 25);
            cBItalic.TabIndex = 3;
            cBItalic.Text = "I";
            cBItalic.UseVisualStyleBackColor = true;
            cBItalic.CheckedChanged += cBItalic_CheckedChanged;
            // 
            // cbUnderline
            // 
            cbUnderline.Appearance = Appearance.Button;
            cbUnderline.AutoSize = true;
            cbUnderline.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            cbUnderline.Location = new Point(203, 339);
            cbUnderline.Name = "cbUnderline";
            cbUnderline.Size = new Size(25, 25);
            cbUnderline.TabIndex = 3;
            cbUnderline.Text = "U";
            cbUnderline.UseVisualStyleBackColor = true;
            cbUnderline.CheckedChanged += cbUnderline_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(245, 9);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 4;
            label3.Text = "Content:";
            // 
            // rTBContent
            // 
            rTBContent.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rTBContent.Location = new Point(245, 37);
            rTBContent.Name = "rTBContent";
            rTBContent.Size = new Size(331, 288);
            rTBContent.TabIndex = 5;
            rTBContent.Text = "Mưa giải nhiệt cho thủ đô sau đợt nóng gay gắt.\nSáng nay, nhiều khu vực Hà Nội có mưa to, xua tan cảm giác oi bức duy trì suốt 5 ngày qua.";
            rTBContent.SelectionChanged += rTBContent_SelectionChanged;
            // 
            // lbRed
            // 
            lbRed.BackColor = Color.Red;
            lbRed.Location = new Point(245, 340);
            lbRed.Name = "lbRed";
            lbRed.Size = new Size(17, 11);
            lbRed.TabIndex = 6;
            // 
            // lbGreen
            // 
            lbGreen.BackColor = Color.Green;
            lbGreen.Location = new Point(245, 361);
            lbGreen.Name = "lbGreen";
            lbGreen.Size = new Size(17, 11);
            lbGreen.TabIndex = 6;
            // 
            // lbBlue
            // 
            lbBlue.BackColor = Color.Blue;
            lbBlue.Location = new Point(245, 382);
            lbBlue.Name = "lbBlue";
            lbBlue.Size = new Size(17, 11);
            lbBlue.TabIndex = 6;
            // 
            // hScrollRed
            // 
            hScrollRed.LargeChange = 1;
            hScrollRed.Location = new Point(284, 336);
            hScrollRed.Maximum = 10;
            hScrollRed.Name = "hScrollRed";
            hScrollRed.Size = new Size(227, 15);
            hScrollRed.TabIndex = 7;
            hScrollRed.Scroll += hScrollRed_Scroll;
            // 
            // hScrollGreen
            // 
            hScrollGreen.LargeChange = 1;
            hScrollGreen.Location = new Point(284, 361);
            hScrollGreen.Maximum = 10;
            hScrollGreen.Name = "hScrollGreen";
            hScrollGreen.Size = new Size(227, 15);
            hScrollGreen.TabIndex = 7;
            hScrollGreen.Scroll += hScrollGreen_Scroll;
            // 
            // hScrollBlue
            // 
            hScrollBlue.LargeChange = 1;
            hScrollBlue.Location = new Point(284, 383);
            hScrollBlue.Maximum = 10;
            hScrollBlue.Name = "hScrollBlue";
            hScrollBlue.Size = new Size(227, 15);
            hScrollBlue.TabIndex = 7;
            hScrollBlue.Scroll += hScrollBlue_Scroll;
            // 
            // lbColor
            // 
            lbColor.BackColor = SystemColors.ActiveCaptionText;
            lbColor.Location = new Point(529, 340);
            lbColor.Name = "lbColor";
            lbColor.Size = new Size(47, 48);
            lbColor.TabIndex = 8;
            // 
            // Editor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 401);
            Controls.Add(lbColor);
            Controls.Add(hScrollBlue);
            Controls.Add(hScrollGreen);
            Controls.Add(hScrollRed);
            Controls.Add(lbBlue);
            Controls.Add(lbGreen);
            Controls.Add(lbRed);
            Controls.Add(rTBContent);
            Controls.Add(label3);
            Controls.Add(cbUnderline);
            Controls.Add(cBItalic);
            Controls.Add(cbBold);
            Controls.Add(cBSize);
            Controls.Add(listFontFamily);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Editor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editor";
            TopMost = true;
            Load += Editor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listFontFamily;
        private Label label2;
        private ComboBox cBSize;
        private CheckBox cbBold;
        private CheckBox cBItalic;
        private CheckBox cbUnderline;
        private Label label3;
        private RichTextBox rTBContent;
        private Label lbRed;
        private Label lbGreen;
        private Label lbBlue;
        private HScrollBar hScrollRed;
        private HScrollBar hScrollGreen;
        private HScrollBar hScrollBlue;
        private Label lbColor;
    }
}