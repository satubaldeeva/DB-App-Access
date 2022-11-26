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
    public partial class Типы : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = Торговая компания.mdb";
        private OleDbConnection myConnection;
        public Типы()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void Типы_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "торговая_компанияDataSet.Типы". При необходимости она может быть перемещена или удалена.
            this.типыTableAdapter.Fill(this.торговая_компанияDataSet.Типы);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.типыTableAdapter.Fill(this.торговая_компанияDataSet.Типы);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string code = textBox1.Text;
                OleDbCommand command = new OleDbCommand();
                command.Connection = myConnection;
                command.CommandText = "DELETE FROM Типы WHERE [КодТипа] =@Code";
                command.Parameters.AddWithValue("@Code", code);
                if (code != "")
                {
                    if (command.ExecuteNonQuery() > 0)
                    { MessageBox.Show("Данные о типе удалены!"); }
                    else
                    {
                        MessageBox.Show("Данные для удаления не найдены!");
                    }


                    this.типыTableAdapter.Fill(this.торговая_компанияDataSet.Типы);
                }
                else
                {
                    MessageBox.Show("Введите КодТипа!");
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

        private void button3_Click(object sender, EventArgs e)
        {
            AddType f = new AddType();
            f.Owner = this;
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string code = textBox2.Text;
                string value;
                label5.Text = "";
               
                string job = textBox3.Text;
                if (listBox1.SelectedItems.Count == 0)
                {MessageBox.Show("Выберите поле для обнолвения!"); }
                else {
                    value = listBox1.SelectedItem.ToString();
                    label5.Text += value;
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = myConnection;
                    command.CommandText = "UPDATE Типы SET " + value + " =@Job WHERE [КодТипа] =@Code";
                    command.Parameters.AddWithValue("@Job", job);
                    command.Parameters.AddWithValue("@Code", code);
                    //command.Parameters.AddWithValue("@Val", value);

                    label5.Text += command.CommandText.ToString();
                    if (command.ExecuteNonQuery() > 0)
                    { MessageBox.Show("Данные о типе обновлены!"); }
                    else
                    {
                        MessageBox.Show("Данные для обновления не найдены!");
                    }

                    this.типыTableAdapter.Fill(this.торговая_компанияDataSet.Типы);
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
