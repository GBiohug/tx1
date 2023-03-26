using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 猜数字
{
    class Program
    {
        static void Main(string[] args)
        {
            //随机数的生成Random
            Random rd = new Random();
            //rd.Next(1, 10); //不包含10，包含1，则为1~9
            //Console.WriteLine(rd.Next (1,10));

            int number = rd.Next(1, 10);
            while (true)
            {
                Console.WriteLine("guess the number");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n>number)
                {
                    Console.WriteLine("偏大");

                }
                if (n < number)
                {
                    Console.WriteLine("偏小");
                }
                if(n==number )
                {
                    Console.WriteLine("中了");
                    break;
                }
            }
        }
    }
}
