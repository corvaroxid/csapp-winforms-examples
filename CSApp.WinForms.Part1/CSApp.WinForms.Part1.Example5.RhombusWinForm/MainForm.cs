using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSApp.WinForms.Part1.Example5.RhombusWinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenButtonClick(object sender, EventArgs e)
        {
            RhombusForm rhombusForm = new RhombusForm();
            rhombusForm.Show();
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
