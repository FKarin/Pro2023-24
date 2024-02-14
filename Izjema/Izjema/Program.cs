using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izjema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //uporabnik vnese 2 števili in jaz izračunam in izpišem količnik
                Console.WriteLine("Vnesi deljenec od 1-100:");
                int deljenec = int.Parse(Console.ReadLine());
                if (deljenec > 100 || deljenec < 1)
                    throw new Exception("Deljenec ni med 1-100.");
                Console.WriteLine("Vnesi deljitelja od 1-10:");
                int deljitelj = int.Parse(Console.ReadLine());
                if (deljitelj > 10 || deljitelj < 1)
                    throw new Exception("Deljitelj ni med 1-10.");
                int količnik = deljenec / deljitelj; //deljenje z 0 v double naredi ?
                Console.WriteLine("Količnik je " + količnik);
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Deljenje z 0 ni dovoljeno.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Napačen vnos.");
            }
            catch(Exception x)
            {
                Console.WriteLine(x.Message);
            }
            finally //se izvede tudi če je catch ali ne
            {
                Console.WriteLine("Hvala, ker ste računali z nami.");
            }
        }
    }
}
