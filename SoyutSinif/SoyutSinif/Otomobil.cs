using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoyutSinif
{
    public class Otomobil:MotorluArac
    {
        
        public override void Calis()
        {
            MessageBox.Show("Otomobil çalıştı.");
        }
        public override void Dur()
        {
            MessageBox.Show("Otomobil durdu.");
        }
    }
}
