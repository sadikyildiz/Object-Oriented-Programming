using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace degerReferans
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1=Convert.ToInt32(textBox1.Text);
            int sayi2 = sayi1;
            sayi2=Convert.ToInt32(textBox2.Text);
            
            label3.Text=Convert.ToString(sayi1);
            label4.Text=Convert.ToString(sayi2);

            SayiTutucu st1 = new SayiTutucu();
            st1.A = 10;
            SayiTutucu st2 = st1;
            st2.A = 50;

            label5.Text=Convert.ToString(st1.A);
            label6.Text=Convert.ToString(st2.A);
        }
    }
}
