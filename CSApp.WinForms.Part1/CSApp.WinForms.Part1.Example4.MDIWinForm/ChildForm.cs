using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSApp.WinForms.Part1.Example4.MDIWinForm
{
    public partial class ChildForm : Form
    {
        public ChildForm()
        {
            InitializeComponent();
        }

        private void ToggleForegroundFormatMenuItemClick(object sender, EventArgs e)
        {
            if (toggleForegroundFormatMenuItem.Checked)
            {
                toggleForegroundFormatMenuItem.Checked = false;
                childTextBox.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                toggleForegroundFormatMenuItem.Checked = true;
                childTextBox.ForeColor = System.Drawing.Color.Blue;
            }
        }
    }
}
