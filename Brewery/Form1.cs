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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int choice = 2;
            //if (textBox1.Text == "admin" && textBox2.Text == "1234") choice = 0;
            //else if (textBox1.Text == "user" && textBox2.Text == "1234") choice = 1;
            //switch (choice)
            //{
            ////    case 0:
            //AdminForm ad = new AdminForm();
            //ad.Show();
            //Hide();
            ////        break;
            //    case 1:
            //        UserForm add = new UserForm();
            //        add.Show();
            //        Hide();
            //        break;
            //    case 2:
            //        MessageBox.Show("Ви щось невірно ввели!)");
            //        break;
            //}
            //AdminForm af = new AdminForm();
            //int rows = af.dataGridView4.RowCount;
            //for (int i = 0; i <= rows; i++)
            //{
            //    if (textBox1.Text == Convert.ToString(af.dataGridView4.Rows[i].Cells[5].Value) && textBox2.Text == Convert.ToString(af.dataGridView4.Rows[i].Cells[6].Value))
            //    {
            //        UserForm uf = new UserForm();
            //        uf.Show();
            //        Hide();
            //    }
            //    else if (textBox1.Text == Convert.ToString(af.dataGridView4.Rows[i].Cells[5].Value) && textBox2.Text != Convert.ToString(af.dataGridView4.Rows[i].Cells[6].Value))
            //    {
            //        MessageBox.Show("Пароль невірний!");
            //    }
            //    else if (textBox1.Text != Convert.ToString(af.dataGridView4.Rows[i].Cells[5].Value) && textBox2.Text != Convert.ToString(af.dataGridView4.Rows[i].Cells[6].Value))
            //    {
            //        MessageBox.Show("Такого користувача немає, вам потрібно зареєструватися.");
            //    }
            //    else if (textBox1.Text == "admin" && textBox2.Text == "1234")
            //    {
            //        af.Show();
            //        Hide();
            //    }
            //    else if (textBox1.Text == "admin" && textBox2.Text != "1234")
            //    {
            //        MessageBox.Show("Пароль невірний!");
            //    }
            //}
            bool admin = false;
            string login = textBox1.Text;
            string password = textBox2.Text;

            if (login == "admin" && password == "12345")
            {
                admin = true;
                AdminForm af = new AdminForm();
                Hide();
                af.Show();
            }
            const string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Vostro\source\repos\Brewery\Brewery\Brewery.mdf';Integrated Security=True";
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable temp = new DataTable();
            SqlCommand check = new SqlCommand("SELECT client_id, login, password FROM Clients WHERE login = @login AND password = @password", connection);

            check.Parameters.Add("@login", SqlDbType.NVarChar).Value = login;
            check.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;

            adapter.SelectCommand = check;
            adapter.Fill(temp);

            if (temp.Rows.Count > 0)
            {
                int user = Convert.ToInt32(check.ExecuteScalar());

                MessageBox.Show("Вход выполнен");
                UserForm uf = new UserForm(user);
                uf.Show();
                Hide();

            }
            else if (!admin)
            {
                MessageBox.Show("Неверный логин и пароль");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
            Registration r = new Registration();
            r.Show();
            Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
