using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace refout
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Matematik m=new Matematik();
            int a = Convert.ToInt32(textBox1.Text);
            m.Artir(a);
            label2.Text = "SAYI="+a.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Matematik m = new Matematik();
            int a = Convert.ToInt32(textBox1.Text);
            m.Artirout(out a);
            label2.Text = "SAYI=" + a.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Matematik m = new Matematik();
            int a = Convert.ToInt32(textBox1.Text);
            m.Artirref(ref a);
            label2.Text = "SAYI=" + a.ToString();
        }
    }
}
