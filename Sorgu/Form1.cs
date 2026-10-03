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

namespace Sorgu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(
            @"Data Source=.\SQLEXPRESS;Initial Catalog=DbOgrenciNot;Integrated Security=True;TrustServerCertificate=True;");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void Selectsorgu()
        {



            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBLNOTLAR", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;



        }

        private void button1_Click(object sender, EventArgs e)
        {

            string sorgu = richTextBox1.Text;


            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {

                MessageBox.Show("Sorgunuzu kontrol edin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = richTextBox1.Text;
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("İşlem gerçekleşti");
            Selectsorgu();
        }

    }
}
