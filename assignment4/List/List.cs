using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    
    class List
    {
        static void Main(string[] args)
        {
            //初始化数列
            List<int> myList = new List<int>();
            string s = "";
            Console.WriteLine("请输入一个以“,”分隔的数列：");
            s = Console.ReadLine();
            string[] input = s.Split(',');
            for (int j = 0; j<input.Length; j++)
            {
                myList.Add(Int32.Parse(input[j]));
            }
              
            //打印数列
            Console.Write("打印数列：");
            myList.ForEach(t => Console.Write($"{t},"));
            Console.WriteLine();

            //求最大值
            int max = 0;
            Action<int> SearchMax = (t)=>
            {
                if (t > max)
                {
                    max = t;
                }
            };
            myList.ForEach(SearchMax);
            Console.WriteLine($"最大值：{max}");

            //求最小值
            int min = 9;
            Action<int> SearchMin = (t) =>
            {
                if (t < min)
                {
                    min = t;
                }
            };
            myList.ForEach(SearchMin);
            Console.WriteLine($"最小值：{min}");

            //求和
            int sum = 0;
            myList.ForEach(t => sum += t);
            Console.WriteLine($"和：{sum}");
        }
    }
}


