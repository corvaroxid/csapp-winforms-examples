using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSApp.WinForms.Part2.Example3.WinContainer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void defaultButton_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                this.defaultButton.Text = "First";
            }
            else if (radioButton2.Checked == true)
            {
                this.defaultButton.Text = "Second";
            }
        }

        private void Button5Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.SetFlowBreak(button6, true);
        }

        private void Button9Click(object sender, EventArgs e)
        {
            Button aButton = new Button();
            aButton.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(aButton, 0, 1);
        }

        private void Button10Click(object sender, EventArgs e)
        {
            if (splitContainer1.FixedPanel == FixedPanel.Panel1)
            {
                splitContainer1.FixedPanel = FixedPanel.None;

            }
            else
            {
                splitContainer1.FixedPanel = FixedPanel.Panel1;
            }
                
        }

        private void Button11Click(object sender, EventArgs e)
        {
            splitContainer1.IsSplitterFixed = !(splitContainer1.IsSplitterFixed);
        }

        private void Button12Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = !(splitContainer1.Panel1Collapsed);
        }
    }
}
