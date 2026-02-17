using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbCpui7.Checked = true;
            rbRam16.Checked = true;
            rbHdd1000.Checked = true;
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            // Değişkenleri Tanımla
            decimal tabanFiyat = 500;
            decimal cpuFiyat = 0;
            decimal ramFiyat = 0;
            decimal hddFiyat = 0;
            decimal dvdFiyat = 5;
            decimal webcamFiyat = 10;
            decimal wifiFiyat = 15;

            //İşlemci Fiyatı
            if (rbCpui7.Checked)
            {
                cpuFiyat = 300;
            }
            else if (rbCpui5.Checked)
            {
                cpuFiyat = 200;
            }
            else if (rbCpui3.Checked)
            {
                cpuFiyat = 100;
            }
            else if (rbCpuR5.Checked)
            {
                cpuFiyat = 250;
            }
            else if (rbCpuR3.Checked)
            {
                cpuFiyat = 150;
            }

            tabanFiyat += cpuFiyat;

            //RAM Bellek Fiyatı Hesapla
            if (rbRam16.Checked)
            {
                ramFiyat = 125;
            }
            else if (rbRam8.Checked)
            {
                ramFiyat = 75;
            }
            else if (rbRam4.Checked)
            {
                ramFiyat = 45;
            }

            tabanFiyat += ramFiyat;

            //HDD Fiyat Hesapla
            if (rbHdd1000.Checked)
            {
                hddFiyat = 100;
            }
            else if (rbHdd500.Checked)
            {
                hddFiyat = 75;
            }
            else if (rbHdd320.Checked)
            {
                hddFiyat = 50;
            }

            tabanFiyat += hddFiyat;

            if (cbDVD.Checked)
            {
                tabanFiyat += dvdFiyat;
            }
            if (cbWebCam.Checked)
            {
                tabanFiyat += webcamFiyat;
            }
            if (cbWifi.Checked)
            {
                tabanFiyat += wifiFiyat;
            }

            MessageBox.Show(string.Format("Toplam Fiyat = {0:C}", tabanFiyat));
        }
    }
}
