using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalitim
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        double s1, s2, f, s3;
        Hesapla islem =new Hesapla();
        private void button1_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToDouble(textBox1.Text);
            s2 = Convert.ToDouble(textBox2.Text);
            f = islem.fonksiyon(s1, s2);
            label4.Text = islem.fonksiyon(s1, s2).ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            s3 = Convert.ToDouble(textBox3.Text);
            label5.Text = islem.topla(f, s3).ToString();
        }
    }
}
