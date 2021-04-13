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
    public partial class InStock : Form
    {
        const string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Vostro\source\repos\Brewery\Brewery\Brewery.mdf';Integrated Security=True";
        public InStock()
        {
            InitializeComponent();
            const string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Vostro\source\repos\Brewery\Brewery\Brewery.mdf';Integrated Security=True";
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            DataTable grid = new DataTable();

            SqlDataAdapter adapt = new SqlDataAdapter();

            SqlCommand gridUpd = new SqlCommand("SELECT * FROM Products WHERE in_stock != 0", connection);
            adapt.SelectCommand = gridUpd;
            adapt.Fill(grid);
            dataGridView1.DataSource = grid;
            dataGridView1.Columns[0].HeaderText = "Найменування товару";
            dataGridView1.Columns[1].HeaderText = "ID сорту";
            dataGridView1.Columns[2].HeaderText = "Об'єм";
            dataGridView1.Columns[3].HeaderText = "Тара";
            dataGridView1.Columns[4].HeaderText = "Наявність(ящиків)";
            dataGridView1.Columns[5].HeaderText = "Ціна за ящик";
        }
    }
}
