using System;
using System.ComponentModel;
/*5. Se da un vector cu n elemente, o valoare e si o pozitie din vector k. Se cere sa se insereze 
valoarea e in vector pe pozitia k. Primul element al vectorului se considera pe pozitia zero. */
namespace Problema_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n+1];
            for(int i=0;i<n;i++)
                v[i]=int.Parse(Console.ReadLine());
            int e=int.Parse(Console.ReadLine());
            int k=int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (i == k)
                {
                    int aux = v[i];
                    v[i] = e;
                    for (int j = i + 1; j <= n; j++)
                    {
                        int x = v[j];
                        v[j] = aux; ;
                        aux =x;
                    }


                }
            }
            for (int i = 0; i <=n; i++)
            {
                Console.Write($"{v[i]} ");
            }

        }
    }
}
