using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*如果矩阵上每一条对角线上的元素都相同，那么这个矩阵是托普利茨矩阵。
给定一个 M x N 的矩阵，当且仅当它是托普利茨矩阵时返回 True。*/
namespace Project4
{
    class program
    {
        static bool IsToplitz(int[,] a,int m,int n)
        {
            for(int k = 0; k < m; k++)
            {
                for(int i=0,j=i+k;i<m&&j<n;)
                {
                    if (a[i,j]!=a[0,k]) { return false; }
                    i++;j++;
                }
                for(int j = 0, i = j + k; i < m && j < n;)
                {
                    if (a[i, j] != a[k, 0]) { return false; }
                    i++;j++;
                }
            }

            return true;
        }
        
        static void Main()
        {
            string s = "";
            int M = 0, N = 0;
       
            Console.Write("请输入矩阵行数M：");
            s = Console.ReadLine();
            M = Int32.Parse(s);
            Console.Write("请输入矩阵列数N：");
            s = Console.ReadLine();
            N = Int32.Parse(s);
            int[,] a = new int[M, N];
            Console.WriteLine($"请输入{M}行含{N}个整数的以“,”分隔的数列");
            for(int i = 0; i < M; i++)
            {
                s = Console.ReadLine();
                string[] input = s.Split(',');
                for(int j = 0; j < N; j++)
                    a[i, j] = Int32.Parse(input[j]);
            }

            if (IsToplitz(a,M,N)) { Console.Write("该矩阵是托普利茨矩阵。"); }
            else { Console.Write("该矩阵不是托普利茨矩阵。"); }
        }
    }
}