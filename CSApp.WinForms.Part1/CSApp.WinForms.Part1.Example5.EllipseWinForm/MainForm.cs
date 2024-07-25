using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSApp.WinForms.Part1.Example5.EllipseWinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath =
                new System.Drawing.Drawing2D.GraphicsPath();

            myPath.AddEllipse(0, 0, this.Width, this.Height);

            Region myRegion = new Region(myPath);
            this.Region = myRegion;
        }

        private void CloseButtonClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
