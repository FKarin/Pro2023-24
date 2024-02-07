using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorV3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesi oddelek študenta: (1 = ANG, 2 = MAT, 3 = NAR)");
            int oddelek = int.Parse(Console.ReadLine());
            switch (oddelek)
            {
                case 1:
                    ŠtudentAng ša = new ŠtudentAng();
                    Console.WriteLine("Vnesi oceno delni 1:");
                    ša.Delni1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Vnesi oceno delni 2:");
                    ša.Delni2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Vnesi seminarsko:");
                    ša.Seminar = int.Parse(Console.ReadLine());
                    Console.WriteLine("Vnesi ustno:");
                    ša.Ustna = int.Parse(Console.ReadLine());
                    Console.WriteLine(ša.Izpis());
                    break;
                case 2:
                    ŠtudentMat šm = new ŠtudentMat();
                    Console.WriteLine("Vnesi oceno delni 1:");
                    šm.Delni1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Vnesi oceno delni 2:");
                    šm.Delni2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(šm.Izpis());
                    break;
                case 3:
                    ŠtudentNar šn = new ŠtudentNar();
                    Console.WriteLine("Vnesi oceno delni 1:");
                    šn.Delni1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Vnesi oceno delni 2:");
                    šn.Delni2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Vnesi seminarsko:");
                    šn.Seminar = int.Parse(Console.ReadLine());
                    Console.WriteLine(šn.Izpis());
                    break;

            }
        }
    }
}
