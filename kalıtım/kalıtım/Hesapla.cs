using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kalıtım
{
    class Hesapla:Dortislem
    {
        public double fonksiyon(double a, double b)
        {
            return (4*(a + b))/7;
        }
        //new public double topla(double a, double b)
        //{
        //    return 5 + 8;                              // NEW YÖNTEMİ
        //}
        public virtual double topla(double a, double b)
        {
            return 2 * (a + b);                         //Virtual Komutu
        }
      

    }
}
