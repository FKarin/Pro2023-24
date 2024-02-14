using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabele2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3, 4]; //3x4 tabela
            int[,] b = {
                {1, 2, 3},
                {9, 8, 7},
                {2, 1, 2}
            };
            //izpis
            for(int vrstica = 0; vrstica < b.GetLength(0); vrstica++)
            {
                for(int stolpec = 0; stolpec < b.GetLength(1); stolpec++)
                    Console.Write(b[vrstica,stolpec] + "\t");
                Console.WriteLine();
            }
            int[,,] c = new int[5, 2, 3];
        }
    }
}
