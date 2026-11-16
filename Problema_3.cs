using System;
using System.Xml.Schema;
/*3. Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al 
vectorului.Pentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau 
caz).
*/
namespace Problema_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int i = 0;
            for (i = 0; i < n; i++)
            { Console.Write($"v[{i}]=");
                v[i] = int.Parse(Console.ReadLine());
            }
            
            int min = v[0], max = v[0], poz_min = 0, poz_max = 0;
            if (n % 2 == 0)
            {
                if (v[0] < v[1])
                {
                    min = v[0];
                    max = v[1];
                    poz_max = 1;
                    poz_min = 0;
                }

                else
                {
                    min = v[1];
                    max = v[0];
                    poz_min = 1;
                    poz_max = 0;
                }
                i = 2;
            }
            if(n%2!=0)
            {
                min = v[0];
                max = v[0];
                i = 1;
            }
                while(i<n-1)
            {
                if (v[i] < v[i + 1])
                {
                    if (v[i] < min) { min = v[i]; poz_min = i; }
                    if (v[i + 1] > max) { max = v[i + 1]; poz_max = i+1; }
                }
                else
                {
                    if (v[i + 1] < min) { min = v[i + 1]; poz_min = i+1; }
                    if (v[i] > max) { max = v[i]; poz_max = i; }
                }
                i += 2;
            }
            Console.WriteLine($"Pozitia pe care apare cel mai mic este:{poz_min} iar pozitia pe care apare cel mai mare este:{poz_max}");
        }
    }
}
