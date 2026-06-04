using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VT1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=kutuphane;Uid=root;Pwd=Lab309+admin");
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("INSERT INTO kitap_turleri(tur_adi) values('Bilgisayar')",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
