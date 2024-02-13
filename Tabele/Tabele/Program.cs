using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Tabele
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tabele
            //int[] tab = new int[10];
            //int[] tab2 = { 80, 3, 7, 9, 1, 5, 6, 84, 15 };
            //bool[] jeRes = new bool[100];
            //tab2[0] = 17;
            //tab2[2 * 3 + 5] = 22;
            //for (int i = 0; i < tab2.Length; i++)
            //    Console.Write(tab2[i] + "\t");
            //Console.WriteLine();

            //izračunaj vsoto elementov tabele a
            //int vs = 0;
            //for (int i = 0; i < tab2.Length; i++)
            //    vs += tab2[i];
            //Console.WriteLine("Vsota je " + vs);

            //izračunaj minimum
            //int min = tab2[0];
            //int imin = 0;
            //for (int i = 0; i < tab2.Length; i++)
            //{
            //    if (tab2[i] < min)
            //    {
            //        min = tab2[i];
            //        imin = i;
            //    }
            //}
            //Console.WriteLine("Minimum število je " + min + " na indexu " + imin);

            //kako naj zamenjam 0 - ti in 5 - ti element tabele
            //int temp = tab2[0];
            //tab2[0] = tab2[5];
            //tab2[5] = temp;
            //for (int i = 0; i < tab2.Length; i++)
            //    Console.Write(tab2[i] + "\t");
            //Console.WriteLine();

            //algoritmi
            //int[] tab = { 80, 3, 7, 9, 1, 5, 6, 84, 15 };
            int[] tab = new int[100000];
            Random r = new Random();
            for (int i = 0; i < tab.Length; i++)
                tab[i] = r.Next(100000);
            //urejanje z izbiranjem
            //Console.WriteLine("Neurejena ");
            //Izpiši(tab);
            //poišči najmanjšega v tab in zamenjaj s prvim
            DateTime pred = DateTime.Now;
            for (int j = 0; j < tab.Length - 1; j++)
            {
                int min = tab[j];
                int imin = j;
                for (int i = j + 1; i < tab.Length; i++)
                {
                    if (tab[i] < min)
                    {
                        min = tab[i];
                        imin = i;
                    }
                }
                //zamenjava najmanjšega s prvim
                int temp = tab[j];
                tab[j] = tab[imin];
                tab[imin] = temp;
                //Izpiši(tab);
            }
            DateTime po = DateTime.Now;
            double čas = (po - pred).TotalMilliseconds;
            Console.WriteLine("Urejanje z izbiranjem: "+čas);

            //urejanje z vstavljanjem
            for (int i = 0; i < tab.Length; i++)
                tab[i] = r.Next(100000);
            pred = DateTime.Now;
            for (int i = 1; i < tab.Length; i++)
            {
                int j = i; int temp = tab[i];
                //pogrezni i-ti element na pravo mesto v tab od tab[0] do tab[i-1]
                //element sodi na mesto j
                while (j > 0 && tab[j - 1] > temp)
                {
                    tab[j] = tab[j - 1];
                    j--;
                }
                tab[j] = temp;
                //Izpiši(tab);
            }
            po = DateTime.Now;
            čas = (po - pred).TotalMilliseconds;
            Console.WriteLine("Urejanje z vstavljanjem: " + čas);
        }
        static void Izpiši(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i] + "\t");
            }
            Console.WriteLine();
        }
    }
}
