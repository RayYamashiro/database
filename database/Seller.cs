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
    public partial class Seller : Form
    {
        OleDbConnection connection;
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db.mdb;";
        public Seller()
        {
            InitializeComponent();
            connection = new OleDbConnection(connectString);
            connection.Open();
        }

        private void Seller_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.Вывод_Продавца". При необходимости она может быть перемещена или удалена.
            this.вывод_ПродавцаTableAdapter.Fill(this.dbDataSet.Вывод_Продавца);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delivery delivery = new Delivery();
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
            if (textBox9.Text.Length != 10)
            {
                MessageBox.Show("Запрос не выполнен, неверная длина ИНН");
                flagOK = false;
            }
            try
            {
                long.Parse(textBox3.Text);
                long.Parse(textBox9.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Запрос не выполнен, неверный формат ввода");
                flagOK = false;
            }
            try
            {
                if (flagOK)
                {
                    string command = "INSERT INTO Продавец ([Наименование продавца], Адрес, Телефон, ИНН) VALUES (@name, @address, @phoneNumber, @doc)";
                    OleDbCommand command1 = new OleDbCommand(command, connection);
                    command1.CommandType = CommandType.Text;

                    command1.Parameters.AddWithValue("@name", textBox1.Text);
                    command1.Parameters.AddWithValue("@address", textBox2.Text);
                    command1.Parameters.AddWithValue("@phoneNumber", textBox3.Text);
                    command1.Parameters.AddWithValue("@doc", textBox9.Text);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox7.Clear();
                    textBox8.Clear();
                    textBox9.Clear();
                    textBox10.Clear();
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
                OleDbCommand command0 = new OleDbCommand("SELECT [Код продавца] from  Продавец ", connection);
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

                    string command01 = "DELETE FROM Продажа WHERE [Код продавца]= @IDSel";
                    OleDbCommand command11 = new OleDbCommand(command01, connection)
                    {
                        CommandType = CommandType.Text
                    };
                    command11.Parameters.AddWithValue("@IDSt", textBox4.Text);
                    command11.ExecuteNonQuery();


                    string command = "DELETE FROM Продавец WHERE [Код продавца]= @IDSel";
                    OleDbCommand command1 = new OleDbCommand(command, connection)
                    {
                        CommandType = CommandType.Text
                    };
                    command1.Parameters.AddWithValue("@IDSel", textBox4.Text);

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox7.Clear();
                    textBox8.Clear();
                    textBox9.Clear();
                    textBox10.Clear();

                    command1.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.Error.Write(ex);
                MessageBox.Show("Запрос не выполнен, проверьте правильность запроса");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var command = "SELECT * FROM Продавец";
            OleDbCommand command1 = new OleDbCommand(command, connection);
            var dataAdapter = new OleDbDataAdapter(command1);
            var dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            dataGridView1.DataSource = dataTable;
        }

        private void button8_Click(object sender, EventArgs e)
        {

            bool flagOK = true;

            if (textBox10.Text.Length != 11)
            {
                MessageBox.Show("Запрос не выполнен, неверная длина номера телефона");
                flagOK = false;
            }
            if (textBox5.Text.Length != 10)
            {
                MessageBox.Show("Запрос не выполнен, неверная длина ИНН");
                flagOK = false;
            }
            try
            {
                long.Parse(textBox5.Text);
                long.Parse(textBox10.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Запрос не выполнен, неверный формат ввода");
                flagOK = false;
            }
            if (textBox8.Text.Equals("") || textBox7.Text.Equals("") || textBox6.Text.Equals("") || textBox10.Text.Equals("") || textBox5.Text.Equals(""))
                flagOK = false;

            OleDbCommand command0 = new OleDbCommand("SELECT [Код продавца] from  Продавец ", connection);
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
                        string command = "UPDATE Продавец SET [Наименование продавца] = @name, Адрес = @address, Телефон = @phoneNumber, ИНН = @doc Where [Код продавца] = @IDSel";
                        OleDbCommand command1 = new OleDbCommand(command, connection);
                        command1.CommandType = CommandType.Text;


                        command1.Parameters.AddWithValue("@name", textBox7.Text);
                        command1.Parameters.AddWithValue("@address", textBox6.Text);
                        command1.Parameters.AddWithValue("@phoneNumber", textBox10.Text);
                        command1.Parameters.AddWithValue("@doc", textBox5.Text);
                        command1.Parameters.AddWithValue("@IDSel", textBox8.Text);

                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        textBox6.Clear();
                        textBox7.Clear();
                        textBox8.Clear();
                        textBox9.Clear();
                        textBox10.Clear();

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

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
