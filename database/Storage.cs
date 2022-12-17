using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace database.win
{
    public partial class Storage : Form
    {
        OleDbConnection connection;
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db.mdb;";
        public Storage()
        {
            InitializeComponent();
            connection = new OleDbConnection(connectString);
            connection.Open();
        }

        private void Storage_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.Вывод_Склада". При необходимости она может быть перемещена или удалена.
            this.вывод_СкладаTableAdapter.Fill(this.dbDataSet.Вывод_Склада);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            delivery delivery = new delivery();
            delivery.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer customer = new Customer();
            customer.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Seller seller = new Seller();
            seller.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sale sale = new Sale();
            sale.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Storage storage = new Storage();
            storage.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Product product = new Product();
            product.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            bool flagOK = true;


            if (textBox1.Text.Equals("") || textBox2.Text.Equals("") || textBox3.Text.Equals("") || textBox9.Text.Equals(""))
                flagOK = false;

            if (textBox3.Text.Length != 11)
            {
                MessageBox.Show("Запрос не выполнен, неверная длина номера телефона");
                flagOK = false;
            }
            if ( int.Parse(textBox9.Text) <= 0)
            {
                MessageBox.Show("Запрос не выполнен, неверная площадь склада");
                flagOK = false;
            }


            try
            {
                if (flagOK)
                {
                    string command = "INSERT INTO Склад (Регион, Адрес, Телефон, Площадь) VALUES (@reg, @address, @phoneNumber, @sq)";
                    OleDbCommand command1 = new OleDbCommand(command, connection);
                    command1.CommandType = CommandType.Text;

                    command1.Parameters.AddWithValue("@reg", textBox1.Text);
                    command1.Parameters.AddWithValue("@address", textBox2.Text);
                    command1.Parameters.AddWithValue("@phoneNumber", textBox3.Text);
                    command1.Parameters.AddWithValue("@sq", textBox9.Text);
                    command1.ExecuteNonQuery();

                }
                else
                    MessageBox.Show("Запрос не выполнен, проверьте правильность запроса");
            }
            catch (Exception ex)
            {
                Console.Error.Write(ex);
                MessageBox.Show("Запрос не выполнен, проверьте правильность запроса");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbDataReader reader = null;
                OleDbCommand command0 = new OleDbCommand("SELECT [Номер склада] from  Склад ", connection); // берем id всех складов, чтобы проверять что удаляемый (или изменяемый) объект есть в базе данных
                reader = command0.ExecuteReader();
                List<string> list = new List<string>();
                while (reader.Read())
                {

                    list.Add(reader[0].ToString());
                }

                if (!list.Contains(textBox4.Text))
                {
                    MessageBox.Show("Запрос не выполнен, такого объекта не существует");
                }
                else
                {
                    string command = "DELETE FROM Склад WHERE [Номер склада]= @IDSt";
                    OleDbCommand command1 = new OleDbCommand(command, connection)
                    {
                        CommandType = CommandType.Text
                    };
                    command1.Parameters.AddWithValue("@IDSt", textBox4.Text);
                    command1.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.Error.Write(ex);
                MessageBox.Show("Запрос не выполнен, проверьте правильность запроса");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            bool flagOK = true;

            if (textBox10.Text.Length != 11)
            {
                MessageBox.Show("Запрос не выполнен, неверная длина номера телефона");
                flagOK = false;
            }
            if (int.Parse(textBox5.Text) <= 0)
            {
                MessageBox.Show("Запрос не выполнен, неверная площадь склада");
                flagOK = false;
            }

            if (textBox8.Text.Equals("") || textBox7.Text.Equals("") || textBox6.Text.Equals("") || textBox10.Text.Equals("") || textBox5.Text.Equals(""))
                flagOK = false;

            OleDbCommand command0 = new OleDbCommand("SELECT [Номер склада] from  Склад ", connection);
            OleDbDataReader reader = command0.ExecuteReader();
            List<string> list = new List<string>();
            while (reader.Read())
            {

                list.Add(reader[0].ToString());
            }

            if (!list.Contains(textBox8.Text))
            {
                MessageBox.Show("Запрос не выполнен, такого объекта не существует");
            }
            else
            {
                try
                {
                    if (flagOK)
                    {
                        string command = "UPDATE Склад SET Регион = @reg, Адрес = @address, Телефон = @phoneNumber, Площадь = @sq Where [Номер склада] = @IDSt";
                        OleDbCommand command1 = new OleDbCommand(command, connection);
                        command1.CommandType = CommandType.Text;


                        command1.Parameters.AddWithValue("@reg", textBox7.Text);
                        command1.Parameters.AddWithValue("@address", textBox6.Text);
                        command1.Parameters.AddWithValue("@phoneNumber", textBox10.Text);
                        command1.Parameters.AddWithValue("@sq", textBox5.Text);
                        command1.Parameters.AddWithValue("@IDSt", textBox8.Text);
                        command1.ExecuteNonQuery();

                    }
                    else
                        MessageBox.Show("Запрос не выполнен, проверьте правильность запроса");
                }
                catch (Exception ex)
                {
                    Console.Error.Write(ex);
                    MessageBox.Show("Запрос не выполнен, проверьте правильность запроса");
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var command = "SELECT * FROM Склад";
            OleDbCommand command1 = new OleDbCommand(command, connection);
            var dataAdapter = new OleDbDataAdapter(command1);
            var dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
        }
    }
}
