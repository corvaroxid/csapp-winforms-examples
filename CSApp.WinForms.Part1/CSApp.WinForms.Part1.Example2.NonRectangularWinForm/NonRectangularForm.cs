using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSApp.WinForms.Part1.Example2.NonRectangularWinForm
{
    public partial class NonRectangularForm : Form
    {
        public NonRectangularForm()
        {
            InitializeComponent();
        }

        private void CloseButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void NonRectangularFormLoad(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath = 
                new System.Drawing.Drawing2D.GraphicsPath();
            
            myPath.AddPolygon(new Point[] { new Point(0, 0), 
                new Point(0, this.Height), new Point(this.Width, 0) });
            
            Region myRegion = new Region(myPath);
            this.Region = myRegion;
        }
    }
}
