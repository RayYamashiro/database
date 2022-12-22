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
    public partial class Sale : Form
    {
        OleDbConnection connection;
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db.mdb;";
        public Sale()
        {
            InitializeComponent();
            connection = new OleDbConnection(connectString);
            connection.Open();
        }

        private void Sale_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.Вывод__Продажи". При необходимости она может быть перемещена или удалена.
            this.вывод__ПродажиTableAdapter.Fill(this.dbDataSet.Вывод__Продажи);

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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            var command = "SELECT * FROM Продажа";
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
            textBox10.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            
            dataGridView1.DataSource = dataTable;
        }

        private void button10_Click(object sender, EventArgs e)
        {

            bool flagOK = true;

            if (textBox1.Text.Equals("") || textBox2.Text.Equals("") || textBox3.Text.Equals("") || textBox9.Text.Equals("") || textBox10.Text.Equals("") || textBox11.Text.Equals(""))
                flagOK = false;
            try
            {
                if(long.Parse(textBox10.Text) <= 0 || long.Parse(textBox11.Text) <= 0)
                    flagOK = false;
            }
            catch(FormatException)
            {
                flagOK = false;
                MessageBox.Show("Запрос не выполнен, неверная цена или количество");
            }

            // product
            OleDbDataReader reader = null;
            OleDbCommand command0 = new OleDbCommand("SELECT [Код товара] from  Товар ", connection); 
            reader = command0.ExecuteReader();
            List<string> list = new List<string>();
            while (reader.Read())
            {
                list.Add(reader[0].ToString());
            }
            if (!list.Contains(textBox1.Text))
            {
                MessageBox.Show("Запрос не выполнен, такого товара не существует");
                flagOK = false;
            }

            // seller
            OleDbDataReader reader1 = null;
            OleDbCommand command1 = new OleDbCommand("SELECT [Код продавца] from  Продавец ", connection);
            reader1 = command1.ExecuteReader();
            List<string> list1 = new List<string>();
            while (reader1.Read())
            {
                list1.Add(reader1[0].ToString());
            }
            if (!list1.Contains(textBox2.Text))
            {
                MessageBox.Show("Запрос не выполнен, такого продавца не существует");
                flagOK = false;
            }

            // customer
            OleDbDataReader reader2 = null;
            OleDbCommand command2 = new OleDbCommand("SELECT [Код покупателя] from  Покупатель ", connection);
            reader2 = command2.ExecuteReader();
            List<string> list2 = new List<string>();
            while (reader2.Read())
            {
                list2.Add(reader2[0].ToString());
            }
            if (!list2.Contains(textBox3.Text))
            {
                MessageBox.Show("Запрос не выполнен, такого покупателя не существует");
                flagOK = false;
            }

            // delivery
            OleDbDataReader reader3 = null;
            OleDbCommand command3 = new OleDbCommand("SELECT [Код доставки] from  Доставка ", connection);
            reader3 = command3.ExecuteReader();
            List<string> list3 = new List<string>();
            while (reader3.Read())
            {
                list3.Add(reader3[0].ToString());
            }
            if (!list3.Contains(textBox9.Text))
            {
                MessageBox.Show("Запрос не выполнен, такой доставки не существует");
                flagOK = false;
            }


            try
            {
                if (flagOK)
                {
                    string command = "INSERT INTO Продажа ([Код товара], [Код продавца], [Код покупателя], [Код доставки], Цена, Количество, [Дата продажи]) VALUES (@IDPr, @IDSel, @IDCus, @IDDel, @Price, @amount, @DateSel)";
                    OleDbCommand command11 = new OleDbCommand(command, connection);
                    command11.CommandType = CommandType.Text;
                    dateTimePicker1.CustomFormat = "yyyy/dd/MM";
                    command11.Parameters.AddWithValue("@IDPr", textBox1.Text);
                    command11.Parameters.AddWithValue("@IDSel", textBox2.Text);
                    command11.Parameters.AddWithValue("@IDCus", textBox3.Text);
                    command11.Parameters.AddWithValue("@IDDel", textBox9.Text);
                    command11.Parameters.AddWithValue("@Price", textBox10.Text);
                    command11.Parameters.AddWithValue("@amount", textBox11.Text);
                    command11.Parameters.AddWithValue("@DateSel", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
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
                    textBox10.Clear();
                    textBox12.Clear();
                    textBox13.Clear();
                    textBox14.Clear();
                    command11.ExecuteNonQuery();

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
                OleDbCommand command0 = new OleDbCommand("SELECT [Номер накладной] from  Продажа ", connection); // берем id всех складов, чтобы проверять что удаляемый (или изменяемый) объект есть в базе данных
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
                    string command = "DELETE FROM Продажа WHERE [Номер накладной]= @IDPr";
                    OleDbCommand command1 = new OleDbCommand(command, connection)
                    {
                        CommandType = CommandType.Text
                    };
                    command1.Parameters.AddWithValue("@IDPr", textBox4.Text);
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
                    textBox10.Clear();
                    textBox12.Clear();
                    textBox13.Clear();
                    textBox14.Clear();
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

            if (textBox13.Text.Equals("") || textBox12.Text.Equals("") || textBox8.Text.Equals("") || textBox7.Text.Equals("") || textBox6.Text.Equals("") || textBox5.Text.Equals("") || textBox14.Text.Equals(""))
                flagOK = false;
            try
            {
                if (long.Parse(textBox6.Text) <= 0 || long.Parse(textBox5.Text) <= 0)
                    flagOK = false;
            }
            catch (FormatException)
            {
                flagOK = false;
                MessageBox.Show("Запрос не выполнен, неверная цена или количество");
            }

            // product
            OleDbDataReader reader = null;
            OleDbCommand command0 = new OleDbCommand("SELECT [Код товара] from  Товар ", connection);
            reader = command0.ExecuteReader();
            List<string> list = new List<string>();
            while (reader.Read())
            {
                list.Add(reader[0].ToString());
            }
            if (!list.Contains(textBox14.Text))
            {
                MessageBox.Show("Запрос не выполнен, такого товара не существует");
                flagOK = false;
            }

            // seller
            OleDbDataReader reader1 = null;
            OleDbCommand command1 = new OleDbCommand("SELECT [Код продавца] from  Продавец ", connection);
            reader1 = command1.ExecuteReader();
            List<string> list1 = new List<string>();
            while (reader1.Read())
            {
                list1.Add(reader1[0].ToString());
            }
            if (!list1.Contains(textBox12.Text))
            {
                MessageBox.Show("Запрос не выполнен, такого продавца не существует");
                flagOK = false;
            }

            // customer
            OleDbDataReader reader2 = null;
            OleDbCommand command2 = new OleDbCommand("SELECT [Код покупателя] from  Покупатель ", connection);
            reader2 = command2.ExecuteReader();
            List<string> list2 = new List<string>();
            while (reader2.Read())
            {
                list2.Add(reader2[0].ToString());
            }
            if (!list2.Contains(textBox8.Text))
            {
                MessageBox.Show("Запрос не выполнен, такого покупателя не существует");
                flagOK = false;
            }

            // delivery
            OleDbDataReader reader3 = null;
            OleDbCommand command3 = new OleDbCommand("SELECT [Код доставки] from  Доставка ", connection);
            reader3 = command3.ExecuteReader();
            List<string> list3 = new List<string>();
            while (reader3.Read())
            {
                list3.Add(reader3[0].ToString());
            }
            if (!list3.Contains(textBox7.Text))
            {
                MessageBox.Show("Запрос не выполнен, такой доставки не существует");
                flagOK = false;
            }

            // sale
            OleDbDataReader reader4 = null;
            OleDbCommand command4 = new OleDbCommand("SELECT [Номер накладной] from  Продажа ", connection);
            reader4 = command4.ExecuteReader();
            List<string> list4 = new List<string>();
            while (reader4.Read())
            {
                list4.Add(reader4[0].ToString());
            }
            if (!list4.Contains(textBox13.Text))
            {
                MessageBox.Show("Запрос не выполнен, такой накладной не существует");
                flagOK = false;
            }


            try
            {
                if (flagOK)
                {
                    string command = "INSERT INTO Продажа ([Номер накладной], [Код товара], [Код продавца], [Код покупателя], [Код доставки], Цена, Количество, [Дата продажи]) VALUES (@IDSale, @IDPr, @IDSel, @IDCus, @IDDel, @Price, @amount, @DateSel)";
                    OleDbCommand command11 = new OleDbCommand(command, connection);
                    command11.CommandType = CommandType.Text;
                    dateTimePicker2.CustomFormat = "yyyy/dd/MM";
                    command11.Parameters.AddWithValue("@IDSale", textBox13.Text);
                    command11.Parameters.AddWithValue("@IDPr", textBox14.Text);
                    command11.Parameters.AddWithValue("@IDSel", textBox12.Text);
                    command11.Parameters.AddWithValue("@IDCus", textBox8.Text);
                    command11.Parameters.AddWithValue("@IDDel", textBox7.Text);
                    command11.Parameters.AddWithValue("@Price", textBox6.Text);
                    command11.Parameters.AddWithValue("@amount", textBox5.Text);
                    command11.Parameters.AddWithValue("@DateSel", SqlDbType.Date).Value = dateTimePicker2.Value.Date;
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
                    textBox10.Clear();
                    textBox12.Clear();
                    textBox13.Clear();
                    textBox14.Clear();
                    command11.ExecuteNonQuery();

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
}
