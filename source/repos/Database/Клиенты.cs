
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

    public partial class Клиенты : Form

    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = Торговая компания.mdb";
        private OleDbConnection myConnection;
        public Клиенты()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "торговая_компанияDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.торговая_компанияDataSet.Клиенты);

        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            try {string code = textBox1.Text;
            OleDbCommand command = new OleDbCommand();
            command.Connection= myConnection;
            command.CommandText= "DELETE FROM Клиенты WHERE [КодКлиента] =@Code";
            command.Parameters.AddWithValue("@Code", code);
                if (code != "")
                {
                    if (command.ExecuteNonQuery() > 0)
                    { MessageBox.Show("Данные о клиенте удалены!"); }
                    else
                    {
                        MessageBox.Show("Данные для удаления не найдены!");
                    }


                    this.клиентыTableAdapter.Fill(this.торговая_компанияDataSet.Клиенты);
                }
                else
                {
                    MessageBox.Show("Введите КодКлиента!");
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
                string value= listBox1.SelectedItem.ToString();
                label5.Text = "";
                label5.Text += value;
                string job = textBox3.Text;
                OleDbCommand command = new OleDbCommand();
                command.Connection = myConnection;
                command.CommandText = "UPDATE Клиенты SET "+value +" =@Job WHERE [КодКлиента] =@Code";
                command.Parameters.AddWithValue("@Job", job); 
                command.Parameters.AddWithValue("@Code", code);
                //command.Parameters.AddWithValue("@Val", value);
                
                label5.Text += command.CommandText.ToString();
                if (command.ExecuteNonQuery() > 0)
                { MessageBox.Show("Данные о сотруднике обновлены!"); }
                else
                {
                    MessageBox.Show("Данные для обновления не найдены!");
                }
                
                this.клиентыTableAdapter.Fill(this.торговая_компанияDataSet.Клиенты);
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
            AddClient f2 = new AddClient();
            f2.Owner = this;
            f2.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.клиентыTableAdapter.Fill(this.торговая_компанияDataSet.Клиенты);
        }

        private void сотрудникиПоДолжностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchClient f3 = new SearchClient();
            f3.Owner = this;
            f3.Show();
        }

        private void выводОбластейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectByRegion f4 = new SelectByRegion();
            f4.Owner = this;
            f4.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void сотрудникиПоНазваниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchClientByName f4 = new SearchClientByName();
            f4.Owner = this;
            f4.Show();
        }

        private void сотрудникиПоКодуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchClientByCode f4 = new SearchClientByCode();
            f4.Owner = this;
            f4.Show();
        }
    }
}
