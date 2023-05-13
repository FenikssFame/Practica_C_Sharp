using System.Windows.Forms;
using Task_1.Models;

namespace Task_1
{
    public partial class Form2 : Form
    {
        private bool rdCheckedOne;
        private bool rdCheckedTwo;
        private bool rdCheckedThree;
        private bool rdCheckedFore;
        private bool rdCheckedFive;
        public Form2()
        {
            InitializeComponent();
        }
        public bool RD_CheckerOne
        {
            get { return rdCheckedOne; }
            set { rdCheckedOne = value; }
        }
        public bool RD_CheckerTwo
        {
            get { return rdCheckedTwo; }
            set { rdCheckedTwo = value; }
        }
        public bool RD_CheckerThree
        {
            get { return rdCheckedThree; }
            set { rdCheckedThree = value; }
        }
        public bool RD_CheckerFore
        {
            get { return rdCheckedFore; }
            set { rdCheckedFore = value; }
        }
        public bool RD_CheckerFive
        {
            get { return rdCheckedFive; }
            set { rdCheckedFive = value; }
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            Form1 form1 = new Form1();
            if (rdCheckedOne == true)
            {
                Cercle c = new Cercle();
                c.CerclePaint(sender, e);
            }
            else if (rdCheckedTwo == true)
            {
                Rectangle r = new Rectangle();
                r.RectanglePaint(sender, e);
            }
            else if (rdCheckedThree == true)
            {
                ChesDask cd = new ChesDask();
                cd.ChesDaskPaint(sender, e);
            }
            else if (rdCheckedFore == true)
            {
                Lines l = new Lines();
                l.LinesPaint(sender, e);
            }
            else if (rdCheckedFive == true)
            {
                Lines l = new Lines();
                l.LinesZigZagPaint(sender, e);
            }
            else
            {
                MessageBox.Show("Выберите что нарисовать", "Внимание");
            }
        }
    }
}
