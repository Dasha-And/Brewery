using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Brewery
{
    public partial class Order : Form
    {
        int user;
        public Order(int id)
        {
            InitializeComponent();
            user = id;
            const string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Vostro\source\repos\Brewery\Brewery\Brewery.mdf';Integrated Security=True";
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            DataTable grid = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter();
            SqlCommand gridUpd = new SqlCommand("SELECT * FROM Orders WHERE client_id = @user", connection);
            gridUpd.Parameters.Add("@user", SqlDbType.Int).Value = user;
            adapt.SelectCommand = gridUpd;
            adapt.Fill(grid);
            dataGridView1.DataSource = grid;
            connection.Close();
            dataGridView1.Columns[0].HeaderText = "Номер замовлення";
            dataGridView1.Columns[1].HeaderText = "Дата";
            dataGridView1.Columns[2].HeaderText = "Ваш ID";
            dataGridView1.Columns[3].HeaderText = "Сума замовлення";
        }

        private void Order_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "breweryDataSet7.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.breweryDataSet7.Orders);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserForm uf = new UserForm(user);
            uf.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Profile p = new Profile(user);
            p.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int order_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            int sum = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);
            DateTime date = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[1].Value);
            Check c = new Check(user, order_id, sum, date);
            c.Show();

        }
    }
}
