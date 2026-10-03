using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maliyet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Maliyet;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");


        void MalzemeListe()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBLMALZEMELER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        void UrunListesi()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("Select * from TBLURUNLER", baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;

        }

        void Kasa()
        {
            SqlDataAdapter da3 = new SqlDataAdapter("Select * from TBLKASA", baglanti);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;
        }

        void Urunler()
        {
            baglanti.Open();

            SqlDataAdapter da = new SqlDataAdapter("Select * From TblUrunler", baglanti);
            DataTable dt = new DataTable();

            da.Fill(dt);

            CmbUrun.ValueMember = "URUNID";
            CmbUrun.DisplayMember = "AD";
            CmbUrun.DataSource = dt;

            baglanti.Close();

        }
        void Malzemeler()
        {
            baglanti.Open();

            SqlDataAdapter da = new SqlDataAdapter("Select * From TblMalzemeler", baglanti);
            DataTable dt = new DataTable();

            da.Fill(dt);

            CmbMalzeme.ValueMember = "MALZEMEID";
            CmbMalzeme.DisplayMember = "AD";
            CmbMalzeme.DataSource = dt;

            baglanti.Close();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            MalzemeListe();
            Urunler();
            Malzemeler();
        }

        private void BtnUrunListesi_Click(object sender, EventArgs e)
        {
            UrunListesi();

        }

        private void BtnMalzemeListesi_Click(object sender, EventArgs e)
        {
            MalzemeListe();
        }

        private void BtnKasa_Click(object sender, EventArgs e)
        {
            Kasa();
        }

        private void BtnMalzemeEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLMALZEMELER (AD,STOK,FIYAT,NOTLAR) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtMalzemeAd.Text);
            komut.Parameters.AddWithValue("@p2", int.Parse(TxtMalzemeStok.Text));
            komut.Parameters.AddWithValue("@p3", decimal.Parse(TxtMalFiyat.Text));
            komut.Parameters.AddWithValue("@p4", TxtMalzemeNot.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Malzeme başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MalzemeListe();
        }

        private void BtnUrunEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into TBLURUNLER (AD,MFIYAT,SFIYAT,STOK) values (@p1,@p2,@p3,@p4)", baglanti);
            komut2.Parameters.AddWithValue("@p1", TxtUrunAd.Text);
            komut2.Parameters.AddWithValue("@p2", decimal.Parse(TxtUrunMFiyat.Text));
            komut2.Parameters.AddWithValue("@p3", decimal.Parse(TxtUrunSFiyat.Text));
            komut2.Parameters.AddWithValue("@p4", int.Parse(TxtUrunStok.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UrunListesi();
        }

        private void BtnUrunOlustur_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand(
                "insert into tblfırın (URUNID,MALZEMEID,MIKTAR,MALIYET) values (@p1,@p2,@p3,@p4)",
                baglanti);

            komut.Parameters.AddWithValue("@p1", CmbUrun.SelectedValue);
            komut.Parameters.AddWithValue("@p2", CmbMalzeme.SelectedValue);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(TxtMiktar.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(TxtMaliyet.Text));

            komut.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Malzeme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TxtMiktar_TextChanged(object sender, EventArgs e)
        {
            double maliyet;
            if (TxtMiktar.Text == "")
            {
                TxtMiktar.Text = "0";

            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand( "Select * From tblmalzemeler where MALZEMEID=@p1", baglanti);

            komut.Parameters.AddWithValue("@p1", CmbMalzeme.SelectedValue);

            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                TxtMiktar.Text = dr[3].ToString();
            }

            baglanti.Close();
            maliyet = Convert.ToDouble(TxtMaliyet.Text) / 1000 * Convert.ToDouble(TxtMiktar.Text);

            TxtMaliyet.Text = maliyet.ToString();
        }

        private void CmbMalzeme_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            TxtUrunID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtUrunAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            baglanti.Open();

            SqlCommand komut = new SqlCommand( "Select sum(Maliyet) from TBLFIRIN where URUNID=@p1",  baglanti);

            komut.Parameters.AddWithValue("@p1", TxtUrunID.Text);

            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                TxtUrunMFiyat.Text = dr[0].ToString();
            }

            baglanti.Close();
        }
    }
}
