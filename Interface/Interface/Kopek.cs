using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public class Kopek:IBeslen,IHayvan
    {
        public void SesCikar()
        {
            MessageBox.Show("Köpek: hav hav");
        }
        public void Beslen()
        {
            MessageBox.Show("Köpek et yedi.");
        }
    }
}
