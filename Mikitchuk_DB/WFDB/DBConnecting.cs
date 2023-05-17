using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Reflection;
using System.Security.Authentication.ExtendedProtection;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WFDB
{
    public class DBConnection
    {
        private SqlConnection connection;
        public DBConnection()
        {
            //constructor
        }
        ~DBConnection()
        {
            //destructor
            connection = null;
        }
        public void Disconnect()
        {
            connection.Close();
        }
        public string ConnectDB()
        {
            try
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename = H:\Практика\Практика_С#\Mikitchuk_DB\WFDB\DB_TurFirma.mdf;Integrated Security=True;Connect Timeout=30";
                connection = new SqlConnection(connectionString);
                connection.Open();
                return "Connected";
            }
            catch (SqlCeException e)
            {
                connection = null;
                return e.Message;
            }
        }
        public void ExecSQL(string sql)
        {

            SqlCommand com = connection.CreateCommand();
            com.CommandText = sql;
            com.ExecuteNonQuery();
        }
        public DataSet getAllTurs(string selectCommand)
        {
            try
            {
                string query = selectCommand;
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (SqlCeException e)
            {
                MessageBox.Show(e.Source + "\n" + e.Message + "\n" + e.StackTrace);
                return null;
            }
        }
        public DataTable GetListBox()
        {
            DataTable schema = connection.GetSchema("Columns");
            return schema;
        }
        public void InsertInDB(string listItem, string SerName, string Name, string Patronymic)
        {
            try
            {
                string sql = $"INSERT INTO {listItem} (SerName, Name, Patronymic) VALUES (N'{SerName}', '{Name}', '{Patronymic}')";
                ExecSQL(sql);
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception Occre while creating table:" + e.Message + "\t" + e.GetType());
            }
        }
        public void Delete(string selectCommand, int num)
        {
            
            string sql = selectCommand;
            ExecSQL(sql);
        }
        public void Update(string listItem,  int id, string SerName, string Name, string Patronymic)
        {
            try
            {
                string sql = $"UPDATE {listItem} SET SerName = N'{SerName}', Name = N'{Name}', Patronymic = N'{Patronymic}' WHERE Id_Tourist = '{id}'";
                ExecSQL(sql);
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception Occre while creating table:" + e.Message + "\t" + e.GetType());
            }
        }
    }
}
