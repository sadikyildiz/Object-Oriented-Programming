using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dizi2
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
    }
}
