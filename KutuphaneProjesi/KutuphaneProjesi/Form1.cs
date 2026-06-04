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

namespace KutuphaneProjesi
{
    public partial class formAnaSayfa : Form
    {
        public formAnaSayfa()
        {
            InitializeComponent();
        }

        private void formAnaSayfa_Load(object sender, EventArgs e)
        {
            btnKitap.ImageAlign = ContentAlignment.TopCenter;
            btnKitap.TextAlign = ContentAlignment.BottomCenter;

            btnOgrenci.ImageAlign = ContentAlignment.TopCenter;
            btnOgrenci.TextAlign = ContentAlignment.BottomCenter;

            btnOdunc.ImageAlign = ContentAlignment.TopCenter;
            btnOdunc.TextAlign = ContentAlignment.BottomCenter;

            btnTur.ImageAlign = ContentAlignment.TopCenter;
            btnTur.TextAlign = ContentAlignment.BottomCenter;
        }

        private void btnKitap_Click(object sender, EventArgs e)
        {
            formKitap kitap = new formKitap();
            kitap.ShowDialog();
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            formOgrenci ogrenci = new formOgrenci();
            ogrenci.ShowDialog();
        }

        private void btnTur_Click(object sender, EventArgs e)
        {
            formKitapTur kitapTur = new formKitapTur();
            kitapTur.ShowDialog();
        }

        private void btnOdunc_Click(object sender, EventArgs e)
        {
            formOduncKitap oduncKitap = new formOduncKitap();
            oduncKitap.ShowDialog();
        }

        
    }
}
