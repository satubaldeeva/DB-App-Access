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
    public partial class AddOrder2 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = Торговая компания.mdb";
        private OleDbConnection myConnection;
        public AddOrder2()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

               int codeOrder =int.Parse( textBox1.Text);
                int codeTovar = int.Parse(textBox2.Text);
               
                int price = int.Parse(textBox3.Text);
                int count = int.Parse(textBox7.Text);
                int sale = int.Parse(textBox8.Text);
                

                OleDbCommand command = new OleDbCommand();
                command.Connection = myConnection;
                command.CommandText = "INSERT INTO Заказано ( КодЗаказа, КодТовара,Цена,Количество,Скидка) VALUES ( @CodeOrder, @CodeTovar , @Price , @Count, @Sale)";
                command.Parameters.AddWithValue("@CodeOrder", codeOrder);
                command.Parameters.AddWithValue("@CodeTovar", codeTovar);
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@Count", count);
                command.Parameters.AddWithValue("@Sale", sale);
                if (command.ExecuteNonQuery() > 0)
                { MessageBox.Show("Заказ добавлен!"); }
                else
                {
                    MessageBox.Show("Данные для добавления не найдены!");
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch (System.Data.OleDb.OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }
    }
}
