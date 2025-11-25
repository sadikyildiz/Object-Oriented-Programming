using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinema
{
    class Sinema
    {
        int toplamKoltukSayisi;
        int bosKoltukSayisi;
        double bakiye;
        string salonNo;

        const double TAM = 150.0;
        const double INDIRIMLI = 100.0;

        public Sinema(string salonn, int koltuksayi) //Kurucu Metot
        {
            toplamKoltukSayisi = koltuksayi;
            salonNo = salonn;
            bosKoltukSayisi = toplamKoltukSayisi;
            bakiye = 0;

        }

        public void BiletSat(bool indirimli) //Bilet Satış
        {
            bosKoltukSayisi--;
            if (indirimli)
                bakiye += INDIRIMLI;
            else
                bakiye += TAM;
        }

        public void BiletIptal(bool indirimli) //Bilet İade
        {
            bosKoltukSayisi++;
            if (indirimli)
                bakiye -= INDIRIMLI;
            else
                bakiye -= TAM;
        }

        public int BosKoltukOgren() //Boş koltuk Sayısı
        {
            return bosKoltukSayisi;
        }

        public double BakiyeOgren() //Bakiye Öğren
        {
            return bakiye;
        }
        ~Sinema() //Yıkıcı Metot
        {
            MessageBox.Show("Program Sonlandırıldı");
        }
    }
}
