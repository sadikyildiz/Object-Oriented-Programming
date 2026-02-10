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

namespace ArrayList2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList sehirler = new ArrayList();

        private void button1_Click(object sender, EventArgs e)
        {
            sehirler.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (string sehir in sehirler) //foreach (object sehir in sehirler)
            {
                listBox1.Items.Add(sehir);
            }
        }
    }
}
