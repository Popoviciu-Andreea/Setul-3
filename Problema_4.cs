using System;
//4. Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea. 
namespace Problema_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int []v = { 21, 3, 3, 24, 25, 25, 25, 30 };
            int min = int.MaxValue;
            int nrmax = 0, nrmin = 0;
            int max=int.MinValue;
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] < min)
                {
                    min = v[i];
                    nrmin = 1;
                }
                else
                if (v[i] == min)
                    nrmin++;

                    if (v[i] > max)
                {
                    max = v[i];
                    nrmax = 1;
                }
                else
                if (v[i] == max)
                    nrmax++;
            }
            Console.WriteLine($"Cea mai mica valoare este {min} si apare de {nrmin} ori");
            Console.WriteLine($"Cea mai mare valoare este {max} si apare de {nrmax} ori");





        }
    }
}
