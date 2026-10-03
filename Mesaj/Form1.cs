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

namespace Mesaj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=MESAJ;Integrated Security=True;");
        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from TBLKISILER WHERE NUMARA=@P1 AND SIFRE=@P2", baglanti);
            komut.Parameters.AddWithValue("@P1", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@P2", textBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form2 frm = new Form2();
                frm.numara = maskedTextBox1.Text;
                frm.Show();
            }
            else

            {
                MessageBox.Show("Hatalı Bilgi");
            }
            baglanti.Close();
        }
    }
}
