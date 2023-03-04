using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//输出用户指定数据的所有素数因子。
namespace Project1
{
    class program
    {
       static void PrimeFactor(int x,int[] primes,out int l)
        {
            l = 0;
            //认为整数小于等于1时无素数因子，标记primes[0]为0
            if (x<=1) { 
                primes[0] = 0;
                return;
            }
            for(int i = 2; i <= x; i++)
            {
                while (x % i == 0)
                {
                    primes[l] = i;
                    l++;
                    x = x / i;
                }
            }
            return;
        }
        
        static void Main(string[] args)
        {
            string s = "";
            int x = 0;  //输入的整数
            int l;  //素数因子个数
            int[] primes=new int[31];  //素数因子数组

            Console.Write("Please enter an integer number:");
            s = Console.ReadLine();
            x = Int32.Parse(s);
            
            PrimeFactor(x,primes,out l);

            if (primes[0] == 0){Console.Write("no prime factor");}
            else
            {
                Console.Write("prime factors: ");
                for(int i = 0; i < l; i++) { 
                    Console.Write($"{primes[i]} ");
                }
            }

        }
    }
}