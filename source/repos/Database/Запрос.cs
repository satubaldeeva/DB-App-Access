using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public partial class Запрос : Form
    {
        public static string connectString = @"Provider=Microsoft.Jet.OLEDB.4.0;"+
            @"Data Source = Торговая компания.mdb;"+
            @"Jet OLEDB:Create System Database=true;"+
            @"Jet OLEDB:System database='C:\\Users\\NITRO 5\\Downloads\\system.mdw'";
        private OleDbConnection myConnection;
        public Запрос()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT MSysObjects.Id, MSysObjects.Name FROM MSysObjects WHERE MSysObjects.Type=" + 1 + " AND Left([Name], 4) <>'" + "MSys" + "'And Left([Name], 4) <>'" + "USys" + "'";
                OleDbDataAdapter command = new OleDbDataAdapter(query, myConnection);
                DataTable dt = new DataTable();
                command.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
