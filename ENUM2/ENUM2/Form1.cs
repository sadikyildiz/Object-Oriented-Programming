using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ENUM2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string seviye = textBox1.Text;
                seviyeler secilenSeviye = (seviyeler)Enum.Parse(typeof(seviyeler), seviye);
                listBox1.Items.Add((int)secilenSeviye);
            }
            catch
            {
                MessageBox.Show("Hatalı seviye Girdiniz");
                textBox1.Text = "";
            }
        }
    }
}
