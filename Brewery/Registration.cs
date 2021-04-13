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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            MainForm mf = new MainForm();
            mf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                const string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Vostro\source\repos\Brewery\Brewery\Brewery.mdf';Integrated Security=True";
                SqlConnection connection = new SqlConnection(conString);
                connection.Open();
                SqlCommand id = new SqlCommand("Select max(client_id) FROM Clients", connection);
                id.ExecuteNonQuery();
                int number;
                if (DBNull.Value.Equals(id.ExecuteScalar())) number = 1;
                else number = Convert.ToInt32(id.ExecuteScalar()) + 1;
                SqlCommand add = new SqlCommand("INSERT INTO Clients ([client_id], [company_name], [address], [phone], [email], [login], [password]) VALUES (@client_id, @company_name, @address, @phone, @email, @login, @password)", connection);
                add.Parameters.Add(@"client_id", SqlDbType.Int).Value = number;
                add.Parameters.Add("@company_name", SqlDbType.NVarChar).Value = textBox1.Text;
                add.Parameters.Add("@address", SqlDbType.NVarChar).Value = textBox2.Text;
                add.Parameters.Add("@phone", SqlDbType.NVarChar).Value = textBox3.Text;
                add.Parameters.Add("@email", SqlDbType.NVarChar).Value = textBox4.Text;
                add.Parameters.Add("@login", SqlDbType.NVarChar).Value = textBox5.Text;
                add.Parameters.Add("@password", SqlDbType.NVarChar).Value = textBox6.Text;


                if (add.ExecuteNonQuery() == 1) MessageBox.Show(" Ви зареєстровані! ");
                else MessageBox.Show(" Сталася помилка( ");
                connection.Close();
                MainForm fr1 = new MainForm();
                fr1.Show();
                Hide();

            }

            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }
    }
}
