using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OgrenciIslem oi = new OgrenciIslem();
            listBox1.Items.Add("1) ==========================");
            oi.OgrenciEkle(new Ogrenci
            {
                Numara = 100,
                AdSoyad = "Nihal Öz"
});
            listBox1.Items.Add("Öğrenci sayısı: " +OgrenciIslem.OgrenciSayisi);
            listBox1.Items.Add("2) ==========================");
            oi.OgrenciEkle(new Ogrenci
            {
                Numara = 200,
                AdSoyad = "İbrahim Yurt"
});
            listBox1.Items.Add("Öğrenci sayısı: " +OgrenciIslem.OgrenciSayisi);
            listBox1.Items.Add("3) ==========================");
            oi.OgrenciSil(100);
            listBox1.Items.Add("Öğrenci sayısı: " +OgrenciIslem.OgrenciSayisi);
        }
    }
}
