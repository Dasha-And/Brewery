using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;
using iTextSharp.text.pdf;
using System.IO;
using Word = Microsoft.Office.Interop.Word;

namespace Brewery
{
    public partial class Check : Form
    {
        int user;
        int order_id;
        int sum;
        DateTime date;
        public Check(int id, int oid, int s, DateTime d)
        {

            InitializeComponent();
            order_id = oid; 
            user = id;
            sum = s;
            date = d;
            label2.Text = order_id.ToString();
            label9.Text = sum.ToString();
            label8.Text = date.ToString("dd/MM/yyyy");
            const string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Vostro\source\repos\Brewery\Brewery\Brewery.mdf';Integrated Security=True";
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            DataTable grid = new DataTable();
            DataTable price = new DataTable();

            SqlDataAdapter adapt = new SqlDataAdapter();

            SqlCommand gridUpd = new SqlCommand("SELECT product_name,amount FROM Order_component WHERE order_id = @order_id", connection);
           

            gridUpd.Parameters.Add("@order_id", SqlDbType.Int).Value = order_id;
            adapt.SelectCommand = gridUpd;
            adapt.Fill(grid);

            dataGridView1.DataSource = grid;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Check_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "breweryDataSet21.Order_component". При необходимости она может быть перемещена или удалена.
            this.order_componentTableAdapter.Fill(this.breweryDataSet21.Order_component);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // отправитель - устанавливаем адрес и отображаемое в письме имя
                MailAddress from = new MailAddress("dosados69@gmail.com", "Пивоварня");
                // кому отправляем
                MailAddress to = new MailAddress("dariia.andriushchenko@nure.ua");
                // создаем объект сообщения
                MailMessage m = new MailMessage(from, to);
                // тема письма
                m.Subject = "Ваше замовлення";
                // текст письма
                m.Body = "<h2>Добрий день! Це чек вашого замовлення.</h2>";
                m.Attachments.Add(new Attachment(@"C:\Users\Vostro\source\repos\Brewery\res2.docx"));
                // письмо представляет код html
                m.IsBodyHtml = true;
                // адрес smtp-сервера и порт, с которого будем отправлять письмо
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                // логин и пароль
                smtp.Credentials = new NetworkCredential("dosados69@gmail.com", "qwartpast2015");
                smtp.EnableSsl = true;
                smtp.Send(m);
                MessageBox.Show("Лист надіслано на вашу пошту.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private readonly string TemplateFileName1 = @"C:\Users\Vostro\source\repos\Brewery\Чек1.docx";
        private readonly string TemplateFileName2 = @"C:\Users\Vostro\source\repos\Brewery\Чек22.docx";
        private readonly string TemplateFileName3 = @"C:\Users\Vostro\source\repos\Brewery\Чек3.docx";
        private readonly string TemplateFileName4 = @"C:\Users\Vostro\source\repos\Brewery\Чек4.docx";
        private void button1_Click(object sender, EventArgs e)
        {
            
            int rows = dataGridView1.RowCount - 1;
            if (rows == 1)
            {
                var wordApp = new Word.Application();
                wordApp.Visible = false;
                var wordDocument = wordApp.Documents.Open(TemplateFileName1);
                string product1 = dataGridView1[0, 0].Value.ToString();
                string amount1 = dataGridView1[1, 0].Value.ToString();
                string date = label8.Text;
                string number = label2.Text;
                string sum = label9.Text;
                ReplaceWords("{date}", date, wordDocument);
                ReplaceWords("{product1}", product1, wordDocument);
                ReplaceWords("{amount1}", amount1, wordDocument);
                ReplaceWords("{number}", number, wordDocument);
                ReplaceWords("{sum}", sum, wordDocument);
                wordDocument.SaveAs(@"C:\Users\Vostro\source\repos\Brewery\res2.docx"); //место, куда сохранять
                wordApp.Visible = true;
            }
            else if (rows == 2)
            {
                var wordApp = new Word.Application();
                wordApp.Visible = false;
                
                string product1 = dataGridView1[0, 0].Value.ToString();
                string product2 = dataGridView1[0, 1].Value.ToString();
                string amount1 = dataGridView1[1, 0].Value.ToString();
                string amount2 = dataGridView1[1, 1].Value.ToString();
                string date = label8.Text;
                string number = label2.Text;
                string sum = label9.Text;
                var wordDocument = wordApp.Documents.Open(TemplateFileName2);
                ReplaceWords("{date}", date, wordDocument);
                ReplaceWords("{product1}", product1, wordDocument);
                ReplaceWords("{product2}", product2, wordDocument);
                ReplaceWords("{amount1}", amount1, wordDocument);
                ReplaceWords("{amount2}", amount2, wordDocument);
                ReplaceWords("{number}", number, wordDocument);
                ReplaceWords("{sum}", sum, wordDocument);
                wordDocument.SaveAs(@"C:\Users\Vostro\source\repos\Brewery\res2.docx"); //место, куда сохранять
                wordApp.Visible = true;
            }
            else if (rows == 3)
            {
                var wordApp = new Word.Application();
                wordApp.Visible = false;
                var wordDocument = wordApp.Documents.Open(TemplateFileName3);
                string product1 = dataGridView1[0, 0].Value.ToString();
                string product2 = dataGridView1[0, 1].Value.ToString();
                string amount1 = dataGridView1[1, 0].Value.ToString();
                string amount2 = dataGridView1[1, 1].Value.ToString();
                string product3 = dataGridView1[0, 2].Value.ToString();
                string amount3 = dataGridView1[1, 2].Value.ToString();
                string date = label8.Text;
                string number = label2.Text;
                string sum = label9.Text;
                ReplaceWords("{date}", date, wordDocument);
                ReplaceWords("{product1}", product1, wordDocument);
                ReplaceWords("{product2}", product2, wordDocument);
                ReplaceWords("{amount1}", amount1, wordDocument);
                ReplaceWords("{amount2}", amount2, wordDocument);
                ReplaceWords("{product3}", product3, wordDocument);
                ReplaceWords("{amount3}", amount3, wordDocument);
                ReplaceWords("{number}", number, wordDocument);
                ReplaceWords("{sum}", sum, wordDocument);
                wordDocument.SaveAs(@"C:\Users\Vostro\source\repos\Brewery\res2.docx"); //место, куда сохранять
                wordApp.Visible = true;
            }
            //MessageBox.Show("Сформулировать отчёт и распечатать?");
            

        }
        private void ReplaceWords(string toReplace, string text, Word.Document doc)
        {
            var range = doc.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: toReplace, ReplaceWith: text);
        }
    }
}
