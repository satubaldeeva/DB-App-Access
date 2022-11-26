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
    public partial class AddOrder : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = Торговая компания.mdb";
        private OleDbConnection myConnection;
        public AddOrder()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void AddOrder_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
            string code_order = "";
            code_order += textBox1.Text;
            string code_client = "";
            code_client+= textBox2.Text;
            string code_employement = "";
            code_employement += textBox3.Text;
            string data_placement = String.Format(dateTimePicker1.Text);
            string data_appointment = String.Format(dateTimePicker2.Text);
            string data_execution = String.Format(dateTimePicker3.Text);
            string delivery = textBox7.Text;
            string price = textBox8.Text;
            string name = textBox9.Text;
            string address= textBox10.Text;
            string city = textBox11.Text;
            string index = textBox12.Text;
            string region= textBox13.Text;
            string country = textBox14.Text;
                OleDbCommand command = new OleDbCommand();
                command.Connection = myConnection;
                command.CommandText = "INSERT INTO Заказы ([КодЗаказа], КодКлиента, КодСотрудника,ДатаРазмещения,ДатаНазначения,ДатаИсполнения,Доставка,СтоимостьДоставки,НазваниеПолучателя,АдресПолучателя,ГородПолучателя,ОбластьПолучателя,ИндексПолучателя,СтранаПолучателя) VALUES ( @CodeOrder ,@CodeClient,@CodeEmployement,@DataPlacement, @DataAppointment,@DataExecution,@Delivery,@Price, @Name , @Address,  @City , @Region , @Index , @Country )";
                command.Parameters.AddWithValue("@CodeOrder", code_order);
                command.Parameters.AddWithValue("@CodeClient", code_client);
                command.Parameters.AddWithValue("@CodeEmployement", code_employement);
                command.Parameters.AddWithValue("@DataPlacement", data_placement);
                command.Parameters.AddWithValue("@DataAppointment", data_appointment);
                command.Parameters.AddWithValue("@DataExecution", data_execution);
                command.Parameters.AddWithValue("@Delivery", delivery) ;
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@City", city);
                command.Parameters.AddWithValue("@Region", region);
                command.Parameters.AddWithValue("@Index", index);
                command.Parameters.AddWithValue("@Country", country);
               

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
