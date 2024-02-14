using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtentikator
{
    internal class Avtentikator
    {
        private string geslo;

        public static uint minDolžinaGesla = 9;
        public string Geslo { get => geslo; }

        public Avtentikator()
        {
            geslo = "";
        }

        public Avtentikator(string s)
        {
            geslo = s;
        }

        public bool JeGesloPravilno(string s)
        {
            if (s == geslo)
                return true;
            return false;
        }

        public bool SpremeniGeslo(string staroGeslo, string novoGeslo)
        {
            if(staroGeslo == geslo && novoGeslo.Length == minDolžinaGesla)
            {
                geslo = novoGeslo;
                return true;
            }
            return false;
        }
    }
}
