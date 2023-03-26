using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("c:\\a\\b\\d");//因为\为转义字符，无法作为磁盘地址发挥作用，需要\使原\发挥作用
            Console.WriteLine(@"c:\a\b\d");//可以通过"前@使得转义字符直接失效
            string add = @"www.\abc.com";//字符串类型声明————@同时可以使得字符串换行
            
            Console.WriteLine(add);
            //if要在有@表示引号，则需""表示出"
            //如 @""www.abc.com""
            string add1 = @"""www.aaa.com""";
            string sum = add + add1;
            Console.WriteLine(add1);
            Console.WriteLine(sum);
            string num = "188";
            Console.WriteLine(num+"+"+  sum);

                
        }
    }
}
