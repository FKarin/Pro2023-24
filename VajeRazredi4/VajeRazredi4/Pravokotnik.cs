using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajeRazredi4
{
    internal class Pravokotnik
    {
        private double dolžina, širina;
        public double Dolžina { get => dolžina; }
        public double Širina { get => širina; }
        public Pravokotnik(double d, double š)
        {
            dolžina = d;
            širina = š;
        }
        public double GetArea()
        {
            return dolžina * širina;
        }

        public double GetPerimeter()
        {
            return 2 * dolžina + 2 * širina;
        }

        public bool IsSquare()
        {
            if (dolžina == širina)
                return true;
            return false;
        }

    }
}
