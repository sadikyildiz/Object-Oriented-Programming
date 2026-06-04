using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public class Kedi:IHayvan,IBeslen
    {
        public void SesCikar()
        {
            MessageBox.Show("Kedi: miyav");
        }
        public void Beslen()
        {
            MessageBox.Show("Kedi süt içti.");
        }
    }
}
