using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_自增自减运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 5;
            //    a++;//让自身增加1
            //a++;
            //Console.WriteLine(a);
            ////if放入另一个表达式
            //int b = 5;
            //int c = b++//先自增再赋值or先赋值再自增
            //    //int c =b++先赋值 int c =++b先自增

            int a = 5;
            a++;
                Console.WriteLine(a);
            Console.WriteLine(++a);


        }
    }
}
