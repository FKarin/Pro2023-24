using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajeRazredi3
{
    internal class Oseba
    {
        private string ime;
        private int starost;
        public string Ime { get => ime; }
        public int Starost { get => starost; }

        public Oseba(string i, int s)
        {
            ime = i;
            starost = s;
        }

        public int GetAgeInMonths()
        {
            return starost * 12;
        }

        public bool IsAdult()
        {
            if (starost >= 18)
                return true;
            return false;
        }

        public bool IsEqual(Oseba o)
        {
            if (o.Ime == ime && o.Starost == starost)
                return true;
            return false;
        }
    }
}
