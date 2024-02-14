using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajeRazredi7
{
    internal class Avto : Vozilo, IDrivable
    {
        private int štVrat;
        private float prostorninaPrtljažnika;
        public double Drive(int km)
        {
            return (100 * km) / PovprečnaPoraba;
        }
    }
}
