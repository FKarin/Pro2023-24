using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorV3
{
    internal class ŠtudentMat : Študent
    {
        public override string Izpis()
        {
            return "*********ŠTUDENT/KA MATEMATIKE*********\n"+
                "Delni izpit 1: "+ Delni1 +"\n"+
                "Delni izpit 2: " + Delni2 + "\n" +
                "Končna ocena:  "+KončnaOcena()+"\n"+
                "Črka:          "+Črka();
        }

        public override double KončnaOcena()
        {
            return 0.5 * Delni1 + 0.5 * Delni2;
        }

        public override string Črka()
        {
            if (KončnaOcena() >= 90)
                return "A";
            if (KončnaOcena() >= 83)
                return "B";
            if (KončnaOcena() >= 76)
                return "C";
            if (KončnaOcena() >= 65)
                return "D";
            return "F";
        }
    }
}
