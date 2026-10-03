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

namespace Rehber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Rehber;Integrated Security=True;");

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from KISILER",baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void temizle()
        {
            TxtAd.Text = "";
            Txtid.Text = "";
            TxtMail.Text = "";
            TxtSoyad.Text = "";
            MskTelefon.Text = "";
            TxtAd.Focus();
        
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into KISILER (AD,SOYAD,TELEFON,MAIL) values (@P1,@P2,@P3,@P4)",baglanti);
            komut.Parameters.AddWithValue("@P1",TxtAd.Text);
            komut.Parameters.AddWithValue("@P2",TxtSoyad.Text);
            komut.Parameters.AddWithValue("@P3",MskTelefon.Text);
            komut.Parameters.AddWithValue("@P4",TxtMail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kişi Rehbere Eklendi");
            listele();
            temizle();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            Txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            MskTelefon.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtMail.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from KISILER where ID=" + Txtid.Text,baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kişi Rehberden Silindi");
            listele();
            temizle();


        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update KISILER set AD=@P1,SOYAD=@P2,TELEFON=@P3,MAIL=@P4 WHERE ID=@P5 ",baglanti);
            komut.Parameters.AddWithValue("@P1",TxtAd.Text);
            komut.Parameters.AddWithValue("@P2",TxtSoyad.Text);
            komut.Parameters.AddWithValue("@P3",MskTelefon.Text);
            komut.Parameters.AddWithValue("@P4",TxtMail.Text);
            komut.Parameters.AddWithValue("@P5",Txtid.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kişi Bilgisi Güncellendi");
            listele();
            temizle();

        }
    }
}

