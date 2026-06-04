using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace errorprovider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ErrorProvider ep = new ErrorProvider();

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int sonuc))
            {
                ep.SetError(textBox1, "");
            }
            else
            {
                e.Cancel = true;
                ep.SetError(textBox1, "Numara girişi hatalı");
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text == "")
{
                e.Cancel = true;
                ep.SetError(textBox2, "Adı ve soyadı giriniz.");
            }
else
            {
                ep.SetError(textBox2, "");
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            int dersNotu;
            if (int.TryParse(textBox3.Text, out dersNotu))
            {
                if (dersNotu < 0 || dersNotu > 100)
                {
                    e.Cancel = true;
                    ep.SetError(textBox3, "0 - 100 arasında değer giriniz.");
                }
                else
                {
                    ep.SetError(textBox3, "");
                }
            }
            else
            {
                e.Cancel = true;
                ep.SetError(textBox3, "Sayısal değer giriniz.");
            }
        }
    }
}
