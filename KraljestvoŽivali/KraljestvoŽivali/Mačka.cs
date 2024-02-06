using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KraljestvoŽivali
{
    internal class Mačka : Žival, IGovor
    {
        public string Govor()
        {
            return "Mijav!";
        }
        public Mačka()
        {
            opis = "mačka";
            ime = "Mimi";
        }
        public void Izpis()
        {
            Console.WriteLine("Vrsta živali: "+opis);
            Console.WriteLine("Ime živali: "+ime);
        }
    }
}
