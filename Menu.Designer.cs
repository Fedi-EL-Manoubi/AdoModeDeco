namespace AdoTpFedi
{
    partial class Menu
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
            quitterToolStripMenuItem = new ToolStripMenuItem();
            basesToolStripMenuItem = new ToolStripMenuItem();
            auteursToolStripMenuItem = new ToolStripMenuItem();
            genresToolStripMenuItem = new ToolStripMenuItem();
            adhérentsToolStripMenuItem = new ToolStripMenuItem();
            livresToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { quitterToolStripMenuItem, basesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(377, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(56, 20);
            quitterToolStripMenuItem.Text = "Quitter";
            quitterToolStripMenuItem.Click += quitterToolStripMenuItem_Click;
            // 
            // basesToolStripMenuItem
            // 
            basesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { auteursToolStripMenuItem, genresToolStripMenuItem, adhérentsToolStripMenuItem, livresToolStripMenuItem });
            basesToolStripMenuItem.Name = "basesToolStripMenuItem";
            basesToolStripMenuItem.Size = new Size(48, 20);
            basesToolStripMenuItem.Text = "Bases";
            // 
            // auteursToolStripMenuItem
            // 
            auteursToolStripMenuItem.Name = "auteursToolStripMenuItem";
            auteursToolStripMenuItem.Size = new Size(180, 22);
            auteursToolStripMenuItem.Text = "Auteurs";
            auteursToolStripMenuItem.Click += auteursToolStripMenuItem_Click;
            // 
            // genresToolStripMenuItem
            // 
            genresToolStripMenuItem.Name = "genresToolStripMenuItem";
            genresToolStripMenuItem.Size = new Size(180, 22);
            genresToolStripMenuItem.Text = "Genres";
            // 
            // adhérentsToolStripMenuItem
            // 
            adhérentsToolStripMenuItem.Name = "adhérentsToolStripMenuItem";
            adhérentsToolStripMenuItem.Size = new Size(180, 22);
            adhérentsToolStripMenuItem.Text = "Adhérents";
            // 
            // livresToolStripMenuItem
            // 
            livresToolStripMenuItem.Name = "livresToolStripMenuItem";
            livresToolStripMenuItem.Size = new Size(180, 22);
            livresToolStripMenuItem.Text = "Livres";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 324);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Menu";
            Text = "Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem basesToolStripMenuItem;
        private ToolStripMenuItem auteursToolStripMenuItem;
        private ToolStripMenuItem genresToolStripMenuItem;
        private ToolStripMenuItem adhérentsToolStripMenuItem;
        private ToolStripMenuItem livresToolStripMenuItem;
    }
}