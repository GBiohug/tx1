using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_5练习作业
{
    class Program
    {
        static void Main(string[] args)
        {//计算器
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(a + b);


            ////平均数
            //double  a = Convert.ToInt32(Console.ReadLine());
            //double  b = Convert.ToInt32(Console.ReadLine());
            //double c = (a + b) / 2;
            //Console.WriteLine(c);//将所有数据定义为double则可算小数

            ////a钱分b人
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(a/b);

            //复习1
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(a+b);

            //交换变量
            //int a = 5;
            //    int b = 10;
            ////if交换变量,需要新变量c作为媒介（临时变量）
            //int c = a;
            //a = b;
            //b = c;

            //不利用中间变量交换变量
            //int a = 5, b = 10;
            //a = a + b;
            //b = a - b;
            //a = a - b;
            //Console.WriteLine(a);//实现交换

            //输出算式
            //int a = 12, b = 46;
            //Console.WriteLine(a+"+"+b+"="+(a+b));
            ////复杂，进行格式化输出
            //Console.WriteLine("{0}+{1}={2}",a,b,a+b);
            ////利用索引 0为起点


            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("个位数为"+a%10+"十位数为"+a/10);


            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("百分位为"+a/100+"十分位为"+a/10%10+"个位为"+a%10);

            //    %得出的结果为余数， /得出的结果为余后的得数
            

            
            










        }
    }
}
