using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexDataBinding2
{
    internal class Kitaplar
    {
        public string KitapAdi { get; set; }
        public string KitapYazari { get; set; }
        public string KitapTuru { get; set; }

        public override string ToString()
        {
            return KitapAdi + " - " + KitapYazari + " - " + KitapTuru;
        }
    }


}
