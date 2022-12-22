using database.win;
using MySql.Data.MySqlClient;
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

namespace database
{
    
    public partial class Delivery : Form
    {
        OleDbConnection connection;
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db.mdb;";
        public Delivery()
        {
            InitializeComponent();
            connection = new OleDbConnection(connectString);
            connection.Open();

        }

        private void delivery_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.Вывод_Доставки". При необходимости она может быть перемещена или удалена.
            this.вывод_ДоставкиTableAdapter.Fill(this.dbDataSet.Вывод_Доставки);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delivery delivery = new Delivery();
            delivery.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Storage storage = new Storage();
            storage.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sale sale = new Sale();
            sale.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Product product = new Product();
            product.Show();
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

        private void button7_Click(object sender, EventArgs e)
        {
            string fin = textBox3.Text;
            bool finFlag = false;
            bool flagOK = true;

            if (fin.Equals("да") || fin.Equals("Да"))
            {
                finFlag = true;
            }
            else if (!fin.Equals("нет"))
                flagOK = false;
            if(textBox1.Text.Equals("") || textBox2.Text.Equals(""))
                flagOK = false;
            try
            {
                if (flagOK)
                {
                    string command = "INSERT INTO Доставка ([Пункт отправления], [Пункт назначения], Дата, [Отметка о выполнении]) VALUES (@dOut, @dIN, @dateD, @fin)";
                    OleDbCommand command1 = new OleDbCommand(command, connection);
                    command1.CommandType = CommandType.Text;
                    dateTimePicker1.CustomFormat = "yyyy/dd/MM";
                    command1.Parameters.AddWithValue("@dOut", textBox1.Text);
                    command1.Parameters.AddWithValue("@dIN", textBox2.Text);
                    command1.Parameters.AddWithValue("@dateD", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
                    command1.Parameters.AddWithValue("@fin", finFlag);

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox7.Clear();
                    textBox8.Clear();
                    
                    command1.ExecuteNonQuery();

                }
                else
                    MessageBox.Show("Запрос не выполнен, проверьте правильность запроса");
            }catch(Exception ex)
            {
                Console.Error.Write(ex);
                MessageBox.Show("Запрос не выполнен, проверьте правильность запроса");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
               
                
                OleDbDataReader reader = null;
                OleDbCommand command0 = new OleDbCommand("SELECT [Код доставки] from  Доставка ", connection);
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
                    string command01 = "DELETE FROM Продажа WHERE [Код доставки]= @IDDel";
                    OleDbCommand command11 = new OleDbCommand(command01, connection)
                    {
                        CommandType = CommandType.Text
                    };
                    command11.Parameters.AddWithValue("@IDSt", textBox4.Text);
                    command11.ExecuteNonQuery();


                    string command = "DELETE FROM Доставка WHERE [Код доставки]= @IDDel";
                    OleDbCommand command1 = new OleDbCommand(command, connection)
                    {
                        CommandType = CommandType.Text
                    };
                    command1.Parameters.AddWithValue("@IDDel", textBox4.Text);
                    command1.ExecuteNonQuery();

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox7.Clear();
                    textBox8.Clear();
                   
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
            string fin = textBox5.Text;
            bool finFlag = false;
            bool flagOK = true;

            if (fin.Equals("да") || fin.Equals("Да"))
            {
                finFlag = true;
            }
            else if (!fin.Equals("нет"))
                flagOK = false;
            if (textBox7.Text.Equals("") || textBox6.Text.Equals(""))
                flagOK = false;

            OleDbCommand command0 = new OleDbCommand("SELECT [Код доставки] from  Доставка ", connection);
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
                        string command = "UPDATE Доставка SET [Пункт отправления] = @dOut, [Пункт назначения] = @dIN, Дата = @dateD, [Отметка о выполнении] = @fin Where [Код доставки] = @IDDel";
                        OleDbCommand command1 = new OleDbCommand(command, connection);
                        command1.CommandType = CommandType.Text;
                        dateTimePicker2.CustomFormat = "yyyy/dd/MM";
                        
                        command1.Parameters.AddWithValue("@dOut", textBox7.Text);
                        command1.Parameters.AddWithValue("@dIN", textBox6.Text);
                        command1.Parameters.AddWithValue("@dateD", SqlDbType.Date).Value = dateTimePicker2.Value.Date;
                        command1.Parameters.AddWithValue("@fin", finFlag);
                        command1.Parameters.AddWithValue("@IDDel", textBox8.Text);

                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        textBox6.Clear();
                        textBox7.Clear();
                        textBox8.Clear();
                        
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            var command = "SELECT * FROM Доставка";
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
            
            dataGridView1.DataSource = dataTable;
        }
    }
}
