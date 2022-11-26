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
    public partial class AddClient : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = Торговая компания.mdb";
        private OleDbConnection myConnection;
        public AddClient()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kod = "";
            kod+=textBox1.Text;
            string name = "";
            name+= textBox2.Text ;
            string person = "";
            person+=textBox3.Text;
            string adres = "";
            adres+=textBox5.Text;
            string index= textBox9.Text;
            string city = textBox6.Text;
            string region = textBox7.Text;
            string fax = textBox10.Text;
            string phone = textBox8.Text;
            string country = textBox11.Text;
            string job = textBox4.Text;
            try
            {
                
                OleDbCommand command = new OleDbCommand();
                command.Connection = myConnection;
                command.CommandText = "INSERT INTO Клиенты ([КодКлиента], Название, ОбращатьсяК,Должность,Адрес,Город,Область,Индекс,Страна,Телефон,Факс) VALUES ( @Code , @Name , @Person , @Job , @Adres , @City , @Region , @Index , @Country , @Phone , @Fax)";
                command.Parameters.AddWithValue("@Code", kod);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Person", person);
                command.Parameters.AddWithValue("@Job", job);
                command.Parameters.AddWithValue("@Adres", adres);
                command.Parameters.AddWithValue("@City", city);
                command.Parameters.AddWithValue("@Region", region);
                command.Parameters.AddWithValue("@Index", index);
                command.Parameters.AddWithValue("@Country", country);
                command.Parameters.AddWithValue("@Phone", phone);
                command.Parameters.AddWithValue("@Fax", fax);
      
                command.ExecuteNonQuery();
                MessageBox.Show("Сотрудник добавлен!");
                

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
