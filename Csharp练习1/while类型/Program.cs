using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while类型
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //int i = 1;
            //while (i <=n)
            //{



            //    sum += i;

            //    i++;
            //}
            //Console.WriteLine(sum);
            //int d = -1;

            //    while (d % 2 != 0&&d<=100)
            //{
            //    d++;
            //    Console.WriteLine(d);
            //    d++;


            //}


            //输入任何值使其归0
            int n = Convert.ToInt32(Console.ReadLine());
            while (n != 1)
            {
                if (n % 2 == 0)
                {
                    n =n/ 2;
                }else
                {
                    n = 3 * n + 1;
                }
                Console.WriteLine(n);
            }
            


        }
    }
}
