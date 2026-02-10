using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> numaralarList = new List<int>();
        List<string> adsoyadList = new List<string>();
        List<Ogrenciler> ogrencilerList = new List<Ogrenciler>();
        private void button1_Click(object sender, EventArgs e)
        {
            numaralarList.Add(int.Parse(textBox1.Text));
            listBox1.Items.Clear();
            foreach (var item in numaralarList)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adsoyadList.Add(textBox2.Text);
            listBox2.Items.Clear();
            foreach (var item in adsoyadList)
            {
                listBox2.Items.Add(item);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ogrenciler ogrenci = new Ogrenciler();
            ogrenci.Numara = int.Parse(textBox3.Text);
            ogrenci.AdSoyad = textBox4.Text;
            ogrencilerList.Add(ogrenci);
            listBox3.Items.Clear();
            foreach (var item in ogrencilerList)
            {
                listBox3.Items.Add(item.Numara +" "+item.AdSoyad);
            }
        }
    }
}
