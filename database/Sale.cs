using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace database.win
{
    public partial class Sale : Form
    {
        public Sale()
        {
            InitializeComponent();
        }

        private void Sale_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.Вывод__Продажи". При необходимости она может быть перемещена или удалена.
            this.вывод__ПродажиTableAdapter.Fill(this.dbDataSet.Вывод__Продажи);

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
    }
}
