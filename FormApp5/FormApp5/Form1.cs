using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)   // Hesap sekmesi
            {
                textBox4.Clear();

                // Müşteri Bilgileri
                textBox4.Text += "MÜŞTERİ BİLGİLERİ\r\n";
                textBox4.Text += "--------------------------\r\n";
                textBox4.Text += "Ad Soyad : " + textBox1.Text + "\r\n";
                textBox4.Text += "Telefon  : " + textBox2.Text + "\r\n";
                textBox4.Text += "Adres    : " + textBox3.Text + "\r\n\n";

                decimal hesap = 0;

                textBox4.Text += "SİPARİŞ DETAYI\r\n";
                textBox4.Text += "--------------------------\r\n";

                // Çorba (12 TL)
                if (numericUpDown1.Value > 0)
                {
                    decimal tutar = numericUpDown1.Value * 12;
                    hesap += tutar;
                    textBox4.Text += "Çorba x " + numericUpDown1.Value + " = " + tutar.ToString("C") + "\r\n";
                }

                // Salata (10 TL)
                if (numericUpDown2.Value > 0)
                {
                    decimal tutar = numericUpDown2.Value * 10;
                    hesap += tutar;
                    textBox4.Text += "Salata x " + numericUpDown2.Value + " = " + tutar.ToString("C") + "\r\n";
                }

                // Ana Yemek (25 TL)
                if (numericUpDown3.Value > 0)
                {
                    decimal tutar = numericUpDown3.Value * 25;
                    hesap += tutar;
                    textBox4.Text += "Ana Yemek x " + numericUpDown3.Value + " = " + tutar.ToString("C") + "\r\n";
                }

                // Tatlı (8 TL)
                if (numericUpDown4.Value > 0)
                {
                    decimal tutar = numericUpDown4.Value * 8;
                    hesap += tutar;
                    textBox4.Text += "Tatlı x " + numericUpDown4.Value + " = " + tutar.ToString("C") + "\r\n";
                }

                textBox4.Text += "--------------------------\r\n";
                textBox4.Text += "TOPLAM = " + hesap.ToString("C");
            }
        }
    }
}
