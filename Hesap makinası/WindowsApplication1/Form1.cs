using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public String x, y,s1,s2,so,geri,ygeri;
        public double sayi1, sayi2,sonuc,isaret;
        public int g;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text= "Hesap Makinası";          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = "1";
            textBox1.Text += x; //textBox1.Text =textBox1.Text+ x;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            x = "2";
            textBox1.Text += x;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            x = "3";
            textBox1.Text += x;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            x = "4";
            textBox1.Text += x;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            x = "5";
            textBox1.Text += x;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            x = "6";
            textBox1.Text += x;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            x = "7";
            textBox1.Text += x;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            x = "8";
            textBox1.Text += x;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            x = "9";
            textBox1.Text += x;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            x = "0";
            textBox1.Text += x;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            isaret = Convert.ToDouble(textBox1.Text);
            isaret *= (-1); //isaret=isaret * (-1);
            textBox1.Text = Convert.ToString(isaret);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            x = ",";
            textBox1.Text += x;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
            y = "/";
            s1 = textBox1.Text;
            sayi1 = Convert.ToDouble(s1);
            textBox1.Text = "";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            y = "*";
            s1 = textBox1.Text;
            sayi1 = Convert.ToDouble(s1);
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            y = "-";
            s1 = textBox1.Text;
            sayi1 = Convert.ToDouble(s1);
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            y = "+";
            s1 = textBox1.Text;
            sayi1 = Convert.ToDouble(s1);
            textBox1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //y = "=";
            s2 = textBox1.Text;
            sayi2 = Convert.ToDouble(s2);
            switch(y)
            {
                case "/":
                    sonuc = sayi1/sayi2;
                    sayi1 = sonuc;
                    textBox1.Text = Convert.ToString(sonuc);
                    break;
                case"*":
                    sonuc = sayi1 * sayi2;
                    sayi1 = sonuc;
                    textBox1.Text = Convert.ToString(sonuc);
                    break;
                case "-":
                    sonuc = sayi1 - sayi2;
                    sayi1 = sonuc;
                    textBox1.Text = Convert.ToString(sonuc);
                    break;
                case "+":
                    sonuc = sayi1 + sayi2;
                    sayi1 = sonuc;
                    textBox1.Text = Convert.ToString(sonuc);
                    break;
                case"%":
                    sonuc = sayi1 / 100 * sayi2;
                    textBox1.Text = Convert.ToString(sonuc);
                    break;
            }
                
        }

        private void button18_Click(object sender, EventArgs e)
        {
            s1 = textBox1.Text;
            sayi1 = Convert.ToDouble(s1);
            if (sayi1 == 0)
                textBox1.Text = "Sıfıra Bölünemez";
            else 
                sayi1 = 1 / sayi1;
            textBox1.Text = Convert.ToString(sayi1);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            y = "%";
            s1 = textBox1.Text;
            sayi1 = Convert.ToDouble(s1);
            textBox1.Text = "";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            s1 = textBox1.Text;
            sayi1 = Convert.ToDouble(s1);
            sonuc = Math.Sqrt(sayi1);
            textBox1.Text = Convert.ToString(sonuc);

        }

        private void button21_Click(object sender, EventArgs e)
        {
            sayi1 = 0;
            sayi2 = 0;
            textBox1.Text = "";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            sayi2 = 0;
            textBox1.Text = "";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            g = textBox1.TextLength;
            g--;
            geri = textBox1.Text;
            ygeri = geri.Remove(g, 1);
            textBox1.Text = ygeri;
        }

    }
}