using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorphism1
{
    class Daire:Sekil
    {
        public override void Ciz()
        {
            MessageBox.Show("Daire çizildi");
        }
    }
}
