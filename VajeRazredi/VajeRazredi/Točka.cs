using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajeRazredi
{
    internal class Točka
    {
        private double x, y, r;
        private int fi;
        public void PretvoriVPolarne()
        {
            r = Math.Sqrt(x * x + y * y);
            fi = (int)(Math.Atan(y / x)*180/Math.PI);
        }
        public void PretvoriVKartezične()
        {
            x = r * Math.Cos(fi * Math.PI / 180);
            y = r * Math.Sin(fi * Math.PI / 180);
        }
        public Točka(double x1, double y1)
        {
            x = x1;
            y = y1;
            PretvoriVPolarne();
        }
        public Točka(double r1, int fi1)
        {
            r = r1;
            fi = fi1;
            PretvoriVKartezične();
        }
    }
}
