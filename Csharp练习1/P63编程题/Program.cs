using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P63编程题
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = 100;

            //while (n >= 100 &&n <= 999)
            //{
            //    int bai = n / 100;
            //    int shi = n / 10 % 10;
            //    int ge = n % 100 % 10;
            //    if (n ==bai*bai*bai+shi*shi *shi +ge *ge *ge ) {
            //        Console.WriteLine(n );
            //    }n++;

            //}
            //水仙花数

            //int n = Convert.ToInt32(Console.ReadLine());
            //while  ( n!=0)
            //{
            //    int i = n % 10;
            //    Console.WriteLine(i);
            //    n = n / 10;


            //}


            //for (int i = 0; i <= n; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i <= n; i++)
            //{
            //    for (int j = 0; j <= i - 1; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine("*");

            //}

            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = n; i>0 ; i--)
            //{

            //   for(int j = i-1; j>0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine("*");

            //}

            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i <= n; i++)
            {
                for(int j = 0; j < i - 1; j++)//输出i-1个空格
                {
                    Console.Write(" ");
                }
                for(int k = 1; k < i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }




    }
}
