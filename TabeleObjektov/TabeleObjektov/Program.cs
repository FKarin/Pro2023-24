using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabeleObjektov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Napis[] vsi = new Napis[3]; //inicializacija tabele
            //vsi[0] = new Napis(); //inicializira izvod razreda napis
            //vsi[0].Izpiši();
            for (int i = 0; i < vsi.Length; i++)
            {
                vsi[i] = new Napis();
                vsi[i].Izpiši();
            }
        }
    }
}
