using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RSS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void hurriyetXml()
        {
            listBox1.Items.Clear();
            XmlTextReader xmloku = new XmlTextReader("https://www.hurriyet.com.tr/rss/anasayfa");
            while (xmloku.Read())
            {
                if (xmloku.Name == "title")
                {
                    listBox1.Items.Add(xmloku.ReadString());
                }

            }
        }
        void milliyetXml()
        {

            listBox1.Items.Clear();
            XmlTextReader xmloku2 = new XmlTextReader("http://www.milliyet.com.tr/rss/rssNew/SonDakikaRss.xml");
            while (xmloku2.Read())
            {
                if (xmloku2.Name == "title")
                {
                    listBox1.Items.Add(xmloku2.ReadString());
                }
            }
        }
        void fotomacXml()
        {

            listBox1.Items.Clear();
            XmlTextReader xmloku3 = new XmlTextReader("http://www.fotomac.com.tr/rss/anasayfa.xml");
            while (xmloku3.Read())
            {
                if (xmloku3.Name == "title")
                {
                    listBox1.Items.Add(xmloku3.ReadString());

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hurriyetXml();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            milliyetXml();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fotomacXml();
        }
    }
}
