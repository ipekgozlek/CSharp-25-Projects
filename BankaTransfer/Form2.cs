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

namespace BankaTransfer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DbBanka;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");

        public string hesap;
        

        private void Form2_Load(object sender, EventArgs e)
        {
            LblHesapNo.Text = hesap;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from TBLKISILER WHERE HESAPNO=@p1");
            komut.Parameters.AddWithValue("@p1",MSkHesapNo.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[1] + " " + dr[2];
                LblTc.Text = dr[3].ToString();
                LblTelefon.Text = dr[4].ToString();
            
            }
            baglanti.Close();
        }

        private void BtnGonder_Click(object sender, EventArgs e)
        {
            //gönderilen hesabın para artışı
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBLHESAP SET BAKIYE=BAKIYE+@p1 where HESAPNO=@p2",baglanti);
            komut.Parameters.AddWithValue("@p1",decimal.Parse(TxtTutar.Text)); //veri tabanında bakiyeyi decimal yaptım
            komut.Parameters.AddWithValue("@p2",MSkHesapNo.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
          

            //gönderen hesabın para azalışı
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("update TBLHESAP SET BAKIYE=BAKIYE-@k1 where HESAPNO=@k2", baglanti);
            komut2.Parameters.AddWithValue("@k1", decimal.Parse(TxtTutar.Text)); //veri tabanında bakiyeyi decimal yaptım
            komut2.Parameters.AddWithValue("@k2", hesap);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İşlem Gerçekleşti");

        }
    }
}
