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

namespace Sefer_Seyahat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=YolcuBilet;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLYOLCUBILGI (ad,soyad,telefon,tc,CINSIYET,MAIL) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);

            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskTelefon.Text);
            komut.Parameters.AddWithValue("@p4", MskTC.Text);
            komut.Parameters.AddWithValue("@p5", CmbCinsiyet.Text);
            komut.Parameters.AddWithValue("@p6", TxtMail.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Yolcu Bilgisi Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnKaptan_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into tblkaptan (kaptanno,adsoyad,telefon) values (@p1,@p2,@p3)", baglanti);

            komut.Parameters.AddWithValue("@p1", TxtKaptanNo.Text);
            komut.Parameters.AddWithValue("@p2", TxtKaptanAd.Text);
            komut.Parameters.AddWithValue("@p3", MskKaptanTelefon.Text);

            komut.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Kaptan Bilgisi Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void BtnSeferOlustur_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into TBLSEFERBILGI (KALKIS,VARIS,TARIH,SAAT,KAPTAN,FIYAT) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);

            komut.Parameters.AddWithValue("@p1", TxtKalkis.Text);
            komut.Parameters.AddWithValue("@p2", TxtVaris.Text);
            komut.Parameters.AddWithValue("@p3", MskTarih.Text);
            komut.Parameters.AddWithValue("@p4", MskSaat.Text);
            komut.Parameters.AddWithValue("@p5", MskKaptan.Text);
            komut.Parameters.AddWithValue("@p6", TxtFiyat.Text);

            komut.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Sefer Bilgisi Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBLSEFERBILGI",baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            TxtSeferNumara.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "9";
        }

        private void butBtnrezervasyonton4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLSEFERDETAY (SEFERNO,YOLCUTC,KOLTUK) VALUES(@P1,@P2,@P3)",baglanti);
            komut.Parameters.AddWithValue("@P1", TxtSeferNumara.Text);
            komut.Parameters.AddWithValue("@P2", MskYolcuTC.Text);
            komut.Parameters.AddWithValue("@P3", TxtKoltukNo.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Rezervasyon Yapıldı");
        }
    }
}
