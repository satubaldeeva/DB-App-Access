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
    public partial class Доставка : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = Торговая компания.mdb";
        private OleDbConnection myConnection;
        public Доставка()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void Доставка_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "торговая_компанияDataSet.Доставка". При необходимости она может быть перемещена или удалена.
            this.доставкаTableAdapter.Fill(this.торговая_компанияDataSet.Доставка);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.доставкаTableAdapter.Fill(this.торговая_компанияDataSet.Доставка);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string code = textBox2.Text;
                string value_list = "";
                if (listBox1.SelectedItems.Count == 0) { MessageBox.Show("Выберите поля для изменения!"); }
                else
                {
                    value_list += listBox1.SelectedItem.ToString();
                    string new_value = "";
                    new_value += textBox3.Text;
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = myConnection;
                    command.CommandText = "UPDATE Доставка SET [" + value_list + "] = @Value WHERE [КодДоставки] =@Code";
                    command.Parameters.AddWithValue("@Value", new_value);
                    command.Parameters.AddWithValue("@Code", code);

                    if (command.ExecuteNonQuery() > 0)
                    { MessageBox.Show("Данные о доставке обновлены!"); }
                    else
                    {
                        MessageBox.Show("Данные для обновления не найдены!");
                    }
                    this.доставкаTableAdapter.Fill(this.торговая_компанияDataSet.Доставка);
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
            catch (System.NullReferenceException ex) { MessageBox.Show(ex.Message); }

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
            AddDeliverry f = new AddDeliverry();
            f.Owner = this;
            f.Show();
        }
    }
}
