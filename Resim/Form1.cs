using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string resim;
        private void BtnResimSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            resim = openFileDialog1.FileName;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Color renk;
        private void BtnRenkSec_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            renk = colorDialog1.Color;
        }
        Bitmap bmp; // bitmap , üzerinde değişiklik yapabileceğimiz uzantı
        private void BtnYazdir_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(resim);
            Graphics gr = Graphics.FromImage(bmp);
            gr.DrawString(TxtMetin.Text, new Font("Segoe UI", Convert.ToInt16(TxtBoyut.Text), FontStyle.Bold), new SolidBrush(renk), 20, 30);

            pictureBox1.Image = bmp;
            
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Resim Dosyası | *.jpg";
            saveFileDialog1.ShowDialog();
            bmp.Save(saveFileDialog1.FileName);
        }
    }
}
