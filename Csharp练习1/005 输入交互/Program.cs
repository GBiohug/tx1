using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_输入交互
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.WriteLine (str + "\t你放个大屁");

            //if 输入数字字符串返还数字
            //反例
            // int a = console.readline();
            //cause cr读取的是字符串不可赋值给整数int

            int strint = Convert.ToInt32(str);//只能把数字字符串转换整数（可运算）
            Console.WriteLine(strint + 123);
            //strint对应数字，如输入非法字符则报错


            //！！！！！！THE POINT
            int a = Convert.ToInt32(Console.ReadLine());
            //简写，toint32（）中可读取数据指令
            //意：读取一行数据，将其转换为整数并赋值给a
            Console.WriteLine(a + strint);
        }
    }
}
