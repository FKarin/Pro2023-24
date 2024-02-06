using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaAbs
{
    internal class LetniDelavec : DelavecBazni
    {
        double letnaPlača;
        public LetniDelavec(string d, string i, double p):base(d,i)
        {
            letnaPlača = p;
        }
        public override double BrutoPlača
        {
            get
            {
                brutoPlača = letnaPlača / 12;
                return brutoPlača;
            }
        }

        public override void Izpis()
        {
            Console.WriteLine("***************DELAVEC***************");
            Console.WriteLine("ID:            " + delID);
            Console.WriteLine("Ime:           " + ime);
            Console.WriteLine("Letna plača:   " + letnaPlača);
            Console.WriteLine("Bruto plača:   " + BrutoPlača);
            Console.WriteLine("*************************************");
        }
    }
}
