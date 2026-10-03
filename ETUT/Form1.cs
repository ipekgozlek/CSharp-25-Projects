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
using System.IO;

namespace ETUT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti= new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=ETUT;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        void dersListesi()
        { 
          SqlDataAdapter da= new SqlDataAdapter("Select * from TBLDERSLER",baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbDers.ValueMember = "DERSID";
            CmbDers.DisplayMember = "DERSAD";
            CmbDers.DataSource = dt;
        
        }
        void etutlistesi()
        {
            SqlDataAdapter da3 = new SqlDataAdapter("execute Etut",baglanti);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dersListesi();
            etutlistesi();

        }

        private void CmbDers_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da2 = new SqlDataAdapter("Select * from TBLOGRETMEN WHERE BRANSID="+ CmbDers.SelectedValue,baglanti);
            DataTable dt2= new DataTable();
            da2.Fill(dt2);
            CmbOgretmen.ValueMember = "OGRTID";
            CmbOgretmen.DisplayMember = "AD";
            CmbOgretmen.DataSource = dt2;



        }

        private void BtnEtutOlustur_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLETUT (DERSID,OGRETMENID,TARIH,SAAT) values (@p1,@p2,@p3,@p4)",baglanti);
            komut.Parameters.AddWithValue("@p1",CmbDers.SelectedValue);
            komut.Parameters.AddWithValue("@p2",CmbOgretmen.SelectedValue);
            komut.Parameters.AddWithValue("@p3",MskTarih.Text);
            komut.Parameters.AddWithValue("@p4",MskSaat.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Etüt Oluşturuldu", "Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            textBox2.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();        }

        private void BtnEtutVer_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBLETUT SET OGRENCIID=@p1,DURUM=@p2 where ID=@p3",baglanti);
            komut.Parameters.AddWithValue("@p1",textBox1.Text);
            komut.Parameters.AddWithValue("@p2","True");
            komut.Parameters.AddWithValue("@p3",textBox1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Etüt Öğrenciye Verildi");
        }

        private void BtnFotoğraf_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void BtnOgrenciEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into tblogrenci (ad,soyad,fotograf,sinif,telefon,mail) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);

            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", pictureBox1.ImageLocation);
            komut.Parameters.AddWithValue("@p4", TxtSınıf.Text);
            komut.Parameters.AddWithValue("@p5", MskTelefon.Text);
            komut.Parameters.AddWithValue("@p6", TxtMail.Text);

            komut.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Ögrenci Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        

    }
    }
}
