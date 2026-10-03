using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BankaTransfer
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DbBanka;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");


        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLKISILER (Ad,Soyad,TC,Telefon,HesapNo,Sıfre) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1",TxtAd.Text);
            komut.Parameters.AddWithValue("@p2",TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3",MskTC.Text);
            komut.Parameters.AddWithValue("@p4",MskTelefon.Text);
            komut.Parameters.AddWithValue("@p5",MskHesapNo.Text);
            komut.Parameters.AddWithValue("@p6",TxtSifre.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Bilgileri Sisteme Kaydedildi");
                
    }

        private void BtnHesapNo_Click(object sender, EventArgs e)
        {
            Random rastegele= new Random();
            int sayi = rastegele.Next(100000,1000000);
            MskHesapNo.Text=sayi.ToString();
        }
    }
}
