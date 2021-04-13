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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
            
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "breweryDataSet14.Sorts". При необходимости она может быть перемещена или удалена.
            this.sortsTableAdapter1.Fill(this.breweryDataSet14.Sorts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "breweryDataSet13.Sorts". При необходимости она может быть перемещена или удалена.
            //this.sortsTableAdapter.Fill(this.breweryDataSet13.Sorts);

        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            try
            {
                const string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Vostro\source\repos\Brewery\Brewery\Brewery.mdf';Integrated Security=True";
                SqlConnection connection = new SqlConnection(conString);
                connection.Open();
                SqlCommand add = new SqlCommand("INSERT INTO Products ([product_name], [sort_id], [volume], [container], [in_stock], [price]) VALUES (@name, @sort, @volume, @container, @in_stock, @price)", connection);
                add.Parameters.Add("@name", SqlDbType.NVarChar).Value = imya.Text;
                add.Parameters.Add("@sort", SqlDbType.NVarChar).Value = Convert.ToInt32(Sort.Text);
                add.Parameters.Add("@volume", SqlDbType.Decimal).Value = Convert.ToDecimal(Volume.Text);
                add.Parameters.Add("@container", SqlDbType.NVarChar).Value = Tara.Text;
                add.Parameters.Add("@in_stock", SqlDbType.Int).Value = Convert.ToInt32(Amount.Text);
                add.Parameters.Add("@price", SqlDbType.Int).Value = Convert.ToInt32(Price2.Text);


                if (add.ExecuteNonQuery() == 1) MessageBox.Show(" Запись добавлена ");
                else MessageBox.Show(" Запись не добавлена ");
                connection.Close();
                AdminForm fr1 = new AdminForm();
                fr1.Show();
                Hide();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Будь ласка заповніть всі поля :)");
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
            AdminForm af = new AdminForm();
            af.tabControl1.SelectedIndex = 0;
            af.Show();
        }
    }
}
