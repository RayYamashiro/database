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
    
    public partial class delivery : Form
    {
        OleDbConnection connection;
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db.mdb;";
        public delivery()
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
            delivery delivery = new delivery();
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
                    command1.Parameters.AddWithValue("@date", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
                    command1.Parameters.AddWithValue("@fin", finFlag);
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
                    string command = "DELETE FROM Доставка WHERE [Код доставки]= @IDDel";
                    OleDbCommand command1 = new OleDbCommand(command, connection);
                    command1.CommandType = CommandType.Text;
                    command1.Parameters.AddWithValue("@IDDel", textBox4.Text);
                    command1.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.Error.Write(ex);
                MessageBox.Show("Запрос не выполнен, проверьте правильность запроса");
            }
        }
    }
}
