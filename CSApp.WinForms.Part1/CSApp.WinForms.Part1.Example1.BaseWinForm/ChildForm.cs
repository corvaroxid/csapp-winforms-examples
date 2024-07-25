using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace CSApp.WinForms.Part1.Example1.BaseWinForm
{
    public partial class ChildForm : Form
    {
        private bool destroyOnClose = false;
        
        public ChildForm()
        {
            InitializeComponent();
        }

        private void CloseFormButtonClick(object sender, EventArgs e)
        {
            Close();
        }


        public new void Close()
        {
            destroyOnClose = true;
            base.Close();
        }

        private void ChildFormClosing(object sender, FormClosingEventArgs e)
        {
            if (destroyOnClose || destroyOnCloseCheckBox.Checked)
            {
                return;
            }

            Hide();
        }
    }
}
