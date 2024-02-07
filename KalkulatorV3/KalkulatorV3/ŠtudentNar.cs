using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorV3
{
    internal class ŠtudentNar : Študent
    {
        public override string Izpis()
        {
            return "*********ŠTUDENT/KA NARAVOSLOVJA*********\n" +
                "Delni izpit 1: " + Delni1 + "\n" +
                "Delni izpit 2: " + Delni2 + "\n" +
                "Seminarska:    " + Seminar + "\n" +
                "Končna ocena:  " + KončnaOcena() + "\n" +
                "Črka:          " + Črka();
        }

        public override double KončnaOcena()
        {
            return Delni1 * 0.4 + Delni2 * 0.4 + Seminar * 0.2;
        }

        public override string Črka()
        {
            if (KončnaOcena() >= 90)
                return "A";
            if (KončnaOcena() >= 80)
                return "B";
            if (KončnaOcena() >= 70)
                return "C";
            if (KončnaOcena() >= 60)
                return "D";
            return "F";
        }
    }
}
