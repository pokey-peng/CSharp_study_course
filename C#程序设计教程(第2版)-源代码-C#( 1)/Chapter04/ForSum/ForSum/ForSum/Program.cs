using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int sumOdd = 0; int sumEven = 0;
            for (i = 1; i <= 100; i += 2) sumOdd += i;
            for (i = 2; i <= 100; i += 2) sumEven += i;
            Console.WriteLine(sumOdd);
            Console.WriteLine(sumEven);
            Console.ReadKey();
        }
    }
}
