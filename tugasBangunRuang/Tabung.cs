using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BangunRuang
{
    class Tabung
    {
        private double r, t, luas;

        public double jarijari
        {
            get { return r; }
            set 
            { 
                r = value; 
            }
        }

        public double tinggi
        {
            get { return t; }
            set 
            { 
                t = value; 
            }
        }

        public double luas_tabung()
        {
            luas = 2 * 3.14 * r * t;
            return luas;
        }
    }
}
