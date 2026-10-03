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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=MESAJ;Integrated Security=True;");

        public string numara;

        void gelenkutusu()
        {
            SqlDataAdapter da1 = new SqlDataAdapter("Select * from TBLMESAJLAR WHERE ALICI=" + numara,baglanti);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

        
        }
        void gidenkutusu()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("Select * from TBLMESAJLAR WHERE GONDEREN=" + numara, baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;


        }
        private void Form2_Load(object sender, EventArgs e)
        {
            LblNumara.Text = numara;
            gelenkutusu();
            gidenkutusu();

            // Ad Soyadı Çekme

            baglanti.Open();
            SqlCommand komut= new SqlCommand("Select AD,SOYAD from TBLKISILER WHERE numara=" +numara ,baglanti);
            SqlDataReader dr= komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0] + "" + dr[1];

            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLMESAJLAR (ALICI,BASLIK,ICERIK,GONDEREN) values (@P1,@P2,@P3,@P4)",baglanti);
            komut.Parameters.AddWithValue("@P1", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@P2", textBox1.Text);
            komut.Parameters.AddWithValue("@P3", richTextBox1.Text);
            komut.Parameters.AddWithValue("@P4", numara);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Mesajınız Gönderildi");
            gidenkutusu();
        }
    }
}
