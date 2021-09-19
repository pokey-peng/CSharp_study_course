using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedLoop2
{
    class Program
    {
        static void Main(string[] args)
        {
            String s;
            // 下三角
            Console.WriteLine();
            Console.WriteLine("                          九九乘法表");
            for (int i = 1; i <= 9; i++)
            {
                s = "";
                for (int j = 1; j <= i; j++)
                {
                    s += (String.Format("{0}*{1}={2}", i, j, i * j)).PadRight(8);
                }
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
