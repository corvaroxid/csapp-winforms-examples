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
    public partial class ParentForm : Form
    {
        private int openDocuments = 0;

        public ParentForm()
        {
            InitializeComponent();
            spDateText.Text = Convert.ToString(System.DateTime.Today.ToLongDateString());
        }

        private void ExitFileMenuItemClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CascadeWindowMenuItemClick(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void TileWindowMenuItemClick(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void NewFileMenuItemClick(object sender, EventArgs e)
        {
            ChildForm newChild = new ChildForm();
            newChild.Text = newChild.Text + " " + ++openDocuments;
            newChild.MdiParent = this;
            newChild.Show();
        }

        private void ToolsPanelItemClicked(object sender, ToolStripItemClickedEventArgs eventArgs)
        {
            switch (eventArgs.ClickedItem.Tag.ToString())
            {
                case "NewDoc":
                    ChildForm newChild = new ChildForm();
                    newChild.MdiParent = this;
                    newChild.Show();
                    newChild.Text = newChild.Text + " " + ++openDocuments;
                    break;
                case "Cascade":
                    this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
                    spStatusText.Text = "Windows is cascade";
                    break;
                case "Title":
                    this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
                    spStatusText.Text = "Windows is horizontal";
                    break;
            }
        }
    }
}