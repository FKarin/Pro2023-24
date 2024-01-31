using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedovanje
{
    internal class LDelavec:Delavec
    {
        private double letnaPlača;

        public double LetnaPlača { get => letnaPlača; set => letnaPlača = value; }
        public double BrutoPlača
        {
            get
            {
                brutoPlača = štUr * urnaPostavka;
                return brutoPlača;
            }
        }
        public void Izpis()
        {
            Console.WriteLine("****** DELAVEC ******");
            Console.WriteLine("ID:            " + delID);
            Console.WriteLine("Ime:           " + ime);
            Console.WriteLine("Letna plača:   " + LetnaPlača);
            Console.WriteLine("Bruto plača:   " + BrutoPlača);
        }
    }
}
