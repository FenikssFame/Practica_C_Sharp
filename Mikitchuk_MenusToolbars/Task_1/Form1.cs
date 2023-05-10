using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
    public partial class Form1 : Form
    {
        private uint _openDocuments = 1;
        public Form1()
        {
            InitializeComponent();
        }
        private void CreateNewMdiChild()
        {
            ChildForm newChild = new ChildForm
            {
                MdiParent = this,
                Text = $"{Text} #{_openDocuments++}",
            };
            newChild.Show();

            newChild.FormClosed += new FormClosedEventHandler((sender, e) =>
            {
                _openDocuments--;
            });
        }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Tag.ToString())
            {
                case "NewDoc":
                    CreateNewMdiChild();
                    break;
                case "Cascade":
                    LayoutMdi(MdiLayout.Cascade);
                    break;
                case "Title":
                    LayoutMdi(MdiLayout.TileHorizontal);
                    break;
            }
        }
    }
}
