using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dizi1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isimler = new string[5]; //Global Dizi
        int index = 0; //Global Değişken
        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                isimler[index] = textBox1.Text;
                index++;
            }
            catch 
            {
                MessageBox.Show("Hatalı Giriş Yaptınız");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < isimler.Length; i++)
            {
               listBox1.Items.Add(isimler[i]);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sayı_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
