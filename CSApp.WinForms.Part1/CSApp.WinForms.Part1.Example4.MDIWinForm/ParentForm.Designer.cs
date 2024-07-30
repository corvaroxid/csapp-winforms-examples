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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParentForm));
            this.mdiMenu = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeWindowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileWindowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsPanel = new System.Windows.Forms.ToolStrip();
            this.createDocumentButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cascadeWindowsButton = new System.Windows.Forms.ToolStripButton();
            this.titleWindowsButton = new System.Windows.Forms.ToolStripButton();
            this.spData = new System.Windows.Forms.StatusStrip();
            this.spWin = new System.Windows.Forms.StatusStrip();
            this.spDateText = new System.Windows.Forms.ToolStripStatusLabel();
            this.spStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.mdiMenu.SuspendLayout();
            this.toolsPanel.SuspendLayout();
            this.spData.SuspendLayout();
            this.spWin.SuspendLayout();
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
            this.mdiMenu.Size = new System.Drawing.Size(434, 24);
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
            this.newFileMenuItem.Size = new System.Drawing.Size(98, 22);
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
            this.cascadeWindowMenuItem.Size = new System.Drawing.Size(118, 22);
            this.cascadeWindowMenuItem.Text = "&Cascade";
            this.cascadeWindowMenuItem.Click += new System.EventHandler(this.CascadeWindowMenuItemClick);
            // 
            // tileWindowMenuItem
            // 
            this.tileWindowMenuItem.Name = "tileWindowMenuItem";
            this.tileWindowMenuItem.Size = new System.Drawing.Size(118, 22);
            this.tileWindowMenuItem.Text = "&Tile";
            this.tileWindowMenuItem.Click += new System.EventHandler(this.TileWindowMenuItemClick);
            // 
            // toolsPanel
            // 
            this.toolsPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createDocumentButton,
            this.toolStripSeparator1,
            this.cascadeWindowsButton,
            this.titleWindowsButton});
            this.toolsPanel.Location = new System.Drawing.Point(0, 24);
            this.toolsPanel.Name = "toolsPanel";
            this.toolsPanel.Size = new System.Drawing.Size(434, 25);
            this.toolsPanel.TabIndex = 3;
            this.toolsPanel.Text = "toolStrip1";
            this.toolsPanel.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolsPanelItemClicked);
            // 
            // createDocumentButton
            // 
            this.createDocumentButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.createDocumentButton.Image = ((System.Drawing.Image)(resources.GetObject("createDocumentButton.Image")));
            this.createDocumentButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.createDocumentButton.Name = "createDocumentButton";
            this.createDocumentButton.Size = new System.Drawing.Size(23, 22);
            this.createDocumentButton.Tag = "NewDoc";
            this.createDocumentButton.Text = "createDocumentButton";
            this.createDocumentButton.ToolTipText = "Create new document";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // cascadeWindowsButton
            // 
            this.cascadeWindowsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cascadeWindowsButton.Image = ((System.Drawing.Image)(resources.GetObject("cascadeWindowsButton.Image")));
            this.cascadeWindowsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cascadeWindowsButton.Name = "cascadeWindowsButton";
            this.cascadeWindowsButton.Size = new System.Drawing.Size(23, 22);
            this.cascadeWindowsButton.Tag = "Cascade";
            this.cascadeWindowsButton.Text = "cascadeWindowsButton";
            this.cascadeWindowsButton.ToolTipText = "Windows cascade";
            // 
            // titleWindowsButton
            // 
            this.titleWindowsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.titleWindowsButton.Image = ((System.Drawing.Image)(resources.GetObject("titleWindowsButton.Image")));
            this.titleWindowsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.titleWindowsButton.Name = "titleWindowsButton";
            this.titleWindowsButton.Size = new System.Drawing.Size(23, 22);
            this.titleWindowsButton.Tag = "Title";
            this.titleWindowsButton.Text = "titleWindowsButton";
            this.titleWindowsButton.ToolTipText = "Windows title";
            // 
            // spData
            // 
            this.spData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spStatusText});
            this.spData.Location = new System.Drawing.Point(0, 289);
            this.spData.Name = "spData";
            this.spData.Size = new System.Drawing.Size(434, 22);
            this.spData.TabIndex = 5;
            this.spData.Text = "Data";
            // 
            // spWin
            // 
            this.spWin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spDateText});
            this.spWin.Location = new System.Drawing.Point(0, 267);
            this.spWin.Name = "spWin";
            this.spWin.Size = new System.Drawing.Size(434, 22);
            this.spWin.TabIndex = 6;
            this.spWin.Text = "Status";
            // 
            // spDateText
            // 
            this.spDateText.Name = "spDateText";
            this.spDateText.Size = new System.Drawing.Size(31, 17);
            this.spDateText.Text = "Data";
            // 
            // spStatusText
            // 
            this.spStatusText.Name = "spStatusText";
            this.spStatusText.Size = new System.Drawing.Size(39, 17);
            this.spStatusText.Text = "Status";
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.spWin);
            this.Controls.Add(this.spData);
            this.Controls.Add(this.toolsPanel);
            this.Controls.Add(this.mdiMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mdiMenu;
            this.Name = "ParentForm";
            this.Text = "Parent Form";
            this.mdiMenu.ResumeLayout(false);
            this.mdiMenu.PerformLayout();
            this.toolsPanel.ResumeLayout(false);
            this.toolsPanel.PerformLayout();
            this.spData.ResumeLayout(false);
            this.spData.PerformLayout();
            this.spWin.ResumeLayout(false);
            this.spWin.PerformLayout();
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
        private System.Windows.Forms.ToolStrip toolsPanel;
        private System.Windows.Forms.ToolStripButton createDocumentButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton cascadeWindowsButton;
        private System.Windows.Forms.ToolStripButton titleWindowsButton;
        private System.Windows.Forms.StatusStrip spData;
        private System.Windows.Forms.StatusStrip spWin;
        private System.Windows.Forms.ToolStripStatusLabel spStatusText;
        private System.Windows.Forms.ToolStripStatusLabel spDateText;
    }
}

