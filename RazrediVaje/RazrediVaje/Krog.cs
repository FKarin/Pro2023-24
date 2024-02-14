using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RazrediVaje
{
    internal class Krog
    {
        private int x, y;
        private float r;

        public int X { get => x; set => x= value; }
        public int Y { get => y; set => y = value; }
        public float Radij { get => r; set => r = value; }

        public Krog(int x, int y, float r)
        {
            this.x = x;
            this.y = y;
            this.r = r;
        }

        public double Premer()
        {
            return r * 2;
        }
        public double Ploščina()
        {
            return Math.PI * r * r;
        }
    }
}
