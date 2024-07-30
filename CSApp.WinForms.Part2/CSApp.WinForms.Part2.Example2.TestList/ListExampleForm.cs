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
using System.Xml;

namespace CSApp.WinForms.Part2.Example2.TestList
{
    public partial class ListExampleForm : Form
    {
        public ListExampleForm()
        {
            InitializeComponent();
        }

        private void ButtonAddClick(object sender, EventArgs e)
        {
            if (peopleList.Text.Length != 0)
            {
                memberList.Items.Add(peopleList.Text);
            }
            else 
            {
                MessageBox.Show("Choose element");
            }
        }

        private void ButtonDeleteClick(object sender, EventArgs e)
        {
            while (memberList.CheckedIndices.Count > 0)
            { 
                memberList.Items.RemoveAt(memberList.CheckedIndices[0]);
            }
        }

        private void ButtonSortClick(object sender, EventArgs e)
        {
            memberList.Sorted = true;
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            peopleList.Items.Clear();
            FileStream fStream = new FileStream("..\\..\\PeopleSource.xml", 
                FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(fStream);

            for (int i = 0; i < xmlDoc.DocumentElement.ChildNodes.Count; i++)
            {
                peopleList.Items.Add(xmlDoc.DocumentElement.ChildNodes[i].InnerText);
            }

            fStream.Close();
        }
    }
}
