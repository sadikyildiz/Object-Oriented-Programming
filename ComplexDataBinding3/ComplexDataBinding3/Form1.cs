using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3;

namespace ComplexDataBinding3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Sehirler> listSehirler = new List<Sehirler>();
        private void Bagla()
        {
            comboBox1.DataSource = null;
            comboBox1.DataSource = listSehirler;
            comboBox1.DisplayMember = "SehirAdi";
            comboBox1.ValueMember = "Plaka";
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Sehirler sehir = new Sehirler();
            sehir.Plaka = textBox1.Text;
            sehir.SehirAdi = textBox2.Text;
            listSehirler.Add(sehir);
            Bagla();
        }
    }
}
