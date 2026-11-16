using System;
/*7. Reverse. Se da un vector nu n elemente. Se cere sa se inverseze ordinea elementelor din 
vector. Prin inversare se intelege ca primul element devine ultimul, al doilea devine 
penultimul etc. */
namespace Problema_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[]v=new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            int k = n-1,aux;
            for(int i=0;i<n/2;i++)
            {
               aux = v[k];
                v[k] = v[i];
                v[i] = aux;
                k--;
                
            }
            for (int i = 0; i < n; i++)
                Console.Write($"{v[i]} ");
        }
    }
}
