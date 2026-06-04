using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoyutSinif
{
    public abstract class MotorluArac
    {
        public int MotorHacmi { get; set; }
        public int ModelYili { get; set; }
        public bool OtomatikVites { get; set; }

        public abstract void Calis();
        public abstract void Dur();
    }
}
