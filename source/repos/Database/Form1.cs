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
    public partial class Form1 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = Торговая компания.mdb";
        private OleDbConnection myConnection;
        public Form1()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }
        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }
        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Поставщики a = new Поставщики();
            a.Owner = this;
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Клиенты f1 = new Клиенты();
            f1.Owner = this;
            f1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Типы f1 = new Типы();
            f1.Owner = this;
            f1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Товары f1 = new Товары();
            f1.Owner = this;
            f1.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            Заказано f1 = new Заказано();
            f1.Owner = this;
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Заказы f1 = new Заказы();
            f1.Owner = this;
            f1.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Сотрудники f1 = new Сотрудники();
            f1.Owner = this;
            f1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Доставка f1 = new Доставка();
            f1.Owner = this;
            f1.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Запрос f1 = new Запрос();
            f1.Owner = this;
            f1.Show();
        }
    }
}
