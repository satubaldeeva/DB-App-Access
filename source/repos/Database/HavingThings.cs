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
    public partial class HavingThings : Form

    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = Торговая компания.mdb";
        private OleDbConnection myConnection;
        public HavingThings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();


            string query = "SELECT [Список товаров].КодТовара, [Список товаров].Марка FROM Товары AS[Список товаров] WHERE((([Список товаров].ПоставкиПрекращены) = No)) ORDER BY[Список товаров].Марка;";
            OleDbDataAdapter command = new OleDbDataAdapter(query, myConnection);
            DataTable DT = new DataTable();
            command.Fill(DT);
            dataGridView1.DataSource = DT;
            myConnection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
