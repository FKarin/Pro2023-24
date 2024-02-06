using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KraljestvoŽivali
{
    internal class Žival
    {
        protected string opis;
        protected string ime;
        public void Oglašanje()
        {
            string glas = ((IGovor)this).Govor();
            Console.WriteLine(glas);
        }
    }
}
