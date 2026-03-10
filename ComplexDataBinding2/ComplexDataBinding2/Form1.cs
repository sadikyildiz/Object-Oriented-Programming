using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComplexDataBinding2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList kaynakVeri = new ArrayList();

        private void button1_Click(object sender, EventArgs e)
        {
            Kitaplar kitap = new Kitaplar();
            kitap.KitapAdi = textBox1.Text;
            kitap.KitapYazari = textBox2.Text;
            kitap.KitapTuru = textBox3.Text;
            kaynakVeri.Add(kitap);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = kaynakVeri;
        }
    }
}
