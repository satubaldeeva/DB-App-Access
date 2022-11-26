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
    public partial class Поставщики : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = Торговая компания.mdb";
        private OleDbConnection myConnection;
        public Поставщики()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void Поставщики_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "торговая_компанияDataSet.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter.Fill(this.торговая_компанияDataSet.Поставщики);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string code = textBox1.Text;
                OleDbCommand command = new OleDbCommand();
                command.Connection = myConnection;
                command.CommandText = "DELETE FROM Поставщики WHERE [КодПоставщика] =@Code";
                command.Parameters.AddWithValue("@Code", code);
                if (code != "")
                {
                    if (command.ExecuteNonQuery() > 0)
                    { MessageBox.Show("Данные о поставщике удалены!"); }
                    else
                    {
                        MessageBox.Show("Данные для удаления не найдены!");
                    }
                    this.поставщикиTableAdapter.Fill(this.торговая_компанияDataSet.Поставщики);
                }
                else
                {
                    MessageBox.Show("Введите КодПоставщика!");
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.поставщикиTableAdapter.Fill(this.торговая_компанияDataSet.Поставщики);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string code = textBox2.Text;
                string value;
                
                string job = textBox3.Text;
                if (listBox1.SelectedItems.Count == 0)
                { MessageBox.Show("Выберите поле для обнолвения!"); }
                else
                {
                    value = listBox1.SelectedItem.ToString();
                   
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = myConnection;
                    command.CommandText = "UPDATE Поставщики SET " + value + " =@Job WHERE [КодПоставщика] =@Code";
                    command.Parameters.AddWithValue("@Job", job);
                    command.Parameters.AddWithValue("@Code", code);
                    //command.Parameters.AddWithValue("@Val", value);

                    if (command.ExecuteNonQuery() > 0)
                    { MessageBox.Show("Данные о поставщике обновлены!"); }
                    else
                    {
                        MessageBox.Show("Данные для обновления не найдены!");
                    }

                    this.поставщикиTableAdapter.Fill(this.торговая_компанияDataSet.Поставщики);
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
            AddSupplier f = new AddSupplier();
            f.Owner = this;
            f.Show();
        }
    }
}
