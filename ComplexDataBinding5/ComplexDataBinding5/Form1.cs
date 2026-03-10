using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComplexDataBinding5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable tablo = new DataTable();
        private void Bagla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = tablo;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tablo.Columns.Add("Numara", typeof(int));
            tablo.Columns.Add("Ad Soyad", typeof(string));
            tablo.Columns.Add("Notu", typeof(int));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numara = int.Parse(textBox1.Text);
            string adsoyad = textBox2.Text;
            int notu = int.Parse(textBox3.Text);
            tablo.Rows.Add(numara, adsoyad, notu);
            Bagla();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    //if (!row.IsNewRow)
                    //{
                        dataGridView1.Rows.Remove(row);
                    //}
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek satırı seçin.");
            }
        }

        
    }
}
