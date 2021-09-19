using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacii
{
    class Program
    {
        static void Main(string[] args)
        {
            int f1 = 1, f2 = 1;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("{0,5}\t{1,5}\t", f1, f2);
                if (i % 2 == 0) Console.WriteLine();
                f1 += f2; f2 += f1;
            }
            Console.ReadKey();
        }
    }
}
