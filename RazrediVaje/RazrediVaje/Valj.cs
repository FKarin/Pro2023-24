using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RazrediVaje
{
    internal class Valj:Krog
    {
        private float v;

        public float Višina { get => v; set => v = value; }

        public Valj(int xV, int yV, float rV, float vV):base(xV, yV, rV)
        {
            v = vV;
        }

        public double Površina()
        {
            return 2 * base.Ploščina() + 2 * Math.PI * Radij * Višina;
        }

        public double Volumen()
        {
            return Površina() * Višina;
        }
    }
}
