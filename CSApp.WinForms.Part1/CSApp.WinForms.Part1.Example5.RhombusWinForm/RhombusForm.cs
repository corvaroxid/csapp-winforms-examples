using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSApp.WinForms.Part1.Example5.RhombusWinForm
{
    public partial class RhombusForm : Form
    {
        public RhombusForm()
        {
            InitializeComponent();
        }

        private void RhombusForm_Load(object sender, EventArgs e)
        {
            using (GraphicsPath myPath = new GraphicsPath())
            {
                myPath.AddLines(new[]
                    {
                new Point(0, Height / 2),
                new Point(Width / 2, 0),
                new Point(Width, Height / 2),
                new Point(Width / 2, Height)
            });
                Region = new Region(myPath);
            }
        }

        private void CloseButtonClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
