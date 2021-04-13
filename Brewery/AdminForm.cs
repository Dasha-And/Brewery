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
    public partial class AdminForm : Form
    {
        const string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Vostro\source\repos\Brewery\Brewery\Brewery.mdf';Integrated Security=True";
        public AdminForm()
        {
            InitializeComponent();

            const string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Vostro\source\repos\Brewery\Brewery\Brewery.mdf';Integrated Security=True";
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            DataTable grid = new DataTable();
            DataTable grid2 = new DataTable();
            DataTable grid3 = new DataTable();
            DataTable grid4 = new DataTable();
            DataTable grid5 = new DataTable();
            DataTable grid6 = new DataTable();

            SqlDataAdapter adapt = new SqlDataAdapter();

            SqlCommand gridUpd = new SqlCommand("SELECT * FROM Products", connection);
            adapt.SelectCommand = gridUpd;
            adapt.Fill(grid);
            dataGridView1.DataSource = grid;

            SqlCommand gridUpd2 = new SqlCommand("SELECT * FROM Sorts", connection);
            adapt.SelectCommand = gridUpd2;
            adapt.Fill(grid2);
            dataGridView5.DataSource = grid2;

            SqlCommand gridUpd3 = new SqlCommand("SELECT order_id, date, client_id, sum FROM Orders", connection);
            adapt.SelectCommand = gridUpd3;
            adapt.Fill(grid3);
            dataGridView2.DataSource = grid3;


            SqlCommand gridUpd4 = new SqlCommand("SELECT * FROM Order_component", connection);
            adapt.SelectCommand = gridUpd4;
            adapt.Fill(grid4);
            dataGridView3.DataSource = grid4;


            SqlCommand gridUpd5 = new SqlCommand("SELECT product_name, COUNT(product_name) AS amount FROM Order_component GROUP BY product_name ORDER BY amount DESC", connection);
            adapt.SelectCommand = gridUpd5;
            adapt.Fill(grid5);
            dataGridView6.DataSource = grid5;
            connection.Close();

            SqlCommand gridUpd6 = new SqlCommand("SELECT client_id, COUNT(client_id) AS amount FROM Orders GROUP BY client_id ORDER BY amount DESC", connection);
            adapt.SelectCommand = gridUpd6;
            adapt.Fill(grid6);
            dataGridView7.DataSource = grid6;
            connection.Close();

            dataGridView5.Columns[0].HeaderText = "ID сорту";
            dataGridView5.Columns[1].HeaderText = "Вміст спирту";
            dataGridView5.Columns[2].HeaderText = "Колір";
            dataGridView5.Columns[3].HeaderText = "Солодкість";
            dataGridView5.Columns[4].HeaderText = "Ім'я сорту";

            dataGridView2.Columns[0].HeaderText = "ID замовлення";
            dataGridView2.Columns[1].HeaderText = "Дата";
            dataGridView2.Columns[2].HeaderText = "ІД клієнта";
            dataGridView2.Columns[3].HeaderText = "Сума";

            dataGridView3.Columns[0].HeaderText = "Номер";
            dataGridView3.Columns[1].HeaderText = "Дата";
            dataGridView3.Columns[2].HeaderText = "ІД замовлення";
            dataGridView3.Columns[3].HeaderText = "Кількість ящиків";

            dataGridView6.Columns[0].HeaderText = "Назва";
            dataGridView6.Columns[1].HeaderText = "Кількість замовлень";

            dataGridView7.Columns[0].HeaderText = "ID замовника";
            dataGridView7.Columns[1].HeaderText = "Кількість замовлень";
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "breweryDataSet20.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter3.Fill(this.breweryDataSet20.Clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "breweryDataSet19.Clients". При необходимости она может быть перемещена или удалена.
            //this.clientsTableAdapter3.Fill(this.breweryDataSet19.Clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "breweryDataSet18.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter2.Fill(this.breweryDataSet18.Clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "breweryDataSet17.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter1.Fill(this.breweryDataSet17.Clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "breweryDataSet12.Sorts". При необходимости она может быть перемещена или удалена.
            //this.sortsTableAdapter.Fill(this.breweryDataSet12.Sorts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "breweryDataSet11.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.breweryDataSet11.Clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "breweryDataSet10.Order_component". При необходимости она может быть перемещена или удалена.
            this.order_componentTableAdapter.Fill(this.breweryDataSet10.Order_component);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "breweryDataSet9.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.breweryDataSet9.Orders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "breweryDataSet8.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.breweryDataSet8.Products);
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

        private void button1_Click(object sender, EventArgs e)
        {
            AddForm af = new AddForm();
            
            af.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditForm ef = new EditForm();
            ef.textBox1.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[0].Value);
            ef.Sort.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[1].Value);
            ef.Volume.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[2].Value);
            ef.Tara.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[3].Value);
            ef.Amount.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[4].Value);
            ef.Price2.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[5].Value);
            ef.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                const string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Vostro\source\repos\Brewery\Brewery\Brewery.mdf';Integrated Security=True";
                SqlConnection connection = new SqlConnection(conString);
                connection.Open();
                SqlCommand del = new SqlCommand("DELETE Products WHERE product_name = @id", connection);
                del.Parameters.Add("@id", SqlDbType.NVarChar).Value = dataGridView1.CurrentCell.Value;
                del.ExecuteNonQuery();
                connection.Close();

                connection.Open();
                DataTable grid = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter();
                SqlCommand gridUpd = new SqlCommand("SELECT * FROM Products", connection);
                adapt.SelectCommand = gridUpd;
                adapt.Fill(grid);
                dataGridView1.DataSource = grid;
                connection.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SortAdd sa = new SortAdd();
            sa.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlConnection connection = new SqlConnection(conString);
                connection.Open();
                SqlCommand del = new SqlCommand("DELETE Sorts WHERE sort_id = @id", connection);
                del.Parameters.Add("@id", SqlDbType.Int).Value = dataGridView5.CurrentRow.Cells[0].Value;
                del.ExecuteNonQuery();
                connection.Close();

                connection.Open();
                DataTable grid = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter();
                SqlCommand gridUpd = new SqlCommand("SELECT * FROM Sorts", connection);
                adapt.SelectCommand = gridUpd;
                adapt.Fill(grid);
                dataGridView5.DataSource = grid;
                connection.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SortEdit se = new SortEdit();
            se.textBox5.Text = Convert.ToString(this.dataGridView5.CurrentRow.Cells[0].Value);
            se.textBox1.Text = Convert.ToString(this.dataGridView5.CurrentRow.Cells[1].Value);
            se.textBox2.Text = Convert.ToString(this.dataGridView5.CurrentRow.Cells[2].Value);
            se.textBox3.Text = Convert.ToString(this.dataGridView5.CurrentRow.Cells[3].Value);
            se.textBox4.Text = Convert.ToString(this.dataGridView5.CurrentRow.Cells[4].Value);
            se.Show();
            Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        private void button7_Click_1(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(textBox1.Text);
            try
            {
                SqlConnection connection = new SqlConnection(conString);
                connection.Open();

                DataTable upd = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();

                SqlCommand search = new SqlCommand("SELECT * FROM Order_component WHERE order_id = @id", connection);
                search.Parameters.Add("@id", SqlDbType.Int).Value = value;
                adapter.SelectCommand = search;
                adapter.Fill(upd);
                dataGridView3.DataSource = upd;

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            int index_client = comboBox2.SelectedIndex + 1;
            int index_sort = comboBox1.SelectedIndex;
            SqlConnection connection = new SqlConnection(conString);
            try
            {
                connection.Open();

                DataTable upd = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();

                switch (index_sort)
                {
                    case 0:
                        SqlCommand date_filter = new SqlCommand("SELECT order_id, date, client_id, sum FROM Orders WHERE client_id = @id ORDER BY Date", connection);
                        date_filter.Parameters.Add("@id", SqlDbType.Int).Value = index_client;

                        adapter.SelectCommand = date_filter;
                        adapter.Fill(upd);
                        dataGridView2.DataSource = upd;
                        break;
                    case 1:
                        SqlCommand date2_filter = new SqlCommand("SELECT order_id, date, client_id, sum FROM Orders WHERE client_id = @id ORDER BY Date DESC", connection);
                        date2_filter.Parameters.Add("@id", SqlDbType.Int).Value = index_client;

                        adapter.SelectCommand = date2_filter;
                        adapter.Fill(upd);
                        dataGridView2.DataSource = upd;
                        break;
                    case 2:
                        //order_id, date, client_id, sum

                        SqlCommand order_filter = new SqlCommand("SELECT order_id, date, client_id, sum FROM Orders WHERE client_id = @id ORDER BY order_id", connection);
                        order_filter.Parameters.Add("@id", SqlDbType.Int).Value = index_client;
                        adapter.SelectCommand = order_filter;
                        adapter.Fill(upd);
                        dataGridView2.DataSource = upd;

                        break;
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        { 
            try
            {
            string name = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand sort_id = new SqlCommand("SELECT sort_id FROM Products WHERE product_name = @product_name", connection);
            sort_id.Parameters.Add("@product_name", SqlDbType.NVarChar).Value = name;
            SqlCommand color = new SqlCommand("SELECT color FROM Sorts WHERE sort_id = @id", connection);
            SqlCommand alcochol = new SqlCommand("SELECT alcochol FROM Sorts WHERE sort_id = @id2", connection);
            SqlCommand sweetness = new SqlCommand("SELECT sweetness FROM Sorts WHERE sort_id = @id3", connection);
            SqlCommand sort_name = new SqlCommand("SELECT sort_name FROM Sorts WHERE sort_id = @id4", connection);

                color.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(sort_id.ExecuteScalar());
                alcochol.Parameters.Add("@id2", SqlDbType.Int).Value = Convert.ToInt32(sort_id.ExecuteScalar());
            sweetness.Parameters.Add("@id3", SqlDbType.Int).Value = Convert.ToInt32(sort_id.ExecuteScalar());
            sort_name.Parameters.Add("@id4", SqlDbType.Int).Value = Convert.ToInt32(sort_id.ExecuteScalar());
            //MessageBox.Show(Convert.ToString(name + " " + color.ExecuteScalar()+" " + alcochol.ExecuteScalar()+ " " + sweetness.ExecuteScalar() + " " + sort_name.ExecuteScalar()));
                ProductInf pi = new ProductInf(name, color, alcochol, sweetness, sort_name);
                pi.Show();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            InStock s = new InStock();
            s.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Income i = new Income();
            i.Show();
        }

        private void вийтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm f = new MainForm();
            f.Show();
            Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            const string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Vostro\source\repos\Brewery\Brewery\Brewery.mdf';Integrated Security=True";
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            DataTable grid5 = new DataTable();
           

            SqlDataAdapter adapt = new SqlDataAdapter();

            SqlCommand gridUpd5 = new SqlCommand("SELECT Order_component.product_name, COUNT(Order_component.product_name) AS amount FROM Order_component, Orders WHERE Order_component.order_id = Orders.order_id AND Orders.date BETWEEN @1date AND @2date GROUP BY Order_component.product_name ORDER BY amount DESC", connection);
            gridUpd5.Parameters.Add("@1date", SqlDbType.Date).Value = dateTimePicker1.Value;
            gridUpd5.Parameters.Add("@2date", SqlDbType.Date).Value = dateTimePicker2.Value;
            adapt.SelectCommand = gridUpd5;
            adapt.Fill(grid5);
            dataGridView6.DataSource = grid5;
            connection.Close();

            //SqlCommand gridUpd6 = new SqlCommand("SELECT client_id, COUNT(client_id) AS amount FROM Orders GROUP BY client_id ORDER BY amount DESC", connection);
            //adapt.SelectCommand = gridUpd6;
            //adapt.Fill(grid6);
            //dataGridView7.DataSource = grid6;
            //connection.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            const string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Vostro\source\repos\Brewery\Brewery\Brewery.mdf';Integrated Security=True";
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            DataTable grid6 = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter();

            SqlCommand gridUpd6 = new SqlCommand("SELECT client_id, COUNT(client_id) AS amount FROM Orders WHERE date BETWEEN @1date AND @2date GROUP BY client_id ORDER BY amount DESC", connection);
            gridUpd6.Parameters.Add("@1date", SqlDbType.Date).Value = dateTimePicker4.Value;
            gridUpd6.Parameters.Add("@2date", SqlDbType.Date).Value = dateTimePicker3.Value;
            adapt.SelectCommand = gridUpd6;
            adapt.Fill(grid6);
            dataGridView7.DataSource = grid6;
            connection.Close();
        }
    }
}
