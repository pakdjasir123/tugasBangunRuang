using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BangunRuang
{
    class Bola
    {
        private double r, luas;

        public double jarijari
        {
            get { return r; }
            set
            {
                r = value;
            }
        }

        public double luas_bola()
        {
            luas = 4 * 3.14 * r * r;
            return luas;
        }
    }
}
