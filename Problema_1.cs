using System;
//1. Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran. 
namespace Problema_1
{
    internal class Program
    {
        static void Main(string[] args)
        {int n=int.Parse(Console.ReadLine());
            int[] v = new int[n];int s = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"v[{i}]=");
                v[i] = int.Parse(Console.ReadLine());
                    s += v[i];
            }
            
            Console.WriteLine(s);
        }
    }
}
