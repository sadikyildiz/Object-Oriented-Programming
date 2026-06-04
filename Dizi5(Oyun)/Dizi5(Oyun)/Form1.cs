using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dizi5_Oyun_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        byte[,] dizi = new byte[4, 4];

        private void RenkleriTemizle()
        {
            foreach (Control ctrl in groupBox1.Controls)
            {
                if (ctrl is PictureBox)
                {
                    ctrl.BackColor =Color.PapayaWhip;
                   
                }
            }
        }
        private void DiziyiTemizle()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    dizi[i, j] = 0;
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                byte satir = byte.Parse(textBox1.Text);
                byte sutun = byte.Parse(textBox2.Text);
                PictureBox kutu = this.Controls.Find("P" + satir + sutun, true)[0] as PictureBox;
                // Controls.Find fonksiyonu name değerlerine göre form içindeki kontrolleri bulmak için kullanılır.
                // Bulunan kontroller as operatörü ile PictureBox nesnelerine dönüştürülür.
                byte durum = dizi[satir, sutun];
                if (durum == 0)
                { kutu.BackColor = Color.Green; }
                else
                { kutu.BackColor = Color.Red; }
            }
            catch 
            {
                MessageBox.Show("Hatalı Giriş Yaptınız");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RenkleriTemizle();
            DiziyiTemizle();

            Random rastgele = new Random(); // rastgele isminde bir Random nesnesi oluşturdu.
            int satirRastgele = rastgele.Next(4);// 0-4 arası (4 dâhil değil) üretilen sayıdır.
            int sutunRastgele = rastgele.Next(4); // 0-4 arası (4 dâhil değil) üretilen sayıdır.
            dizi[satirRastgele, sutunRastgele] = 1; // Dizi içinde rastgele bir konuma 1 değeri aktarıldı.
            
        }
    }
}
