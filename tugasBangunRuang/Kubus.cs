using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BangunRuang
{
    class Kubus
    {
        private double s, luas;

        public double sisi
        {
            get { return s; }
            set
            {
                s = value;
            }
        }

        public double luas_kubus()
        {
            luas = 6 * s * s ;
            return luas;
        }
    }
}
