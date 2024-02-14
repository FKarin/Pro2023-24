using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minolovec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            bool[,] mine = new bool[10 + 2, 10 + 2];
            //napolnimo mine z vrednostmi true, z verjetnosto 0.25
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; ++j)
                {
                    mine[i, j] = r.NextDouble() < 0.25;
                }
            }
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; ++j)
                {
                    if (mine[i,j])
                        Console.Write("*" + "\t");
                    else
                        Console.Write("M" + "\t");
                }
                Console.WriteLine();
            }
            int[,] rešitev = new int[10 + 2, 10 + 2];
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    //izračunaj koliko min je v okolici pozicije (i,j)
                    for(int z = i-1; z <= i + 1; z++)
                    {
                        for(int w = j-1; w <= j+1; w++)
                        {
                            if (mine[z, w])
                                rešitev[i, j]++;
                        }
                    }
                }
            }
            Console.WriteLine();
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; ++j)
                {
                    if (mine[i, j])
                        Console.Write("*" + "\t");
                    else
                        Console.Write(rešitev[i,j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
