using database.win;
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
    public partial class Main : Form
    {
        OleDbConnection connection;
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db.mdb;";
        public Main()
        {
            InitializeComponent();
            connection = new OleDbConnection(connectString);
            connection.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.Вывод_Продавца". При необходимости она может быть перемещена или удалена.
            

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
            var command = "SELECT * FROM Доставка WHERE [Код доставки] > 3 ";
            OleDbCommand command1 = new OleDbCommand(command, connection);
            var dataAdapter = new OleDbDataAdapter(command1);
            var dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var command2 = "SELECT * FROM Товар WHERE Вес < 1000";
            OleDbCommand command12 = new OleDbCommand(command2, connection);
            var dataAdapter1 = new OleDbDataAdapter(command12);
            var dataTable1 = new DataTable();
            dataAdapter1.Fill(dataTable1);

            dataGridView1.DataSource = dataTable1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var command3 = "SELECT * FROM Продажа WHERE [Код товара] = 2";
            OleDbCommand command13 = new OleDbCommand(command3, connection);
            var dataAdapter3 = new OleDbDataAdapter(command13);
            var dataTable3 = new DataTable();
            dataAdapter3.Fill(dataTable3);

            dataGridView1.DataSource = dataTable3;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                string command = "SELECT * FROM Товар WHERE Размеры > @size";
                OleDbCommand command1 = new OleDbCommand(command, connection);
                command1.CommandType = CommandType.Text;
                if (textBox1.Text.Equals(""))
                {
                    MessageBox.Show("Запрос не выполнен, пустое поле");
                }
                else
                {
                    command1.Parameters.AddWithValue("@size", textBox1.Text);
                    var dataAdapter3 = new OleDbDataAdapter(command1);
                    var dataTable3 = new DataTable();

                    dataAdapter3.Fill(dataTable3);
                    textBox2.Clear();
                    textBox1.Clear();
                    textBox3.Clear();
                    dataGridView1.DataSource = dataTable3;
                }
            }catch(System.Data.OleDb.OleDbException)
            {
                MessageBox.Show("Неверный формат введенных данных");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string command = "SELECT * FROM Склад WHERE Площадь <  @sq";
            OleDbCommand command1 = new OleDbCommand(command, connection);
            command1.CommandType = CommandType.Text;
            command1.Parameters.AddWithValue("@sq", textBox2.Text);

            var dataAdapter3 = new OleDbDataAdapter(command1);
            var dataTable3 = new DataTable();
            dataAdapter3.Fill(dataTable3);

            textBox2.Clear();
            textBox1.Clear();
            textBox3.Clear();
            dataGridView1.DataSource = dataTable3;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string command = "SELECT * FROM Продажа WHERE  [Код продавца] >  @IDSel";
            OleDbCommand command1 = new OleDbCommand(command, connection);
            command1.CommandType = CommandType.Text;
            command1.Parameters.AddWithValue("@IDSel", textBox3.Text);

            var dataAdapter3 = new OleDbDataAdapter(command1);
            var dataTable3 = new DataTable();
            dataAdapter3.Fill(dataTable3);
            textBox2.Clear();
            textBox1.Clear();
            textBox3.Clear();
            dataGridView1.DataSource = dataTable3;
        }
    }
}
