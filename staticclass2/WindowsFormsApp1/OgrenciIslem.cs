using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class OgrenciIslem
    {
        public List<Ogrenci> ogrenciler;
        public static int OgrenciSayisi { get; set; }
        static OgrenciIslem()
        {
            OgrenciSayisi = 0;
            MessageBox.Show("Statik yapıcı çalıştı.");
        }
        public OgrenciIslem()
        {
            ogrenciler = new List<Ogrenci>();
            MessageBox.Show("Yapıcı çalıştı.");
        }
        public void OgrenciEkle(Ogrenci ogr)
        {
            ogrenciler.Add(ogr);
            OgrenciSayisi++;
            MessageBox.Show("Öğrenci eklendi.");
        }
        public void OgrenciSil(int numara)
        {
            var ogr = ogrenciler.FirstOrDefault(x => x.Numara == numara);
            if (ogr != null)
            {
                ogrenciler.Remove(ogr);
                OgrenciSayisi--;
                MessageBox.Show("Öğrenci silindi.");
            }
        }
    }
}
