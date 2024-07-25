namespace CSApp.WinForms.Part1.Example4.MDIWinForm
{
    partial class ChildForm
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
            this.childTextBox = new System.Windows.Forms.RichTextBox();
            this.childWindowMenu = new System.Windows.Forms.MenuStrip();
            this.formatMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleForegroundFormatMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.childWindowMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // childTextBox
            // 
            this.childTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childTextBox.Location = new System.Drawing.Point(0, 24);
            this.childTextBox.Name = "childTextBox";
            this.childTextBox.Size = new System.Drawing.Size(800, 426);
            this.childTextBox.TabIndex = 0;
            this.childTextBox.Text = "";
            // 
            // childWindowMenu
            // 
            this.childWindowMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formatMenuItem});
            this.childWindowMenu.Location = new System.Drawing.Point(0, 0);
            this.childWindowMenu.Name = "childWindowMenu";
            this.childWindowMenu.Size = new System.Drawing.Size(800, 24);
            this.childWindowMenu.TabIndex = 1;
            this.childWindowMenu.Text = "menuStrip1";
            // 
            // formatMenuItem
            // 
            this.formatMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toggleForegroundFormatMenuItem});
            this.formatMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.formatMenuItem.MergeIndex = 1;
            this.formatMenuItem.Name = "formatMenuItem";
            this.formatMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatMenuItem.Text = "&Format";
            // 
            // toggleForegroundFormatMenuItem
            // 
            this.toggleForegroundFormatMenuItem.Name = "toggleForegroundFormatMenuItem";
            this.toggleForegroundFormatMenuItem.Size = new System.Drawing.Size(180, 22);
            this.toggleForegroundFormatMenuItem.Text = "&Toggle Foreground";
            this.toggleForegroundFormatMenuItem.Click += new System.EventHandler(this.ToggleForegroundFormatMenuItemClick);
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.childTextBox);
            this.Controls.Add(this.childWindowMenu);
            this.MainMenuStrip = this.childWindowMenu;
            this.Name = "ChildForm";
            this.Text = "Child Form";
            this.childWindowMenu.ResumeLayout(false);
            this.childWindowMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox childTextBox;
        private System.Windows.Forms.MenuStrip childWindowMenu;
        private System.Windows.Forms.ToolStripMenuItem formatMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toggleForegroundFormatMenuItem;
    }
}