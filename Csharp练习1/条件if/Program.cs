using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 条件if
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            //if (a%2==1)
            //{
            //    Console.WriteLine("奇数");

            //}
            //else
            //{
            //    Console.WriteLine("偶数");
            //}
            //Console.WriteLine("程序结束");


            //if (a >= 18 && a <= 32 && a % 2 == 1)
            //{ Console.WriteLine("可以进入"); }
            //else
            //{ Console.WriteLine("不能进入"); }


            //if (a >= 18 && a <= 32) 
            //{
            //    Console.WriteLine("可以参加活动");
            //    if (a % 2 == 1)
            //    {
            //        Console.WriteLine("获得奖品");
            //    }
            //    else
            //    {
            //        Console.WriteLine("无法获得奖品");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("不可以参加活动");
            //}


            if (a >= 90)
            {
                Console.WriteLine("A");
            }else if (a >= 80)
            {
                Console.WriteLine("B");
            }else if (a >= 70)
            {
                Console.WriteLine("C");
            }else if (a >= 60)
            {
                Console.WriteLine("D");
            }
        } 
       
      

    }
}
