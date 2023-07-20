namespace BTC4
{
    partial class Fmain
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
            menuStrip1 = new MenuStrip();
            mnFile = new ToolStripMenuItem();
            mnNew = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            mnCloseAll = new ToolStripMenuItem();
            mnExit = new ToolStripMenuItem();
            mnWindows = new ToolStripMenuItem();
            mnCascade = new ToolStripMenuItem();
            mnHorizontal = new ToolStripMenuItem();
            mnVertical = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnFile, mnWindows });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnFile
            // 
            mnFile.DropDownItems.AddRange(new ToolStripItem[] { mnNew, toolStripSeparator1, mnCloseAll, mnExit });
            mnFile.Name = "mnFile";
            mnFile.Size = new Size(37, 20);
            mnFile.Text = "File";
            // 
            // mnNew
            // 
            mnNew.MergeIndex = 0;
            mnNew.Name = "mnNew";
            mnNew.ShortcutKeys = Keys.Control | Keys.N;
            mnNew.Size = new Size(180, 22);
            mnNew.Text = "New";
            mnNew.Click += mnNew_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.MergeIndex = 5;
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // mnCloseAll
            // 
            mnCloseAll.MergeIndex = 6;
            mnCloseAll.Name = "mnCloseAll";
            mnCloseAll.Size = new Size(180, 22);
            mnCloseAll.Text = "Close All";
            mnCloseAll.Click += mnCloseAll_Click;
            // 
            // mnExit
            // 
            mnExit.MergeIndex = 7;
            mnExit.Name = "mnExit";
            mnExit.Size = new Size(180, 22);
            mnExit.Text = "Exit";
            mnExit.Click += mnExit_Click;
            // 
            // mnWindows
            // 
            mnWindows.DropDownItems.AddRange(new ToolStripItem[] { mnCascade, mnHorizontal, mnVertical });
            mnWindows.Name = "mnWindows";
            mnWindows.Size = new Size(68, 20);
            mnWindows.Text = "Windows";
            // 
            // mnCascade
            // 
            mnCascade.Name = "mnCascade";
            mnCascade.Size = new Size(154, 22);
            mnCascade.Text = "Cascade";
            // 
            // mnHorizontal
            // 
            mnHorizontal.Name = "mnHorizontal";
            mnHorizontal.Size = new Size(154, 22);
            mnHorizontal.Text = "Title Horizontal";
            // 
            // mnVertical
            // 
            mnVertical.Name = "mnVertical";
            mnVertical.Size = new Size(154, 22);
            mnVertical.Text = "Title Vertical";
            // 
            // Fmain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Fmain";
            Text = "FrChild";
            Load += FrChild_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnFile;
        private ToolStripMenuItem mnNew;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mnCloseAll;
        private ToolStripMenuItem mnExit;
        private ToolStripMenuItem mnWindows;
        private ToolStripMenuItem mnCascade;
        private ToolStripMenuItem mnHorizontal;
        private ToolStripMenuItem mnVertical;
    }
}