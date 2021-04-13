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
    public partial class MyOrder : Form
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Vostro\source\repos\Brewery\Brewery\Brewery.mdf';Integrated Security=True";
        int user;
        public MyOrder(List<string> massiv, int userid, List<int> amount)
        {
            InitializeComponent();
            user = userid;
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            SqlCommand id = new SqlCommand("SELECT max(order_id) FROM Order_component", conn);
            id.ExecuteNonQuery();
            int order_id;
            if (DBNull.Value.Equals(id.ExecuteScalar())) order_id = 1;
            else order_id = Convert.ToInt32(id.ExecuteScalar()) + 1;            
            int count = 0;
            for (int j = 0; j < massiv.Count; j++)
            {
                dataGridView1.Rows.Add(massiv[count++], order_id.ToString());
                Label l = new Label();
                l.Text = dataGridView1.Rows[j].Cells[0].Value.ToString();
                l.Location = new System.Drawing.Point(70, 20);
            }           
            
        }

        private void MyOrder_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "breweryDataSet6.Order_component". При необходимости она может быть перемещена или удалена.
            //this.order_componentTableAdapter.Fill(this.breweryDataSet6.Order_component);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection conn = new SqlConnection(connection);
                conn.Open();
                bool complete = false;
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    SqlCommand checkcount = new SqlCommand("SELECT in_stock FROM Products WHERE product_name = @product_name", conn);
                    checkcount.Parameters.Add("@product_name", SqlDbType.NVarChar).Value = dataGridView1[0, i].Value.ToString();
                    if(Convert.ToInt32(checkcount.ExecuteScalar()) >= Convert.ToInt32(dataGridView1[2, i].Value))
                    {
                        SqlCommand count = new SqlCommand("UPDATE Products SET in_stock = @amount WHERE product_name = @product_name", conn);
                        count.Parameters.Add("@product_name", SqlDbType.NVarChar).Value = dataGridView1[0, i].Value.ToString();
                        count.Parameters.Add("@amount", SqlDbType.Int).Value = Convert.ToInt32(checkcount.ExecuteScalar()) - Convert.ToInt32(dataGridView1[2, i].Value);
                        count.ExecuteNonQuery();
                        
                        complete = true;
                        
                    }
                    else
                    {
                        MessageBox.Show("В нас нема стільки пива!");
                        complete = false;
                    }

                }
                if (complete) {
                    Add_order_component(dataGridView1);
                    Add_order(dataGridView1);
                    MessageBox.Show("Замовлення здійснено. Ви можете переглянути його в 'Мої замовлення'.");
                } 

            }

            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
             
            UserForm uf = new UserForm(user);
             
            uf.Show();

            Hide();
           

}
    public void Add_order_component(DataGridView dataGridView1)
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Vostro\source\repos\Brewery\Brewery\Brewery.mdf';Integrated Security=True";
        try
        {
            int amount = dataGridView1.RowCount - 1;
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            SqlCommand id = new SqlCommand("SELECT max(number) FROM Order_component", conn);
            id.ExecuteNonQuery();
            int number;
            if (DBNull.Value.Equals(id.ExecuteScalar())) number = 1;
            else number = Convert.ToInt32(id.ExecuteScalar()) + 1;
            for (int i = 0; i < amount; i++)
            {
                SqlCommand add = new SqlCommand("INSERT INTO Order_component ([number], [product_name], [order_id], [amount]) VALUES (@number, @product_name, @order_id, @amount)", conn);
                add.Parameters.Add(@"number", SqlDbType.Int).Value = number;
                add.Parameters.Add("@product_name", SqlDbType.NVarChar).Value = dataGridView1.Rows[i].Cells[0].Value;
                add.Parameters.Add("@order_id", SqlDbType.Int).Value = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                add.Parameters.Add("@amount", SqlDbType.Int).Value = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                add.ExecuteNonQuery();
                number++;

            }


        }

        catch (Exception ex)
        {
            MessageBox.Show(@"Error: " + ex.Message);
        }
    }
        public void Add_order(DataGridView dataGridView1)
        {
            string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Vostro\source\repos\Brewery\Brewery\Brewery.mdf';Integrated Security=True";
            try
            {
                int amount = dataGridView1.RowCount - 1;
                SqlConnection conn = new SqlConnection(connection);
                conn.Open();
                SqlCommand id = new SqlCommand("SELECT max(order_id) FROM Orders", conn);

                id.ExecuteNonQuery();
                int number;
                if (DBNull.Value.Equals(id.ExecuteScalar())) number = 1;
                else number = Convert.ToInt32(id.ExecuteScalar()) + 1;
                SqlCommand add = new SqlCommand("INSERT INTO Orders ([order_id], [date], [client_id], [sum]) VALUES ( @order_id, @date, @client_id, @sum)", conn);
                add.Parameters.Add("@order_id", SqlDbType.Int).Value = number;
                add.Parameters.Add("@date", SqlDbType.Date).Value = Convert.ToDateTime(DateTime.Today);
                add.Parameters.Add("@client_id", SqlDbType.Int).Value = user;
                int sum = 0;
                for (int i = 0; i < amount; i++)
                {
                    SqlCommand amount1 = new SqlCommand("SELECT amount FROM Order_component WHERE product_name = @p ORDER BY number DESC", conn);
                    SqlCommand price1 = new SqlCommand("SELECT price FROM Products WHERE product_name = @n", conn);
                    price1.Parameters.Add("@n", SqlDbType.NVarChar).Value = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    amount1.Parameters.Add("@p", SqlDbType.NVarChar).Value = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    price1.ExecuteNonQuery();
                    amount1.ExecuteNonQuery();
                    sum += Convert.ToInt32(amount1.ExecuteScalar()) * Convert.ToInt32(price1.ExecuteScalar());

                }
                add.Parameters.Add("@sum", SqlDbType.Int).Value = sum;
                add.ExecuteNonQuery();



                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }
    }
    
}
