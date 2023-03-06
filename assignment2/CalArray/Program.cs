using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//求一个整数数组的最大值、最小值、平均值和所有数组元素的和。
namespace Project2
{
    class program
    {
        static void CalArray(int num,int[] a,double[] results)
        {
            results[0] = a[0];
            results[1] = a[0];
            results[3] = a[0];
            for (int i = 1; i < num; i++)
            {
                if (a[i] > results[0]) { results[0] = a[i]; }
                if (a[i] < results[1]) { results[1] = a[i]; }
                results[3] += a[i];
            }
            results[2] = results[3] / num;

        }
        
        static void Main()
        {
            Console.Write("请以“,”分隔输入整数数组：");
			//处理以“,”分隔的整数数组输入
			string INPUT = "";
            INPUT = Console.ReadLine();
            string[] input = INPUT.Split(',');
            int num = input.Length;  //整数数组元素个数
            int[] a = new int[num];  //整数数组
			for(int i = 0; i < num; i++)
            {
                a[i] = int.Parse(input[i]);
            }

            double[] results = new double[4];  //依次存放数组最大值、最小值、平均值、和
            CalArray(num, a, results);

            Console.WriteLine($"最大值：{results[0]}");
            Console.WriteLine($"最小值：{results[1]}");
            Console.WriteLine($"平均值：{results[2]}");
            Console.WriteLine($"元素之和：{results[3]}");
        }
    }
}
