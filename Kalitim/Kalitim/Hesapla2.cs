using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    internal class Hesapla2:Hesapla
    {
        //public override double topla(double a, double b)
        //{
        //    return 3 * (a + b);                                     //Override Komutu 
        //                                                            //http://msdn.microsoft.com/en-us/library/hfw7t1ce.aspx
        //}
        public override double topla(double a, double b)
        {
            return base.topla(a, b);                                //Base Kullanımı
        }
    }
}
