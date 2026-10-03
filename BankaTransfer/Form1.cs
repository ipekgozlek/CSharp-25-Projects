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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DbBanka;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");


        private void Form1_Load(object sender, EventArgs e)
        {

        }

      
     

        private void LnkKayitOl_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }
        
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from TBLKISILER WHERE HESAPNO=@p1 and SIFRE=@p2",baglanti);
            komut.Parameters.AddWithValue("@p1",MSkHesapNo.Text);
            komut.Parameters.AddWithValue("@p2",TxtSifre.Text);
            SqlDataReader dr= komut.ExecuteReader();
            if (dr.Read())
            {
                Form2 fr = new Form2();
                fr.hesap = MSkHesapNo.Text;
                fr.Show();
            }
            else 
            {
                MessageBox.Show("Hatalı Bilgi");
            }
            baglanti.Close();
        }

    }
}
