using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSApp.WinForms.Part2.Example1.WinQuestion
{
    public partial class QuestionForm : Form
    {
        public QuestionForm()
        {
            InitializeComponent();
        }

        private void YesButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("Exactly!");
        }

        private void NoButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure!");
        }

        private void NoButtonMouseMove(object sender, MouseEventArgs e)
        {
            noButton.Top -= e.Y;
            noButton.Left += e.X;
           
            if (noButton.Top < -10 || noButton.Top > 100)
            {
                noButton.Top = 60;
            }

            if (noButton.Left < -80 || noButton.Left > 250)
            {
                noButton.Left = 120;
            }
        }
    }
}
