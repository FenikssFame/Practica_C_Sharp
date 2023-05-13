using System;
using System.Windows.Forms;

namespace Task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.RD_CheckerOne = radioButton1.Checked;
            form2.RD_CheckerTwo = radioButton2.Checked;
            form2.RD_CheckerThree = radioButton3.Checked;
            form2.RD_CheckerFore = radioButton4.Checked;
            form2.RD_CheckerFive = radioButton5.Checked;
            form2.ShowDialog();
        }
    }
}
