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
    public partial class Profile : Form
    {
        int user;
        public Profile(int idU)
        {
            InitializeComponent();
            user = idU;
            try
            {
                const string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Vostro\source\repos\Brewery\Brewery\Brewery.mdf';Integrated Security=True";
                SqlConnection connection = new SqlConnection(conString);
                connection.Open();

                SqlCommand client_id = new SqlCommand("SELECT client_id FROM Clients WHERE client_id = @id", connection);
                SqlCommand company_name = new SqlCommand("SELECT company_name FROM Clients WHERE client_id = @id", connection);
                SqlCommand address = new SqlCommand("SELECT address FROM Clients WHERE client_id = @id", connection);
                SqlCommand phone = new SqlCommand("SELECT phone FROM Clients WHERE client_id = @id", connection);
                SqlCommand email = new SqlCommand("SELECT email FROM Clients WHERE client_id = @id", connection);
                SqlCommand login = new SqlCommand("SELECT login FROM Clients WHERE client_id = @id", connection);


                client_id.Parameters.Add("@id", SqlDbType.Int).Value = user;
                company_name.Parameters.Add("@id", SqlDbType.NVarChar).Value = user;
                address.Parameters.Add("@id", SqlDbType.NVarChar).Value = user;
                phone.Parameters.Add("@id", SqlDbType.NVarChar).Value = user;
                email.Parameters.Add("@id", SqlDbType.NVarChar).Value = user;
                login.Parameters.Add("@id", SqlDbType.NVarChar).Value = user;


                client_id.ExecuteNonQuery();
                company_name.ExecuteNonQuery();
                address.ExecuteNonQuery();
                phone.ExecuteNonQuery();
                email.ExecuteNonQuery();
                login.ExecuteNonQuery();

                label1.Text = Convert.ToString(company_name.ExecuteScalar());
                label7.Text = Convert.ToString(address.ExecuteScalar());
                label8.Text = Convert.ToString(phone.ExecuteScalar());
                label9.Text = Convert.ToString(email.ExecuteScalar());
                label10.Text = Convert.ToString(login.ExecuteScalar());
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserForm uf = new UserForm(user);
            uf.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Order o = new Order(user);
            o.Show();
            Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
