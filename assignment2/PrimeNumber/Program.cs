using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//用“埃氏筛法”求2~ 100以内的素数。
namespace Project3
{
    class program
    {
        static void PrimeNumber(int[] a)
        {
            int n = a.Length;
            for(int i = 0; i < n; i++)
            {
                if (i == 0 || i == 1) { a[i] = 0; }
                else { a[i] = 1; }
            }
            
            int p = 2;
            while (p <= Math.Sqrt(n))
            {
                for(int i = p*p; i < n; i++)
                    if (i % p == 0) { a[i] = 0; }
                int j = p + 1;
                for (; j < p * p && a[j] == 0; j++) ;
                if (j < p * p) { p = j; }
                else { return; }  
            }
        }
        
        static void Main()
        {
            int[] a = new int[101];

            PrimeNumber(a);

            Console.Write("2至100以内的素数：");
            for(int i = 0; i < 101; i++)
                if (a[i] == 1) { Console.Write($"{i} "); }

        }
    }
}