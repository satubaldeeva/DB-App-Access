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
    public partial class Заказы : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = Торговая компания.mdb";
        private OleDbConnection myConnection;
        public Заказы()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void Заказы_Load(object sender, EventArgs e)

        {
            try {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "торговая_компанияDataSet.Заказы". При необходимости она может быть перемещена или удалена.
                this.заказыTableAdapter.Fill(this.торговая_компанияDataSet.Заказы);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string code = textBox1.Text;
                OleDbCommand command = new OleDbCommand();
                command.Connection = myConnection;
                command.CommandText = "DELETE FROM Заказы WHERE [КодЗаказа] =@Code";
                command.Parameters.AddWithValue("@Code", code);
                if (code != "") {
                    if(command.ExecuteNonQuery() > 0) 
                    { MessageBox.Show("Данные о заказе удалены!");}
                    else
                    {
                        MessageBox.Show("Данные для удаления не найдены!");
                    }
                   
                    
                    this.заказыTableAdapter.Fill(this.торговая_компанияDataSet.Заказы);  }
                else
                {
                    MessageBox.Show("Введите КодЗаказа!");
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string code = textBox2.Text;
                string value_list = "";
                if (listBox1.SelectedItems.Count == 0) { MessageBox.Show("Выберите поля для изменения!"); }
                else {
                    value_list += listBox1.SelectedItem.ToString();
                    string new_value = "";
                    if (value_list == "ДатаНазначения" || value_list == "ДатаРазмещения" || value_list == "ДатаИсполнения")
                    {
                        new_value += String.Format(dateTimePicker1.Text);
                    }
                    else { new_value += textBox3.Text; }

                    OleDbCommand command = new OleDbCommand();
                    command.Connection = myConnection;
                    command.CommandText = "UPDATE Заказы SET [" + value_list + "] = @Value WHERE [КодЗаказа] =@Code";
                    command.Parameters.AddWithValue("@Value", new_value);
                    command.Parameters.AddWithValue("@Code", code);

                    if (command.ExecuteNonQuery() > 0)
                    { MessageBox.Show("Данные о заказе обновлены!"); }
                    else
                    {
                        MessageBox.Show("Данные для обновления не найдены!");
                    }
                    this.заказыTableAdapter.Fill(this.торговая_компанияDataSet.Заказы);
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = listBox1.SelectedItem.ToString();
            if (value == "ДатаНазначения" || value == "ДатаРазмещения" || value == "ДатаИсполнения")
            {
                textBox3.Visible = false;
                dateTimePicker1.Visible = true;
                
            }
            else
            {
                textBox3.Visible = true;
                dateTimePicker1.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddOrder  f2 = new AddOrder();
            f2.Owner = this;
            f2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.заказыTableAdapter.Fill(this.торговая_компанияDataSet.Заказы);
        
    }
    }
}
