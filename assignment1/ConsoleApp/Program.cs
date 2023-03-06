using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            int l = 0, r = 0;
            char oper;
         
            Console.Write("Please input an integer number: ");
            s = Console.ReadLine();
            l = Int32.Parse(s);
            Console.Write("Please input another integer number: ");
            s = Console.ReadLine();
            r = Int32.Parse(s);
            Console.Write("Please input an operator(+,-,*,/,%): ");
            s = Console.ReadLine();
            oper = Char.Parse(s);

            switch (oper)
            {
                case '+': Console.Write($"result:{ l+r}");break;
                case '-': Console.Write($"result:{ l - r}"); break;
                case '*': Console.Write($"result:{ l * r}"); break;
                case '/': Console.Write($"result:{ l / r}"); break;
                case '%': Console.Write($"result:{ l % r}"); break;
                default: Console.Write("Please input the correct operator.");break;

            }

        }
    }
}