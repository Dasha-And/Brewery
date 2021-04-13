using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Brewery
{
    public partial class UserForm : Form
    {
        int user;
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Vostro\source\repos\Brewery\Brewery\Brewery.mdf';Integrated Security=True";
        List<string> choice = new List<string>();
        List<int> amount = new List<int>();
        public UserForm(int id)
        {
            InitializeComponent();
            user = id;
            const string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Vostro\source\repos\Brewery\Brewery\Brewery.mdf';Integrated Security=True";
            SqlConnection connection = new SqlConnection(conString);
            DataTable grid = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter();
            SqlCommand gridUpd = new SqlCommand("SELECT * FROM Products", connection);
            adapt.SelectCommand = gridUpd;
            adapt.Fill(grid);
            dataGridView1.DataSource = grid;
            connection.Close();
            dataGridView1.Columns[0].HeaderText = "Найменування товару";
            dataGridView1.Columns[1].HeaderText = "ІД сорту";
            dataGridView1.Columns[2].HeaderText = "Об'єм";
            dataGridView1.Columns[3].HeaderText = "Тара";
            dataGridView1.Columns[4].HeaderText = "Наявність(ящиків)"; 
            dataGridView1.Columns[5].HeaderText = "Ціна";
            


        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "breweryDataSet5.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.breweryDataSet5.Products);
            int amount = dataGridView1.RowCount - 1;
            for (int i = 0; i < amount; i++)
            {
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value) == 0)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.DarkOrange;
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = System.Drawing.Color.White;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            choice.Add(dataGridView1.CurrentCell.Value.ToString());
            amount.Add(Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            

            MyOrder mo = new MyOrder(choice, user, amount);
            mo.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Order o = new Order(user);
            o.Show();
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
    }
}
