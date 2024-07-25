namespace CSApp.WinForms.Part1.Example1.BaseWinForm
{
    partial class MainForm
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
            this.showChildFormButton = new System.Windows.Forms.Button();
            this.borderStyleButton = new System.Windows.Forms.Button();
            this.resizeButton = new System.Windows.Forms.Button();
            this.opacityButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showChildFormButton
            // 
            this.showChildFormButton.Location = new System.Drawing.Point(85, 29);
            this.showChildFormButton.Name = "showChildFormButton";
            this.showChildFormButton.Size = new System.Drawing.Size(97, 43);
            this.showChildFormButton.TabIndex = 0;
            this.showChildFormButton.Text = "Show";
            this.showChildFormButton.UseVisualStyleBackColor = true;
            this.showChildFormButton.Click += new System.EventHandler(this.ShowChildFormButtonClick);
            // 
            // borderStyleButton
            // 
            this.borderStyleButton.Location = new System.Drawing.Point(85, 78);
            this.borderStyleButton.Name = "borderStyleButton";
            this.borderStyleButton.Size = new System.Drawing.Size(97, 43);
            this.borderStyleButton.TabIndex = 1;
            this.borderStyleButton.Text = "Border Style";
            this.borderStyleButton.UseVisualStyleBackColor = true;
            this.borderStyleButton.Click += new System.EventHandler(this.BorderStyleButtonClick);
            // 
            // resizeButton
            // 
            this.resizeButton.Location = new System.Drawing.Point(85, 127);
            this.resizeButton.Name = "resizeButton";
            this.resizeButton.Size = new System.Drawing.Size(97, 43);
            this.resizeButton.TabIndex = 2;
            this.resizeButton.Text = "Resize";
            this.resizeButton.UseVisualStyleBackColor = true;
            this.resizeButton.Click += new System.EventHandler(this.ResizeButtonClick);
            // 
            // opacityButton
            // 
            this.opacityButton.Location = new System.Drawing.Point(85, 176);
            this.opacityButton.Name = "opacityButton";
            this.opacityButton.Size = new System.Drawing.Size(97, 43);
            this.opacityButton.TabIndex = 3;
            this.opacityButton.Text = "Opacity";
            this.opacityButton.UseVisualStyleBackColor = true;
            this.opacityButton.Click += new System.EventHandler(this.OpacityButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 268);
            this.Controls.Add(this.opacityButton);
            this.Controls.Add(this.resizeButton);
            this.Controls.Add(this.borderStyleButton);
            this.Controls.Add(this.showChildFormButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Location = new System.Drawing.Point(100, 200);
            this.Name = "MainForm";
            this.Opacity = 0.75D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Trey Research";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showChildFormButton;
        private System.Windows.Forms.Button borderStyleButton;
        private System.Windows.Forms.Button resizeButton;
        private System.Windows.Forms.Button opacityButton;
    }
}

