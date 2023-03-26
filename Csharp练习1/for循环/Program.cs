using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for循环
{
    class Program
    {
        static void Main(string[] args)
        { //{for(int i = 1; i<=20; i++)
          //    {
          //        Console.Write("*");
          //    }


            //for (int i = 1; i <=100; i++)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            Console.WriteLine(i);

            //        }
            //    }

            //int n = Convert.ToInt32(Console.ReadLine());
            //int m = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //for (int i = n; i <= m; i++)
            //{
            //    if (i % 17 == 0)
            //    {

            //        sum += i;


            //    }


            //}


            //for (int i = n; i > m; i++)
            //    {
            //        if (i % 17 == 0)
            //        {

            //        sum += i;

            //    }

            //    }
            //Console.WriteLine(sum);
            //int n = Convert.ToInt32(Console.ReadLine());
            //int m = Convert.ToInt32(Console.ReadLine());
            //string 奇数 = " ";//string定义一个字符串
            //string 偶数 = " ";
            //for(int i = n; i<m; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        奇数 += i + " ";

            //    }
            //    else
            //    {
            //        偶数 += i + " ";
            //    }
            //}
            //Console.WriteLine(奇数 );
            //Console.WriteLine(偶数);
            ////

            //int q = Convert.ToInt32(Console.ReadLine());
            //int n = Convert.ToInt32(Console.ReadLine());
            //int sum = 1;
            //int temp = 1;
            //for (int i = 1; i<=n; i++)
            //{
            //    temp  *= q;
            //    sum += temp ;
            //}
            //Console.WriteLine(sum );

            //int n = 0;
            //int K = Convert.ToInt32(Console.ReadLine());

            //double Sn = 0;
            //while (n <= K)
            //{
            //    n++;
            //    Sn += 1 / n;

            //}
            //Console.WriteLine(n);

            int R = Convert.ToInt32(Console.ReadLine());
            int M = Convert.ToInt32(Console.ReadLine());
            int Y = Convert.ToInt32(Console.ReadLine());
            
            for(int i = 1; i <= Y; i++)
            {
                M += M * R / 100;

            }
            Console.WriteLine(M);
        }
        }
    }

