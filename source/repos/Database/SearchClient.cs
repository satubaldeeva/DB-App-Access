using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Database
{
    public partial class SearchClient : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = Торговая компания.mdb";
        private OleDbConnection myConnection;
        public SearchClient()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        { myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            string job = textBox1.Text;
            
            string query = "SELECT * FROM Клиенты WHERE Должность = '"+job +"'";
            OleDbDataAdapter command = new OleDbDataAdapter(query,myConnection);
            DataTable DT = new DataTable();
            command.Fill(DT);
            dataGridView1.DataSource = DT;
            myConnection.Close();

        }
    }
}
