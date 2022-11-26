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
    public partial class AddTovar : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = Торговая компания.mdb";
        private OleDbConnection myConnection;
        public AddTovar()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void AddTovar_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
            try
            {
                
                string marka = "";
                marka += textBox2.Text;
                int codeSupplier = int.Parse(textBox3.Text);
                int codeType = int.Parse(textBox4.Text);
                string unit = textBox5.Text;
                string price = textBox6.Text;
                int inStock = int.Parse(textBox7.Text);
                int waiting = int.Parse(textBox8.Text);
                int min = int.Parse(textBox9.Text);
                bool shipment = false;
                if (checkBox1.Checked == true)
                {
                    shipment = true;
                }

                OleDbCommand command = new OleDbCommand();
                command.Connection = myConnection;
                command.CommandText = "INSERT INTO Товары ( Марка, КодПоставщика,КодТипа,ЕдиницаИзмерения,Цена,НаСкладе,Ожидается,МинимальныйЗапас,ПоставкиПрекращены) VALUES ( @Marka , @CodeSupplier , @CodeType , @Unit , @Price , @InStock , @Wait ,@Min , @Shipment)";
                //command.Parameters.AddWithValue("@CodeTovar", codeTovar);
                command.Parameters.AddWithValue("@Marka", marka);
                command.Parameters.AddWithValue("@CodeSupplier", codeSupplier);
                command.Parameters.AddWithValue("@CodeType", codeType);
                command.Parameters.AddWithValue("@Unit",unit);
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@InStock", inStock);
                command.Parameters.AddWithValue("@Wait", waiting);
                command.Parameters.AddWithValue("@Min", min);
                command.Parameters.AddWithValue("@Shipment", shipment);
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

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
