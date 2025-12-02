using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refout
{
    internal class Matematik
    {
        public void Artir(int x)
        {
            x++;
        }
        public void Artirout(out int x)
        {
            x = 123;
            x++;
        }
        public void Artirref(ref int x)
        {
            x = 123;
        }
    }
}
