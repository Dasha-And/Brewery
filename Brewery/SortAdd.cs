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
    public partial class SortAdd : Form
    {
        public SortAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                const string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Vostro\source\repos\Brewery\Brewery\Brewery.mdf';Integrated Security=True";
                SqlConnection connection = new SqlConnection(conString);
                connection.Open();
                SqlCommand id = new SqlCommand("Select max(sort_id) FROM Sorts", connection);
                id.ExecuteNonQuery();
                int number;
                if (DBNull.Value.Equals(id.ExecuteScalar())) number = 1;
                else number = Convert.ToInt32(id.ExecuteScalar()) + 1;
                SqlCommand add = new SqlCommand("INSERT INTO Sorts ([sort_id], [alcochol], [color], [sweetness], [sort_name]) VALUES (@sort_id, @alcochol, @color, @sweetness, @sort_name)", connection);
                add.Parameters.Add(@"sort_id", SqlDbType.Int).Value = number;
                add.Parameters.Add("@alcochol", SqlDbType.Decimal).Value = Convert.ToDecimal(textBox1.Text);
                add.Parameters.Add("@color", SqlDbType.NVarChar).Value = textBox2.Text;
                add.Parameters.Add("@sweetness", SqlDbType.NVarChar).Value = textBox3.Text;
                add.Parameters.Add("@sort_name", SqlDbType.NVarChar).Value = textBox4.Text;


                if (add.ExecuteNonQuery() == 1) MessageBox.Show(" Запись добавлена ");
                else MessageBox.Show(" Запись не добавлена ");
                connection.Close();
                AdminForm fr1 = new AdminForm();
                fr1.tabControl1.SelectedIndex = 4;
                fr1.Show();
                Hide();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Будь ласка заповніть всі поля :)");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            AdminForm af = new AdminForm();
            af.Show();
        }
    }
}
