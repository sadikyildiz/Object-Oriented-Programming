using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anonymousclasses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ogrenci = new
            {
                Numara = 35,
                Ad = "Yasin",
                Ortalama = 80.5
            };
            MessageBox.Show("Öğrencinin adı: " +ogrenci.Ad);
            //ogrenci.Ortalama = 90.2; HATA!!!
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ogrenci = new
            {
                Numara = 35,
                Ad = "Yasin",
                Ortalama = 80.5,
                Adres = new
                {
                    Il = "Ankra",
                    Ilce = "Yenimahalle"
                }
            };
            MessageBox.Show("Öğrencinin yaşadığı il/ilçe: " +ogrenci.Adres.Il+"/"+ogrenci.Adres.Ilce);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 x = new Form2();
            x.Show();
        }
    }
}
