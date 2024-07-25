namespace CSApp.WinForms.Part1.Example4.MDIWinForm
{
    partial class ParentForm
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
            this.mdiMenu = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeWindowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileWindowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mdiMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mdiMenu
            // 
            this.mdiMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.windowMenuItem});
            this.mdiMenu.Location = new System.Drawing.Point(0, 0);
            this.mdiMenu.MdiWindowListItem = this.windowMenuItem;
            this.mdiMenu.Name = "mdiMenu";
            this.mdiMenu.Size = new System.Drawing.Size(404, 24);
            this.mdiMenu.TabIndex = 1;
            this.mdiMenu.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileMenuItem,
            this.exitFileMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileMenuItem.Text = "&File";
            // 
            // newFileMenuItem
            // 
            this.newFileMenuItem.Name = "newFileMenuItem";
            this.newFileMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newFileMenuItem.Text = "&New";
            this.newFileMenuItem.Click += new System.EventHandler(this.NewFileMenuItemClick);
            // 
            // exitFileMenuItem
            // 
            this.exitFileMenuItem.Name = "exitFileMenuItem";
            this.exitFileMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitFileMenuItem.Text = "&Exit";
            this.exitFileMenuItem.Click += new System.EventHandler(this.ExitFileMenuItemClick);
            // 
            // windowMenuItem
            // 
            this.windowMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeWindowMenuItem,
            this.tileWindowMenuItem});
            this.windowMenuItem.Name = "windowMenuItem";
            this.windowMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowMenuItem.Text = "&Window";
            // 
            // cascadeWindowMenuItem
            // 
            this.cascadeWindowMenuItem.Name = "cascadeWindowMenuItem";
            this.cascadeWindowMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cascadeWindowMenuItem.Text = "&Cascade";
            this.cascadeWindowMenuItem.Click += new System.EventHandler(this.CascadeWindowMenuItemClick);
            // 
            // tileWindowMenuItem
            // 
            this.tileWindowMenuItem.Name = "tileWindowMenuItem";
            this.tileWindowMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tileWindowMenuItem.Text = "&Tile";
            this.tileWindowMenuItem.Click += new System.EventHandler(this.TileWindowMenuItemClick);
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 281);
            this.Controls.Add(this.mdiMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mdiMenu;
            this.Name = "ParentForm";
            this.Text = "Parent Form";
            this.mdiMenu.ResumeLayout(false);
            this.mdiMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mdiMenu;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeWindowMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileWindowMenuItem;
    }
}

