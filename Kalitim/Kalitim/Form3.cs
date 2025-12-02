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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        double s1, s2, f, s3;
                
        Hesapla2 denklem = new Hesapla2();
        private void button1_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToDouble(textBox1.Text);
            s2 = Convert.ToDouble(textBox2.Text);
            f = denklem.fonksiyon(s1, s2);
            label4.Text = denklem.fonksiyon(s1, s2).ToString();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            s3 = Convert.ToDouble(textBox3.Text);
            label5.Text = denklem.topla(f, s3).ToString();
        }
    }
}
