namespace BTC4
{
    partial class Fchild
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
            pic = new PictureBox();
            menuStrip1 = new MenuStrip();
            mnFile = new ToolStripMenuItem();
            mnLoad = new ToolStripMenuItem();
            mnOpen = new ToolStripMenuItem();
            mnClear = new ToolStripMenuItem();
            mnSave = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pic
            // 
            pic.Dock = DockStyle.Fill;
            pic.Location = new Point(0, 24);
            pic.Name = "pic";
            pic.Size = new Size(800, 426);
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.TabIndex = 0;
            pic.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnFile });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnFile
            // 
            mnFile.DropDownItems.AddRange(new ToolStripItem[] { mnLoad, mnOpen, mnClear, mnSave });
            mnFile.MergeAction = MergeAction.MatchOnly;
            mnFile.Name = "mnFile";
            mnFile.Size = new Size(37, 20);
            mnFile.Text = "File";
            // 
            // mnLoad
            // 
            mnLoad.MergeAction = MergeAction.Insert;
            mnLoad.MergeIndex = 1;
            mnLoad.Name = "mnLoad";
            mnLoad.Size = new Size(180, 22);
            mnLoad.Text = "Load";
            mnLoad.Click += mnLoad_Click;
            // 
            // mnOpen
            // 
            mnOpen.MergeAction = MergeAction.Insert;
            mnOpen.MergeIndex = 2;
            mnOpen.Name = "mnOpen";
            mnOpen.Size = new Size(180, 22);
            mnOpen.Text = "Open";
            mnOpen.Click += mnOpen_Click;
            // 
            // mnClear
            // 
            mnClear.MergeAction = MergeAction.Insert;
            mnClear.MergeIndex = 3;
            mnClear.Name = "mnClear";
            mnClear.Size = new Size(180, 22);
            mnClear.Text = "Clear";
            mnClear.Click += mnClear_Click;
            // 
            // mnSave
            // 
            mnSave.MergeAction = MergeAction.Insert;
            mnSave.MergeIndex = 4;
            mnSave.Name = "mnSave";
            mnSave.Size = new Size(180, 22);
            mnSave.Text = "Save";
            mnSave.Click += mnSave_Click;
            // 
            // Fchild
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pic);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Fchild";
            Text = "FrMain";
            Load += Fchild_Load;
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pic;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnFile;
        private ToolStripMenuItem mnLoad;
        private ToolStripMenuItem mnOpen;
        private ToolStripMenuItem mnClear;
        private ToolStripMenuItem mnSave;
    }
}