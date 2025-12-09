using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kedi kedi = new Kedi();
            kedi.SesCikar();
            kedi.Beslen();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Kopek kopek = new Kopek();
            kopek.SesCikar();
            kopek.Beslen();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kedi kedi = new Kedi();
            Kopek kopek = new Kopek();
            IHayvan hayvan1 = kedi;
            IHayvan hayvan2 = kopek;
            hayvan1.SesCikar();
            hayvan2.SesCikar();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Kedi kedi = new Kedi();
            Kopek kopek = new Kopek();
            IBeslen beslen1 = kedi;
            IBeslen beslen2 = kopek;
            beslen1.Beslen();
            beslen2.Beslen();

        }
 
    }
}
