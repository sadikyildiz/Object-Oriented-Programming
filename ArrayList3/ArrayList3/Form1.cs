using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ArrayList3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Listele()
        {
            listBox1.Items.Clear();
            foreach (string sehir in sehirler)
            {
                listBox1.Items.Add(sehir);
            }
        }

        ArrayList sehirler = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            sehirler.Add(textBox1.Text);
            Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int indexNo = listBox1.SelectedIndex;
            sehirler.Insert(indexNo, textBox1.Text);
            Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int indexNo = listBox1.SelectedIndex;
            sehirler[indexNo] = textBox1.Text;
            Listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int indexNo = listBox1.SelectedIndex;
            sehirler.RemoveAt(indexNo);
            Listele();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (sehirler.Contains(textBox1.Text))
            {
                label2.Text = "Aranan Değer Bulundu.";
                listBox1.SelectedIndex = sehirler.IndexOf(textBox1.Text);
            }
            else
            {
                label2.Text = "Aranan Değer Bulunamadı.";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sehirler.Reverse();
            Listele();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sehirler.Sort();
            Listele();
        }
    }
}
