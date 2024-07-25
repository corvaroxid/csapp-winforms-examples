using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSApp.WinForms.Part1.Example1.BaseWinForm
{
    public partial class MainForm : Form
    {
        private ChildForm childForm;

        public MainForm()
        {
            InitializeComponent();
            childForm = new ChildForm();
        }

        private void ShowChildFormButtonClick(object sender, EventArgs e)
        {
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(this.Location.X + this.Width, this.Location.Y);

            try
            {
                childForm.Show();
                childForm.Text = "ChildForm";
                childForm.Activate();
            }
            catch (ObjectDisposedException ex)
            {
                childForm = new ChildForm();
                childForm.Text = "Duplicate creation";
                childForm.Show();
                childForm.Activate();
            }
        }

        private void BorderStyleButtonClick(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void ResizeButtonClick(object sender, EventArgs e)
        {
            this.Size = new Size(300, 500);
        }

        private void OpacityButtonClick(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }
    }
}
