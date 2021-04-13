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
using Word = Microsoft.Office.Interop.Word;


namespace Brewery
{
    public partial class Income : Form
    {
        public Income()
        {
            InitializeComponent();
            const string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Vostro\source\repos\Brewery\Brewery\Brewery.mdf';Integrated Security=True";
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            DataTable grid = new DataTable();
            DataTable price = new DataTable();

            SqlDataAdapter adapt = new SqlDataAdapter();

            SqlCommand gridUpd = new SqlCommand("SELECT ", connection);


            //gridUpd.Parameters.Add("@order_id", SqlDbType.Int).Value = order_id;
            adapt.SelectCommand = gridUpd;
            //adapt.Fill(grid);
            //dataGridView1.DataSource = grid;
            dataGridView1.Rows.Add(5);
            SqlCommand sept = new SqlCommand("SELECT SUM(Orders.sum) FROM Orders WHERE MONTH(Orders.date) = 9", connection);
            SqlCommand oct = new SqlCommand("SELECT SUM(Orders.sum) FROM Orders WHERE MONTH(Orders.date) = 10", connection);
            SqlCommand nov = new SqlCommand("SELECT SUM(Orders.sum) FROM Orders WHERE MONTH(Orders.date) = 11", connection);
            SqlCommand dec = new SqlCommand("SELECT SUM(Orders.sum) FROM Orders WHERE MONTH(Orders.date) = 12", connection);
            SqlCommand jan = new SqlCommand("SELECT SUM(Orders.sum) FROM Orders WHERE MONTH(Orders.date) = 1", connection);
            dataGridView1[0,0].Value = "09.2020";
            dataGridView1[0,1].Value = "10.2020";
            dataGridView1[0,2].Value = "11.2020";
            dataGridView1[0,3].Value = "12.2020";
            dataGridView1[0, 4].Value = "01.2021";
            dataGridView1[1,0].Value = sept.ExecuteScalar();
            dataGridView1[1,1].Value = oct.ExecuteScalar();
            dataGridView1[1,2].Value = nov.ExecuteScalar();
            dataGridView1[1,3].Value = dec.ExecuteScalar();
            dataGridView1[1, 4].Value = jan.ExecuteScalar();
        }
        private readonly string TemplateFileName = @"C:\Users\Vostro\source\repos\Brewery\Доходи.docx"; //место, где лежит шаблон документа
        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Сформулировать отчёт и распечатать?");
            string datenow = DateTime.Now.ToShortDateString();
            string month1 = dataGridView1[0, 0].Value.ToString();
            string month2 = dataGridView1[0, 1].Value.ToString();
            string month3 = dataGridView1[0, 2].Value.ToString();
            string month4 = dataGridView1[0, 3].Value.ToString();
            string month5 = dataGridView1[0, 4].Value.ToString();
            string sum1 = dataGridView1[1, 0].Value.ToString();
            string sum2 = dataGridView1[1, 1].Value.ToString();
            string sum3 = dataGridView1[1, 2].Value.ToString();
            string sum4 = dataGridView1[1, 3].Value.ToString();
            string sum5 = dataGridView1[1, 4].Value.ToString();


            var wordApp = new Word.Application();
            wordApp.Visible = false;

            var wordDocument = wordApp.Documents.Open(TemplateFileName);
            ReplaceWords("{datenow}", datenow, wordDocument);
            ReplaceWords("{month1}", month1, wordDocument);
            ReplaceWords("{month2}", month2, wordDocument);
            ReplaceWords("{month3}", month3, wordDocument);
            ReplaceWords("{month4}", month4, wordDocument);
            ReplaceWords("{month5}", month5, wordDocument);
            ReplaceWords("{sum1}", sum1, wordDocument);
            ReplaceWords("{sum2}", sum2, wordDocument);
            ReplaceWords("{sum3}", sum3, wordDocument);
            ReplaceWords("{sum4}", sum4, wordDocument);
            ReplaceWords("{sum5}", sum5, wordDocument);

            wordDocument.SaveAs(@"C:\Users\Vostro\source\repos\Brewery\res.docx"); //место, куда сохранять

            wordApp.Visible = true;
        }
        private void ReplaceWords(string toReplace, string text, Word.Document doc)
        {
            var range = doc.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: toReplace, ReplaceWith: text);
        }

        private void Income_Load(object sender, EventArgs e)
        {

        }
    }
}
