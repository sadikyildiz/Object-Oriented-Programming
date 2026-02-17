using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace FormApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form1 click olayı çalışıyor.");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Form Sınıfı Uygulama 2";
            this.BackColor = Color.Green;
            this.ForeColor = Color.Black;
            this.Size = new Size(300, 150);

            label1.Text = "Adınız";
            label1.Location = new Point(10, 10);
            label1.Size = new Size(65, 15);
            label1.ForeColor = Color.White;

            textBox1.Location = new Point(75, 10);
            textBox1.Size = new Size(150, 15);
            textBox1.TabIndex = 1;

            button1.Text = "Tıkla";
            button1.Location = new Point(100, 60);
            button1.Size = new Size(100, 30);
            button1.ForeColor = Color.White;
            button1.BackColor = Color.Black;
            button1.TabIndex = 2;

            textBox1.KeyPress += TextBox1_KeyPress;
            button1.Click += Button1_Click;

            this.Controls.Add(label1);
            this.Controls.Add(textBox1);
            this.Controls.Add(button1);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba " +textBox1.Text);
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

    }
}
