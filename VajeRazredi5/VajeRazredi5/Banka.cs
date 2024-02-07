using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajeRazredi5
{
    internal class Banka
    {
        private double glavnica, obrestnaMera, številoLet;
        public double Glavnica { get => glavnica; set => glavnica = value; }
        public double ObrestnaMera { get => obrestnaMera; set => obrestnaMera = value; }
        public double ŠteviloLet { get => številoLet; set => številoLet = value; }

        public Banka(double g, double om, double šl)
        {
            glavnica = g;
            obrestnaMera = om;
            številoLet = šl;
        }
        public double LetniObračun()
        {
            return glavnica * Math.Pow(1 + obrestnaMera, številoLet);
        }

        public double DnevniObračun()
        {
            return glavnica * Math.Pow(1 + obrestnaMera / 365, številoLet * 365);
        }
    }
}
