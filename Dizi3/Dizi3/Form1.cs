using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dizi3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] sayilar = new int[5]; //Global Dizi
        int index = 0; //Global Değişken
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sayilar[index] = Convert.ToInt32(textBox1.Text);
                index++;
            }
            catch
            {
                MessageBox.Show("Hatalı Giriş Yaptınız");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (int sayi in sayilar)
            {
                listBox1.Items.Add(sayi);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = 0;
            a=sayilar.Length;
            textBox2.Text=a.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = 0;
            a = sayilar.Rank;
            textBox2.Text = a.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = 0;
            a = sayilar.Max();
            textBox2.Text = a.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int a = 0;
            a = sayilar.Min();
            textBox2.Text = a.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int a = 0;
            a = sayilar.Sum();
            textBox2.Text = a.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double a = 0;
            a = sayilar.Average();
            textBox2.Text = a.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int a = 0;
            a = sayilar.First();
            textBox2.Text = a.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int a = 0;
            a = sayilar.Last();
            textBox2.Text = a.ToString();
        }
    }
}
