using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DialogBoxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dünya-(Mesaj)","Bilgi Mesajı(Başlık)",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Bu dosyayı silmek istediğinize emin misiniz ?", "Dosya Sil",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cevap == DialogResult.Yes)
            {
                MessageBox.Show("Dosya silindi.");
            }
            else if (cevap == DialogResult.No)
            {
                MessageBox.Show("İşlem iptal edildi.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Dosyası | *.txt | Word Dosyası | *.docx | Tüm Dosyalar | *.*"; // Kaydedilecek dosyanın uzantısı txt veya docx olarak belirlenir.
            sfd.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Dosyaları | *.txt | Word Dosyaları | *.docx | Tüm Dosyalar | *.*";// Uzantısı txt, docx veya tüm dosyaları gösterir.
            ofd.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            pd.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowColor = true;
            fd.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
        }
    }
}
