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
    public partial class SortEdit : Form
    {
        public SortEdit()
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
                SqlCommand update = new SqlCommand("UPDATE Sorts SET sort_id = @sort_id, alcochol = @alcochol, color = @color, sweetness = @sweetness, sort_name = @sort_name WHERE sort_id = @sort_id", connection);
                update.Parameters.Add(@"sort_id", SqlDbType.Int).Value = Convert.ToInt32(textBox5.Text);
                update.Parameters.Add("@alcochol", SqlDbType.NVarChar).Value = textBox1.Text;
                update.Parameters.Add("@color", SqlDbType.NVarChar).Value = textBox2.Text;
                update.Parameters.Add("@sweetness", SqlDbType.NVarChar).Value = textBox3.Text;
                update.Parameters.Add("@sort_name", SqlDbType.NVarChar).Value = textBox4.Text;

                if (update.ExecuteNonQuery() == 1) MessageBox.Show(" Запись добавлена ");
                else MessageBox.Show(" Запись не добавлена ");
                connection.Close();
                AdminForm fr1 = new AdminForm();
                fr1.tabControl1.SelectedIndex = 4;

                fr1.Show();
                Hide();
            }

            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
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
