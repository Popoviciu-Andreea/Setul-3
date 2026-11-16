using System;
/*2. Se da un vector cu n elemente si o valoare k. Se cere sa se determine prima pozitie din 
vector pe care apare k. Daca k nu apare in vector rezultatul va fi -1. 
*/
namespace Problema_2
{
    internal class Program
    {
        static void Main(string[] args)
        {int n=int.Parse(Console.ReadLine());
            int k=int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            bool ok = false;
            for(int i=0;i<n;i++)
            {
                if (v[i] == k)
                {
                    ok = true;
                    Console.WriteLine(i);
                    break;
                }
            }
            if(ok==false)
            Console.WriteLine(-1);
        }
    }
}
