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
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            try
            {
                const string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Vostro\source\repos\Brewery\Brewery\Brewery.mdf';Integrated Security=True";
                SqlConnection connection = new SqlConnection(conString);
                connection.Open();
                SqlCommand update = new SqlCommand("UPDATE Products SET sort_id = @sort, volume = @volume, container = @container, in_stock = @in_stock, price = @price WHERE product_name = @name", connection);
                update.Parameters.Add("@name", SqlDbType.NVarChar).Value = textBox1.Text;
                update.Parameters.Add("@sort", SqlDbType.NVarChar).Value = Convert.ToInt32(Sort.Text);
                update.Parameters.Add("@volume", SqlDbType.NChar).Value = Volume.Text;
                update.Parameters.Add("@container", SqlDbType.NVarChar).Value = Tara.Text;
                update.Parameters.Add("@in_stock", SqlDbType.Int).Value = Convert.ToInt32(Amount.Text);
                update.Parameters.Add("@price", SqlDbType.Int).Value = Convert.ToInt32(Price2.Text);

                if (update.ExecuteNonQuery() == 1) MessageBox.Show(" Запись добавлена ");
                else MessageBox.Show(" Запись не добавлена ");
                connection.Close();
                AdminForm fr1 = new AdminForm();

                fr1.Show();
                Hide();
            }

            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "breweryDataSet22.Sorts". При необходимости она может быть перемещена или удалена.
            this.sortsTableAdapter3.Fill(this.breweryDataSet22.Sorts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "breweryDataSet16.Sorts". При необходимости она может быть перемещена или удалена.
            this.sortsTableAdapter2.Fill(this.breweryDataSet16.Sorts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "breweryDataSet15.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.breweryDataSet15.Products);

        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
            AdminForm af = new AdminForm();
            af.Show();
        }
    }
}
