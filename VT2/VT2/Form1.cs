using MySql.Data.MySqlClient;
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

namespace VT2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string baglantiCumlesi = "Server=localhost; Database=kutuphane; Uid=root;Pwd=Lab309+admin";
            MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi);
            
            string sorguCumlesi = "SELECT * FROM kitap_turleri";

            MySqlDataAdapter adapter = new MySqlDataAdapter(sorguCumlesi, baglanti);
            
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            
            dataGridView1.DataSource = tablo;
        }
    }
}
