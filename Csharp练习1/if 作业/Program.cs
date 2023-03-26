using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_作业
{
    class Program
    {
        static void Main(string[] args)
        {
            //int X = Convert.ToInt32(Console.ReadLine());
            //int Y = Convert.ToInt32(Console.ReadLine());

            //if (X > 0 && Y > 0)
            //{
            //    Console.WriteLine("在第一象限");
            //}
            //if (X > 0 && Y < 0)
            //{
            //    Console.WriteLine("在第四象限");
            //}
            //if (X < 0 && Y > 0)
            //{
            //    Console.WriteLine("在第二象限");
            //}
            // if (X < 0 && Y < 0)
            //{
            //    Console.WriteLine("在第三象限");
            //}if (X == 0 && Y == 0)
            //{
            //    Console.WriteLine("在原点");

            //}if (X != 0 && Y == 0)
            //{
            //    Console.WriteLine("在X轴");
            //}if (Y != 0 && X == 0)
            //{
            //    Console.WriteLine("在Y轴");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if (a < b + c&&b<a+c&&c<a+b)

            {
                Console.WriteLine("可形成三角形");
            }else
            {
                Console.WriteLine("无法形成三角形");
            }

            
        }
    }
}
