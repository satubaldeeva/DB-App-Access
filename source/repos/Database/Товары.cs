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
    public partial class Товары : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = Торговая компания.mdb";
        private OleDbConnection myConnection;
        public Товары()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void Товары_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "торговая_компанияDataSet.Товары". При необходимости она может быть перемещена или удалена.
            this.товарыTableAdapter.Fill(this.торговая_компанияDataSet.Товары);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.товарыTableAdapter.Fill(this.торговая_компанияDataSet.Товары);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string code = textBox1.Text;
                OleDbCommand command = new OleDbCommand();
                command.Connection = myConnection;
                command.CommandText = "DELETE FROM Товары WHERE [КодТовара] =@Code";
                command.Parameters.AddWithValue("@Code", code);
                if (code != "")
                {
                    if (command.ExecuteNonQuery() > 0)
                    { MessageBox.Show("Данные о товаре удалены!"); }
                    else
                    {
                        MessageBox.Show("Данные для удаления не найдены!");
                    }


                    this.товарыTableAdapter.Fill(this.торговая_компанияDataSet.Товары);
                }
                else
                {
                    MessageBox.Show("Введите КодТовара!");
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
                string value;
                label5.Text = "";

                string job = textBox3.Text;
                if (listBox1.SelectedItems.Count == 0)
                { MessageBox.Show("Выберите поле для обнолвения!"); }
                else
                {
                    value = listBox1.SelectedItem.ToString();
                    label5.Text += value;
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = myConnection;
                    command.CommandText = "UPDATE Товары SET " + value + " =@Job WHERE [КодТовара] =@Code";
                    command.Parameters.AddWithValue("@Job", job);
                    command.Parameters.AddWithValue("@Code", code);
                    //command.Parameters.AddWithValue("@Val", value);

                    label5.Text += command.CommandText.ToString();
                    if (command.ExecuteNonQuery() > 0)
                    { MessageBox.Show("Данные о товаре обновлены!"); }
                    else
                    {
                        MessageBox.Show("Данные для обновления не найдены!");
                    }

                    this.товарыTableAdapter.Fill(this.торговая_компанияDataSet.Товары);
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

            AddTovar f = new AddTovar();
            f.Owner = this;
            f.Show();
        }

        private void нетВНаличииToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void нетВНаличииToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NotInStock f = new NotInStock();
            f.Owner = this;
            f.Show();
        }

        private void списокИмеющихсяТоваровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HavingThings f = new HavingThings();
            f.Owner = this;
            f.Show();
        }
    }
}
