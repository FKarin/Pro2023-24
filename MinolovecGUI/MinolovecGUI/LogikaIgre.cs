using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinolovecGUI
{
    internal class LogikaIgre
    {
        //minolovec
        Random r = new Random();
        public bool[,] mine;
        public int[,] rešitev;
        //napolnimo tabelo mine z vrednotmi true, z verjetnostjo 0.3
        public LogikaIgre(int n)
        {
            mine = new bool[n + 2, n + 2];
            rešitev = new int[n + 2, n + 2];
            for (int k = 1; k <= n; k++)
            {
                for (int j = 1; j <= n; j++)
                {
                    mine[k, j] = r.NextDouble() < 0.25;
                }
            }
            for (int k = 1; k <= n; k++)
            {
                for (int j = 1; j <= n; j++)
                {
                    //izračunaj koliko min je v okolici pozicije (k,j)
                    for (int z = k - 1; z <= k + 1; z++)
                    {
                        for (int w = j - 1; w <= j + 1; w++)
                        {
                            if (mine[z, w])
                                rešitev[k, j]++;
                        }
                    }
                }
            }
        }
    }
}