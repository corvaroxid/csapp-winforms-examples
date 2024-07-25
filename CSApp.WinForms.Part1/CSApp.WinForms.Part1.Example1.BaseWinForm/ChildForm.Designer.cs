namespace CSApp.WinForms.Part1.Example1.BaseWinForm
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
            this.destroyOnCloseCheckBox = new System.Windows.Forms.CheckBox();
            this.closeFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // destroyOnCloseCheckBox
            // 
            this.destroyOnCloseCheckBox.AutoSize = true;
            this.destroyOnCloseCheckBox.Location = new System.Drawing.Point(46, 37);
            this.destroyOnCloseCheckBox.Name = "destroyOnCloseCheckBox";
            this.destroyOnCloseCheckBox.Size = new System.Drawing.Size(105, 17);
            this.destroyOnCloseCheckBox.TabIndex = 0;
            this.destroyOnCloseCheckBox.Text = "Destroy on close";
            this.destroyOnCloseCheckBox.UseVisualStyleBackColor = true;
            // 
            // closeFormButton
            // 
            this.closeFormButton.Location = new System.Drawing.Point(46, 72);
            this.closeFormButton.Name = "closeFormButton";
            this.closeFormButton.Size = new System.Drawing.Size(93, 30);
            this.closeFormButton.TabIndex = 1;
            this.closeFormButton.Text = "Close";
            this.closeFormButton.UseVisualStyleBackColor = true;
            this.closeFormButton.Click += new System.EventHandler(this.CloseFormButtonClick);
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 204);
            this.Controls.Add(this.closeFormButton);
            this.Controls.Add(this.destroyOnCloseCheckBox);
            this.Name = "ChildForm";
            this.Text = "ChildForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChildFormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox destroyOnCloseCheckBox;
        private System.Windows.Forms.Button closeFormButton;
    }
}