using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoyutSinif
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool deger;
            // ** Alttaki satır hata verir.
            // ** Sanal sınıflardan nesne türetilemez.
            // MotorluArac ma = new MotorluArac();
            if (checkBox1.Checked)
            {
                deger = true;
            }
            else
            {
                deger = false;
            }
            Otomobil oto = new Otomobil
            {
                ModelYili = Convert.ToInt32(textBox1.Text),
                MotorHacmi = Convert.ToInt32(textBox2.Text),
                OtomatikVites = deger,

            };
            oto.Calis();
            oto.Dur();
        }
    }
}
