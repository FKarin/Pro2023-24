using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] barve = { "Srce","Karo","Pik","Križ"};
            string[] vrednosti = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Fant", "Kaval", "Dama", "Kralj", "As" };
            string[] kupKart = new string[barve.Length * vrednosti.Length];
            for (int i = 0; i < barve.Length; i++)
            {
                for (int j = 0; j < vrednosti.Length; j++)
                {
                    kupKart[i * vrednosti.Length + j] = barve[i] + " " + vrednosti[j];
                }
            }
            for (int i = 0; i < kupKart.Length; i++)
            {
                Console.WriteLine(kupKart[i]);
            }
            Random r = new Random();
            for (int i = 0; i < kupKart.Length; i++)
            {
                int nakIndex = i + r.Next(kupKart.Length - i);
                string temp = kupKart[i];
                kupKart[i] = kupKart[nakIndex];
                kupKart[nakIndex] = temp;
            }
            Console.WriteLine();
            for (int i = 0; i < kupKart.Length; i++)
            {
                Console.WriteLine(kupKart[i]);
            }
        }
    }
}
