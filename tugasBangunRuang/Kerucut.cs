using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BangunRuang
{
    class Kerucut
    {
        private double r, s, luas;

        public double jarijari
        {
            get { return r; }
            set
            {
                r = value;
            }
        }

        public double sisi
        {
            get { return s; }
            set
            {
                s = value;
            }
        }

        public double luas_kerucut()
        {
            luas = 3.14 * r * s;
            return luas;
        }
    }
}
