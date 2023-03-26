using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bool类型判断
{
    class Program
    {
        static void Main(string[] args)
        {//&&为和 ||为或 ！为反
            bool a = (4 > 3) && (7 > 6);
            bool b = (4 > 3) || (7 < 6);
            bool c = !(4 < 3);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
