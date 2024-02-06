using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KraljestvoŽivali
{
    internal class Pes : Žival, IGovor
    {
        public string Govor()
        {
            return "Hov!";
        }
        public Pes()
        {
            opis = "pes";
            ime = "Pika";
        }
        public void Izpis()
        {
            Console.WriteLine("Vrsta živali: " + opis);
            Console.WriteLine("Ime živali: " + ime);
        }
    }
}
