using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace siramatik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Queue<int> kuyruk = new Queue<int>();
        int sira = 0;

        private void Listele()
        {
            listBox1.Items.Clear();

            foreach (int numara in kuyruk)
            {
                listBox1.Items.Add(numara);
            }
        }

        private void MusteriCagir(string masaAdi, TextBox txtMasa)
        {
            if (kuyruk.Count > 0)
            {
                int cagrilan = kuyruk.Dequeue();

                txtMasa.Text = cagrilan.ToString();

                listBox2.Items.Add(masaAdi + " → " + cagrilan);

                Listele();
            }
            else
            {
                MessageBox.Show("Kuyrukta müşteri yok!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sira++;
            kuyruk.Enqueue(sira);
            Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MusteriCagir("M1", textBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MusteriCagir("M2", textBox2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MusteriCagir("M3", textBox3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MusteriCagir("M4", textBox4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MusteriCagir("M5", textBox5);
        }

    }
}
