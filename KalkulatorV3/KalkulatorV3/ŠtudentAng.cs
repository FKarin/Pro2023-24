using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorV3
{
    internal class ŠtudentAng : Študent
    {
        public override string Izpis()
        {
            return "*********ŠTUDENT/KA ANGLEŠČINE*********\n" +
                "Delni izpit 1: " + Delni1 + "\n" +
                "Delni izpit 2: " + Delni2 + "\n" +
                "Seminarska:    " + Seminar + "\n" +
                "Ustna:         " + Ustna + "\n" +
                "Končna ocena:  " + KončnaOcena() + "\n" +
                "Črka:          " + Črka();
        }

        public override double KončnaOcena()
        {
            return Delni1 * 0.25 + Delni2 * 0.25 + Seminar * 0.3 + Ustna * 0.2;
        }

        public override string Črka()
        {
            if (KončnaOcena() >= 93)
                return "A";
            if (KončnaOcena() >= 85)
                return "B";
            if (KončnaOcena() >= 78)
                return "C";
            if (KončnaOcena() >= 70)
                return "D";
            return "F";
        }
    }
}
