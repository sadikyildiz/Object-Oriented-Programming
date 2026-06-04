using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tooltip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(textBox1, "Adınızı giriniz.");
            tt.SetToolTip(textBox2, "Soyadınızı giriniz.");
            tt.SetToolTip(textBox3, "Doğum tarihinizi gg / aa / yyyy şeklinde giriniz.");
            tt.SetToolTip(richTextBox1, "Adresinizi giriniz.");
            tt.SetToolTip(button1, "Kaydetmek için tıklayınız.");
        }
    }
}
