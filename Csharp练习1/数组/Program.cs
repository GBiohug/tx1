using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组
{
    class Program
    {
        static void Main(string[] args)
        {//声明数组 1.声明 2.赋值
         //int[] ages = { 34, 12, 5, 23, 53, 43, 12, 2, 34, 65 };
         ////数组的数据有下标，自0开始排列（索引)
         ////数组名[索引]
         //Console.WriteLine(ages [1]);

            ////赋值方式
            ///

            //int[] ages = new int[10];//默认值
            //Console.Write(ages[4]);

            //两种声明方法
            //int[] ages = {}
            //ages = new int[]{}
            //**创建和赋值应该在同一行

            //int[] ages = { 1, 23, 23, 43, 52, 52, 25, 45, 4, 32 };
            //ages[4] = 25;
            //Console.WriteLine(ages [4]);

            //int[] intarray = new int[9];//默认赋值0
            //char[] chararray = new char[20];
            //float[] floatarray = new float[15];

            //数组遍历
            //int[] ages = { 1, 23, 23, 43, 52, 52, 25, 45, 4, 32 };
            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.Write (ages[i]+" ");
            //}

            //运用foreach遍历
            //int[] ages = { 1, 23, 23, 43, 52, 52, 25, 45, 4, 32 };
            //foreach (int temp in ages)
            //{
            //    Console.Write(temp + " ");
            //}//in为取的所有元素，ages作为被取元素的数组

            ////可以通过.length获取数组长度
            //Console.WriteLine(ages .Length );





            //字符串数组@@@！！！！
            string name = "Micheal";
            Console.Write(name.Length);//输出字符串的长度
            Console.Write(name[3]);//输出索引为3的字符
            for(int i= 0; i<=name.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine(name[i]);
            }

            //调用方法 对象名字.方法名（）
        }
    }
}
