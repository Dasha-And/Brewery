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
    public partial class ProductInf : Form
    {

        public ProductInf(string n, SqlCommand c, SqlCommand a, SqlCommand s, SqlCommand sn)
        {
            InitializeComponent();

            label1.Text = n;
            label7.Text = c.ExecuteScalar().ToString();
            label8.Text = a.ExecuteScalar().ToString();
            label9.Text = s.ExecuteScalar().ToString();
            label10.Text = sn.ExecuteScalar().ToString();

        }

        private void ProductInf_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
