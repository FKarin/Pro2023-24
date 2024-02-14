using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajeRazredi7
{
    internal class Tovornjak : Vozilo, IDrivable
    {
        private int nosilnost, vlečnaZmogljivost;
        public double Drive(int km)
        {
            return (100 * km) / PovprečnaPoraba;
        }
    }
}
