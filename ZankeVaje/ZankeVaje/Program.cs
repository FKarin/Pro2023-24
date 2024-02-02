using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZankeVaje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.naloga
            //int j = 0;
            //for (int i = 65; i <= 90; i++)
            //{
            //    Console.Write((char)i + "(" + i + ")  ");
            //    j++;
            //    if (j % 10 == 0)
            //        Console.WriteLine();
            //}
            //for (int i = 97; i <= 122; i++)
            //{
            //    Console.Write((char)i + "(" + i + ")  ");
            //    j++;
            //    if (j % 10 == 0)
            //        Console.WriteLine();
            //}

            //2. naloga
            //double vsota = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    vsota = vsota + Math.Sin(Math.PI / i);
            //}
            //Console.WriteLine(vsota);

            //3. naloga
            //Console.WriteLine("Vnesi X:");
            //double x = double.Parse(Console.ReadLine());
            //double vsota = 1;
            //double člen = 1;
            //for (int i = 1; i <= 100; i++)
            //{
            //    člen *= x / i;
            //    vsota += člen;
            //}
            //Console.WriteLine(vsota);
            //int j = 1;
            //while (Math.Abs(vsota - Math.Exp(x)) > 0.000001)
            //{
            //    člen *= x / j;
            //    vsota += člen;
            //    j++;
            //}
            //Console.WriteLine(vsota);

            //4. naloga
            Console.WriteLine("Vnesi hex. število.");
            string št = Console.ReadLine().ToUpper();
            int potenca = 1, vsota = 0;
            for (int i = št.Length-1; i >= 0; i--)
            {
                int cifra = 0;
                switch (št[i])
                {
                    case '0': cifra = 0; break;
                    case '1': cifra = 1; break;
                    case '2': cifra = 2; break;
                    case '3': cifra = 3; break;
                    case '4': cifra = 4; break;
                    case '5': cifra = 5; break;
                    case '6': cifra = 6; break;
                    case '7': cifra = 7; break;
                    case '8': cifra = 8; break;
                    case '9': cifra = 9; break;
                    case 'A': cifra = 10; break;
                    case 'B': cifra = 11; break;
                    case 'C': cifra = 12; break;
                    case 'D': cifra = 13; break;
                    case 'E': cifra = 14; break;
                    case 'F': cifra = 15; break;
                }
                vsota += cifra * potenca;
                potenca = potenca * 16;
            }
            Console.WriteLine("Desetško je " + vsota);
            Console.ReadLine();
        }
    }
}