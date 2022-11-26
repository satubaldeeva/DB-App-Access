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
    public partial class SelectByRegion : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = Торговая компания.mdb";
        private OleDbConnection myConnection;
        public SelectByRegion()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
           

            string query = "SELECT * FROM Клиенты WHERE Область IS NULL";
            OleDbDataAdapter command = new OleDbDataAdapter(query, myConnection);
            DataTable DT = new DataTable();
            command.Fill(DT);
            dataGridView1.DataSource = DT;
            myConnection.Close();
        }
    }
}
