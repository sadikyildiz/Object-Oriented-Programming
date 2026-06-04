using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneProjesi
{
    public partial class formOgrenci : Form
    {
        public formOgrenci()
        {
            InitializeComponent();
        }

        VeriTabaniIslemleri vtIslemler = new VeriTabaniIslemleri();//VeriTabanıIslemleri sınıfından bir nesne örneği oluşturuldu
        MySqlConnection baglanti;
        MySqlCommand komut;

        private void formOgrenci_Load(object sender, EventArgs e)
        {
            btnGuncelle.ImageAlign = ContentAlignment.TopCenter;
            btnGuncelle.TextAlign = ContentAlignment.BottomCenter;

            btnKaydet.ImageAlign = ContentAlignment.TopCenter;
            btnKaydet.TextAlign = ContentAlignment.BottomCenter;

            btnSil.ImageAlign = ContentAlignment.TopCenter;
            btnSil.TextAlign = ContentAlignment.BottomCenter;

            Listele();
        }

        public void Listele()
        {
            try
            {
                baglanti = vtIslemler.baglan();//Veri Tabanı bağlantı nesnesi oluşturuldu
                string komutSatiri = "Select * From ogrenciler";//Verileri Listeleyecek olan SQL sorgusu tanımlandı
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komutSatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);// Sorgu sonucunda dönen kayıtlar DataTable nesnesini aktarılır
                gridOgrenci.DataSource = dataTable;
                gridOgrenci.Columns["ogrenci_no"].HeaderText = "Öğrenci Numarası"; //DataGridView nesnesinde sütun başlıkları belirlenir.
                gridOgrenci.Columns["ad"].HeaderText = "Ad";
                gridOgrenci.Columns["soyad"].HeaderText = "Soyad";
                gridOgrenci.Columns["sinif"].HeaderText = "Sınıf";
                gridOgrenci.Columns["cinsiyet"].HeaderText = "Cinsiyet";
                gridOgrenci.Columns["telefon"].HeaderText = "Telefon";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtNo.Clear();
            txtTelefon.Clear();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open) // Bağlantının durumu kontrol edilir
                {
                    baglanti.Open(); // Eğer bağlantı açık değilse açılır
                }
                string komutSatiri = "INSERT INTO ogrenciler (ogrenci_no, ad, soyad, sinif, cinsiyet, telefon) VALUES (@no, @ad, @soyad, @sinif,@cinsiyet, @telefon)";
                komut = new MySqlCommand(komutSatiri, baglanti); // Komut çalıştırmak için MySqlCommand nesnesi oluşturulur
                komut.Parameters.AddWithValue("@no", int.Parse(txtNo.Text)); // Sorguda verilen parametrelerin değerleri belirlenir
                komut.Parameters.AddWithValue("@ad", txtAd.Text);
                komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                komut.Parameters.AddWithValue("@sinif", int.Parse(comboSinif.SelectedItem.ToString()));
                komut.Parameters.AddWithValue("@cinsiyet", comboCinsiyet.SelectedItem.ToString());
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.ExecuteNonQuery(); // Ekleme sorgusu çalıştırılır ve hata oluşmazsa öğrenci eklenir
                baglanti.Close(); // Bağlantı kapatılır
                Temizle(); // Form elemanlarının içerikleri temizlenir
                MessageBox.Show("İşlem başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Listele();// Eklenen öğrencinin DataGridView'de görülebilmesi için veriler tekrar listelenir
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridOgrenci_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                // DataGridView'de seçili olan öğrenciye ait bilgiler form elemanlarına yazdırılır
                txtNo.Text = gridOgrenci.CurrentRow.Cells["ogrenci_no"].Value.ToString();
                txtAd.Text = gridOgrenci.CurrentRow.Cells["ad"].Value.ToString();
                txtSoyad.Text = gridOgrenci.CurrentRow.Cells["soyad"].Value.ToString();
                txtTelefon.Text = gridOgrenci.CurrentRow.Cells["telefon"].Value.ToString();
                comboSinif.SelectedItem = gridOgrenci.CurrentRow.Cells["sinif"].Value.ToString();
                comboCinsiyet.SelectedItem = gridOgrenci.CurrentRow.Cells["cinsiyet"].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata oluştu", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            try
            {
                if (baglanti.State != ConnectionState.Open) // Bağlantı durumu kontrol edilir
                {
                    baglanti.Open(); // Eğer açık değilse bağlantı açılır
                }

                string komutSatiri = "DELETE FROM ogrenciler WHERE ogrenci_no = @no"; //@no yerine parametre gelecektir
                komut = new MySqlCommand(komutSatiri, baglanti);
                komut.Parameters.AddWithValue("@no", gridOgrenci.CurrentRow.Cells["ogrenci_no"].Value.ToString());
                //Üst satırda sorguya parametre olarak DataGridView'de seçili olan ogrenci_no bilgisi gönderilir

                komut.ExecuteNonQuery(); // Sorgu çalıştırılır ve hata oluşmazsa öğrenci silinir
                baglanti.Close(); // Bağlantı kapatılır
                Temizle(); // Form elemanlarının içerikleri temizlenir.
                MessageBox.Show("İşlem başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Listele(); // Silinen kayıtın görünmemesi için tekrar listeleme yapılır
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Hata oluştu",MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                string komutSatiri = "UPDATE ogrenciler SET ad=@ad, soyad=@soyad, sinif=@sinif, cinsiyet=@cinsiyet, telefon=@telefon where ogrenci_no=@no";
                komut = new MySqlCommand(komutSatiri, baglanti);
                komut.Parameters.AddWithValue("@no", int.Parse(gridOgrenci.CurrentRow.Cells["ogrenci_no"].Value.ToString()));
                komut.Parameters.AddWithValue("@ad", txtAd.Text);
                komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                komut.Parameters.AddWithValue("@sinif", int.Parse(comboSinif.SelectedItem.ToString()));
                komut.Parameters.AddWithValue("@cinsiyet", comboCinsiyet.SelectedItem.ToString());
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                MessageBox.Show("İşlem başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtAramaOgrenci_TextChanged(object sender, EventArgs e)
        {
            OgrenciArama(txtAramaOgrenci.Text);
        }

        public void OgrenciArama(string aranacakKelime)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                komut=new MySqlCommand(); // MySqlCommand nesnesinin parametreleri nesne oluşturulduktan sonra da belirtilebilir
                komut.Connection = baglanti; //MySqlCommand nesnesinin bağlantısı belirlenir
                komut.CommandText = "Select * From ogrenciler Where ad LIKE '"+aranacakKelime+"%'"; // Çalıştırılacak arama sorgusu
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komut);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);// Sorgudan dönen değer DataTable nesnesine doldurulur
                baglanti.Close();
                gridOgrenci.DataSource=dataTable; // DataTable içerisine aktarılan veriler DataGridView'de listelenir.
                            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message, "Hata oluştu",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}