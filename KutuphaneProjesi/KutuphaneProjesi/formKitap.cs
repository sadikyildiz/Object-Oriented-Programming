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

namespace KutuphaneProjesi
{
    public partial class formKitap : Form
    {
        public formKitap()
        {
            InitializeComponent();
        }

        VeriTabaniIslemleri vtIslemleri = new VeriTabaniIslemleri();//VeriTabanıIslemleri sınıfından bir nesne örneği oluşturuldu
        MySqlConnection baglanti;
        MySqlCommand komut;
        string komutSatiri;

        private void formKitap_Load(object sender, EventArgs e)
        {
            btnGuncelle.ImageAlign = ContentAlignment.TopCenter;
            btnGuncelle.TextAlign = ContentAlignment.BottomCenter;

            btnKaydet.ImageAlign = ContentAlignment.TopCenter;
            btnKaydet.TextAlign = ContentAlignment.BottomCenter;

            btnSil.ImageAlign = ContentAlignment.TopCenter;
            btnSil.TextAlign = ContentAlignment.BottomCenter;

            KitapTurYukle();
            KitapListele();
        }

        public void KitapTurYukle()
        {
            try
            {
                baglanti = vtIslemleri.baglan();
                komutSatiri = "Select * From kitap_turleri";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komutSatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                comboKitapTur.DataSource = dataTable; // ComboBox nesnesinin veri kaynağı ayarlanır
                comboKitapTur.ValueMember = "tur_id"; // Arka planda tutulup veri tabanına kaydedilecek alan belirlenir
                comboKitapTur.DisplayMember = "tur_adi"; // Kullanıcıya gösterilecek alan belirlenir
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void KitapListele()
        {
            try
            {
                baglanti = vtIslemleri.baglan();
                komutSatiri = "Select kitap_id, tur_adi, kitap_adi, yazar, yayinevi, sayfa_sayisi From kitaplar, kitap_turleri where kitaplar.tur_id=kitap_turleri.tur_id";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komutSatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                gridKitap.DataSource = dataTable;
                gridKitap.Columns["kitap_id"].HeaderText = "ID";
                gridKitap.Columns["kitap_id"].Width = 20;
                gridKitap.Columns["tur_adi"].HeaderText = "Tür";
                gridKitap.Columns["tur_adi"].Width = 30;
                gridKitap.Columns["kitap_adi"].HeaderText = "Adı";
                gridKitap.Columns["kitap_adi"].Width = 90;
                gridKitap.Columns["yazar"].HeaderText = "Yazar";
                gridKitap.Columns["yazar"].Width = 80;
                gridKitap.Columns["yayinevi"].HeaderText = "Yayınevi";
                gridKitap.Columns["yayinevi"].Width = 80;
                gridKitap.Columns["sayfa_sayisi"].HeaderText = "Sayfa Sayısı";
                gridKitap.Columns["sayfa_sayisi"].Width = 50;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {

                if (baglanti.State != ConnectionState.Open) // Bağlantının durumu kontrol edilir
                {
                    baglanti.Open(); // Eğer bağlantı açık değilse açılır
                }

                komut = new MySqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "INSERT INTO kitaplar (tur_id, kitap_adi, yazar, yayinevi, sayfa_sayisi) " + "VALUES(@tur_id,@kitap_adi, @yazar, @yayinevi, @sayfa_sayisi)";
                // Alttaki satırda ComboBox nesnesinin arka planda tuttuğu id değeri tur_id olarak kayıt edilir
                komut.Parameters.AddWithValue("@tur_id", int.Parse(comboKitapTur.SelectedValue.ToString()));
                komut.Parameters.AddWithValue("@kitap_adi", txtKitapAdi.Text);
                komut.Parameters.AddWithValue("@yazar", txtYazar.Text);
                komut.Parameters.AddWithValue("@yayinevi", txtYayinEvi.Text);
                komut.Parameters.AddWithValue("@sayfa_sayisi", int.Parse(txtSayfaSayisi.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                MessageBox.Show("İşlem başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                KitapListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Temizle()
        {
            txtKitapAdi.Clear();
            txtSayfaSayisi.Clear();
            txtYayinEvi.Clear();
            txtYazar.Clear();
        }

        private void gridKitap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtKitapAdi.Text = gridKitap.CurrentRow.Cells["kitap_adi"].Value.ToString();
                txtSayfaSayisi.Text = gridKitap.CurrentRow.Cells["sayfa_sayisi"].Value.ToString();
                txtYayinEvi.Text = gridKitap.CurrentRow.Cells["yayinevi"].Value.ToString();
                txtYazar.Text = gridKitap.CurrentRow.Cells["yazar"].Value.ToString();
                comboKitapTur.Text = gridKitap.CurrentRow.Cells["tur_adi"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                komut.CommandText = "DELETE FROM kitaplar WHERE kitap_id = @kitap_id";
                komut.Parameters.AddWithValue("@kitap_id", gridKitap.CurrentRow.Cells["kitap_id"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                MessageBox.Show("İşlem başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                KitapListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {

                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }

                komut = new MySqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "UPDATE kitaplar SET tur_id=@tur_id, kitap_adi=@kitap_adi," + "yazar=@yazar, yayinevi=@yayinevi, sayfa_sayisi=@sayfa_sayisi where kitap_id=@kitap_id";
                komut.Parameters.AddWithValue("@kitap_id", int.Parse(gridKitap.CurrentRow.Cells["kitap_id"].Value.ToString()));
                komut.Parameters.AddWithValue("@tur_id", int.Parse(comboKitapTur.SelectedValue.ToString()));
                komut.Parameters.AddWithValue("@kitap_adi", txtKitapAdi.Text);
                komut.Parameters.AddWithValue("@yazar", txtYazar.Text);
                komut.Parameters.AddWithValue("@yayinevi", txtYayinEvi.Text);
                komut.Parameters.AddWithValue("@sayfa_sayisi", int.Parse(txtSayfaSayisi.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                MessageBox.Show("İşlem başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                KitapListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtKitapAra_TextChanged(object sender, EventArgs e)
        {
            KitapArama(txtKitapAra.Text);
        }

        public void KitapArama(string aranacakKelime)
        {
            try
            {

                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                komutSatiri = "Select kitap_id, tur_adi, kitap_adi, yazar, yayinevi, sayfa_sayisi From kitaplar, kitap_turleri " + "where kitaplar.tur_id=kitap_turleri.tur_id and kitap_adi LIKE '" + aranacakKelime + "%'";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komutSatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                baglanti.Close();
                gridKitap.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
