using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneProjesi
{
    public partial class formOduncKitap : Form
    {
        public formOduncKitap()
        {
            InitializeComponent();
        }

        VeriTabaniIslemleri vtIslemleri = new VeriTabaniIslemleri();//VeriTabanıIslemleri sınıfından bir nesne örneği oluşturuldu
        MySqlConnection baglanti;
        MySqlCommand komut;
        string komutSatiri;

        private void formOduncKitap_Load(object sender, EventArgs e)
        {
            btnKitapVer.ImageAlign = ContentAlignment.TopCenter;
            btnKitapVer.TextAlign = ContentAlignment.BottomCenter;

            btnKitapAl.ImageAlign = ContentAlignment.TopCenter;
            btnKitapAl.TextAlign = ContentAlignment.BottomCenter;

            btnSil.ImageAlign = ContentAlignment.TopCenter;
            btnSil.TextAlign = ContentAlignment.BottomCenter;

            Listele();
            KitapYukle();
        }

        public void KitapYukle()
        {
            try
            {

                komutSatiri = "select * from kitaplar where kitap_id not in (select kitap_id from odunc_kitaplar where teslim_tarihi IS NULL)";
                //combokitap nesnesinde veriler, ödünç verilip geri getirilmemiş kitaplar yer almayacak şekilde listelenir
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komutSatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                comboKitap.DataSource = dataTable;
                comboKitap.ValueMember = "kitap_id";
                comboKitap.DisplayMember = "kitap_adi";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Listele()
        {
            try
            {
                baglanti = vtIslemleri.baglan();
                komutSatiri = "Select id, ogrenci_no, ad, soyad, kitap_adi, verilis_tarihi, teslim_tarihi, aciklama " +
                "From kitaplar, ogrenciler, odunc_kitaplar " +
                "where ogr_no=ogrenci_no and kitaplar.kitap_id=odunc_kitaplar.kitap_id";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komutSatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                gridOduncKitaplar.DataSource = dataTable;
                gridOduncKitaplar.Columns["id"].HeaderText = "ID";
                gridOduncKitaplar.Columns["id"].Width = 30;
                gridOduncKitaplar.Columns["ogrenci_no"].HeaderText = "Öğrenci No";
                gridOduncKitaplar.Columns["ogrenci_no"].Width = 40;
                gridOduncKitaplar.Columns["ad"].HeaderText = "Ad";
                gridOduncKitaplar.Columns["ad"].Width = 70;
                gridOduncKitaplar.Columns["soyad"].HeaderText = "Soyad";
                gridOduncKitaplar.Columns["soyad"].Width = 70;
                gridOduncKitaplar.Columns["kitap_adi"].HeaderText = "Kitap Adı";
                gridOduncKitaplar.Columns["kitap_adi"].Width = 100;
                gridOduncKitaplar.Columns["verilis_tarihi"].HeaderText = "Veriliş Tarihi";
                gridOduncKitaplar.Columns["verilis_tarihi"].Width = 70;
                gridOduncKitaplar.Columns["teslim_tarihi"].HeaderText = "Teslim Tarihi";
                gridOduncKitaplar.Columns["teslim_tarihi"].Width = 70;
                gridOduncKitaplar.Columns["aciklama"].HeaderText = "Açıklama";
                gridOduncKitaplar.Columns["aciklama"].Width = 150;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKitapVer_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open) baglanti.Open();
                komut = new MySqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "INSERT INTO odunc_kitaplar (ogr_no, kitap_id, verilis_tarihi, aciklama) " +
                "VALUES(@ogr_no, @kitap_id, @verilis_tarihi, @aciklama)";
                komut.Parameters.AddWithValue("@ogr_no", int.Parse(txtNo.Text));
                komut.Parameters.AddWithValue("@kitap_id", int.Parse(comboKitap.SelectedValue.ToString()));
                komut.Parameters.AddWithValue("@verilis_tarihi", DateTime.Now.ToString("yyyy/MM/dd"));
                komut.Parameters.AddWithValue("@aciklama", txtAciklama.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                KitapYukle();
                Listele();
                MessageBox.Show("İşlem başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Temizle()
        {
            txtNo.Clear();
            txtAciklama.Clear();
        }

        private void gridOduncKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtAciklama.Text = gridOduncKitaplar.CurrentRow.Cells["aciklama"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                komut = new MySqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "DELETE FROM odunc_kitaplar WHERE id = @id";
                komut.Parameters.AddWithValue("@id", gridOduncKitaplar.CurrentRow.Cells["id"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                KitapYukle();
                Listele();
                MessageBox.Show("İşlem başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKitapAl_Click(object sender, EventArgs e)
        {
            try
            {

                if (gridOduncKitaplar.CurrentRow.Cells["teslim_tarihi"].Value.ToString() != String.Empty)
                { // Teslim tarihi boş değilse yani kitap teslim alınmışsa işlem yapmadan Click olayından çıkılır
                    MessageBox.Show("Bu kitap teslim alınmış", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                komutSatiri = "UPDATE odunc_kitaplar SET teslim_tarihi=@teslim_tarihi,aciklama=@aciklama where id=@id";
                komut = new MySqlCommand(komutSatiri, baglanti);
                komut.Parameters.AddWithValue("@id", int.Parse(gridOduncKitaplar.CurrentRow.Cells["id"].Value.ToString()));
                komut.Parameters.AddWithValue("@teslim_tarihi", DateTime.Now.ToString("yyyy/MM/dd"));
                komut.Parameters.AddWithValue("@aciklama", txtAciklama.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                KitapYukle();
                Listele();
                MessageBox.Show("İşlem başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtAramaOgrenci_TextChanged(object sender, EventArgs e)
        {
            OduncKitapogrenciArama(txtAramaOgrenci.Text);
        }

        public void OduncKitapogrenciArama(string aranacakKelime)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open) baglanti.Open();
                komutSatiri = "Select id, ogrenci_no, ad, soyad, kitap_adi, verilis_tarihi, teslim_tarihi, aciklama " + "From kitaplar, ogrenciler, odunc_kitaplar " +
                        "where ogr_no=ogrenci_no and kitaplar.kitap_id=odunc_kitaplar.kitap_id and ad LIKE'" + aranacakKelime + "%'";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komutSatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                gridOduncKitaplar.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
