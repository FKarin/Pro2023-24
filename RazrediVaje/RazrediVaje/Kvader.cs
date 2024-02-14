using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazrediVaje
{
    internal class Kvader : Pravokotnik
    {
        private float vK;
        public float VišinaK { get => vK; set => vK = value; }
        public Kvader(int x1K, int y1K, int x2K, int y2K, float vK) : base(x1K, y1K, x2K, y2K)
        {
            this.vK = vK;
        }
        public double Površina()
        {
            return 2 * (StranicaA() * StranicaB() + StranicaB() * vK + StranicaA() * vK);
        }
        public double Volumen()
        {
            return StranicaA() * StranicaB() * vK;
        }
    }
}
