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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ogrenciler = new[]
            {
                new { Numara = 100, Ad = "Özlem", Ortalama = 80},
                new { Numara = 200, Ad = "Barış", Ortalama = 75},
                new { Numara = 300, Ad = "Deniz", Ortalama = 90}
            };

            listBox1.Items.Add("2.öğrencinin adı: " +ogrenciler[1].Ad);
            listBox1.Items.Add("=====================");
            foreach (var ogrenci in ogrenciler)
            {
                listBox1.Items.Add($"Adı: {ogrenci.Ad}, Ortalaması: {ogrenci.Ortalama}");
            }


        }
    }
}
