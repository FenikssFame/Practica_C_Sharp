using System;
using System.Data;
using System.Windows.Forms;

namespace WFDB
{
    public partial class Form1 : Form
    {
        public DBConnection DBConn = new DBConnection();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dbStatus.Items[0].Text = DBConn.ConnectDB();
            if (dbStatus.Items[0].Text == "Connected")
            {
                DataTable dt = DBConn.GetListBox();
                foreach (DataRow row in dt.Rows)
                {
                    if (!listBox1.Items.Contains(row.Field<string>("TABLE_NAME")))
                        listBox1.Items.Add(row.Field<string>("TABLE_NAME"));
                }
            }
            DBConn.Disconnect();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DBConn.Disconnect();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbStatus.Items[0].Text = DBConn.ConnectDB();
            string listItem = listBox1.SelectedItem.ToString();
            DataSet ds = DBConn.getAllTurs($"SELECT * FROM {listItem}");
            if (dbStatus.Items[0].Text == "Connected")
            {
                textBox1.Text = (listItem);
                dgvTurs.DataSource = ds.Tables[0];
            }
            DBConn.Disconnect();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            dbStatus.Items[0].Text = DBConn.ConnectDB();
            string listItem = listBox1.SelectedItem.ToString();
            string SerName = tbSerName.Text;
            string Name = tbName.Text;
            string Patronymic = tbPatronymic.Text;
            DBConn.InsertInDB(listItem, SerName, Name, Patronymic);           
            listBox1_SelectedIndexChanged(sender, e);
            DBConn.Disconnect();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            dbStatus.Items[0].Text = DBConn.ConnectDB();
            string listItem = listBox1.SelectedItem.ToString();
            int s = (int)dgvTurs.CurrentCell.Value;
            string selectConnection = $"DELETE FROM {listItem}" +
                                        $" WHERE Id_Tur = {s}";
            DBConn.Delete(selectConnection, s);
            listBox1_SelectedIndexChanged(sender, e);
            DBConn.Disconnect();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            dbStatus.Items[0].Text = DBConn.ConnectDB();
            string listItem = listBox1.SelectedItem.ToString();
            int id = (int)dgvTurs.CurrentCell.Value;
            string SerName = tbSerName.Text;
            string Name = tbName.Text;
            string Patronymic = tbPatronymic.Text;
            DBConn.Update(listItem, id, SerName, Name, Patronymic);
            listBox1_SelectedIndexChanged(sender, e);
            DBConn.Disconnect();
        }
    }
}
