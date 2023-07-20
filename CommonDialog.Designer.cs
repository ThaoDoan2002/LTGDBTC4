namespace BTC4
{
    partial class CommonDialog
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
            components = new System.ComponentModel.Container();
            btnChonMotTT = new Button();
            btnChonNhieuTT = new Button();
            btnChonThuMuc = new Button();
            btnChonMauNen = new Button();
            btnChonMauChu = new Button();
            btnChonFont = new Button();
            txtNoiDung = new TextBox();
            btnReset = new Button();
            btnThoat = new Button();
            timerStart = new System.Windows.Forms.Timer(components);
            timerClose = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnChonMotTT
            // 
            btnChonMotTT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnChonMotTT.Location = new Point(42, 33);
            btnChonMotTT.Name = "btnChonMotTT";
            btnChonMotTT.Size = new Size(147, 37);
            btnChonMotTT.TabIndex = 0;
            btnChonMotTT.Text = "Chọn một tập tin";
            btnChonMotTT.UseVisualStyleBackColor = true;
            btnChonMotTT.Click += btnChonMotTT_Click;
            // 
            // btnChonNhieuTT
            // 
            btnChonNhieuTT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnChonNhieuTT.Location = new Point(42, 99);
            btnChonNhieuTT.Name = "btnChonNhieuTT";
            btnChonNhieuTT.Size = new Size(147, 37);
            btnChonNhieuTT.TabIndex = 0;
            btnChonNhieuTT.Text = "Chọn nhiều tập tin";
            btnChonNhieuTT.UseVisualStyleBackColor = true;
            btnChonNhieuTT.Click += btnChonNhieuTT_Click;
            // 
            // btnChonThuMuc
            // 
            btnChonThuMuc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnChonThuMuc.Location = new Point(42, 164);
            btnChonThuMuc.Name = "btnChonThuMuc";
            btnChonThuMuc.Size = new Size(147, 37);
            btnChonThuMuc.TabIndex = 0;
            btnChonThuMuc.Text = "Chọn thư mục";
            btnChonThuMuc.UseVisualStyleBackColor = true;
            btnChonThuMuc.Click += btnChonThuMuc_Click;
            // 
            // btnChonMauNen
            // 
            btnChonMauNen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnChonMauNen.Location = new Point(42, 225);
            btnChonMauNen.Name = "btnChonMauNen";
            btnChonMauNen.Size = new Size(147, 37);
            btnChonMauNen.TabIndex = 0;
            btnChonMauNen.Text = "Chọn màu nền";
            btnChonMauNen.UseVisualStyleBackColor = true;
            btnChonMauNen.Click += btnChonMauNen_Click;
            // 
            // btnChonMauChu
            // 
            btnChonMauChu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnChonMauChu.Location = new Point(42, 289);
            btnChonMauChu.Name = "btnChonMauChu";
            btnChonMauChu.Size = new Size(147, 37);
            btnChonMauChu.TabIndex = 0;
            btnChonMauChu.Text = "Chọn màu chữ";
            btnChonMauChu.UseVisualStyleBackColor = true;
            btnChonMauChu.Click += btnChonMauChu_Click;
            // 
            // btnChonFont
            // 
            btnChonFont.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnChonFont.Location = new Point(42, 350);
            btnChonFont.Name = "btnChonFont";
            btnChonFont.Size = new Size(147, 37);
            btnChonFont.TabIndex = 0;
            btnChonFont.Text = "Chọn font";
            btnChonFont.UseVisualStyleBackColor = true;
            btnChonFont.Click += btnChonFont_Click;
            // 
            // txtNoiDung
            // 
            txtNoiDung.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtNoiDung.ForeColor = SystemColors.HotTrack;
            txtNoiDung.Location = new Point(222, 33);
            txtNoiDung.Multiline = true;
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(451, 311);
            txtNoiDung.TabIndex = 1;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.Location = new Point(222, 350);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(213, 37);
            btnReset.TabIndex = 0;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThoat.Location = new Point(460, 350);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(213, 37);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // timerStart
            // 
            timerStart.Tick += timerStart_Tick;
            // 
            // timerClose
            // 
            timerClose.Tick += timerClose_Tick;
            // 
            // CommonDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 408);
            Controls.Add(txtNoiDung);
            Controls.Add(btnThoat);
            Controls.Add(btnReset);
            Controls.Add(btnChonFont);
            Controls.Add(btnChonMauChu);
            Controls.Add(btnChonMauNen);
            Controls.Add(btnChonThuMuc);
            Controls.Add(btnChonNhieuTT);
            Controls.Add(btnChonMotTT);
            Name = "CommonDialog";
            Opacity = 0D;
            Text = "CommonDialog";
            FormClosing += CommonDialog_FormClosing;
            Load += CommonDialog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnChonMotTT;
        private Button btnChonNhieuTT;
        private Button btnChonThuMuc;
        private Button btnChonMauNen;
        private Button btnChonMauChu;
        private Button btnChonFont;
        private TextBox txtNoiDung;
        private Button btnReset;
        private Button btnThoat;
        private System.Windows.Forms.Timer timerStart;
        private System.Windows.Forms.Timer timerClose;
    }
}