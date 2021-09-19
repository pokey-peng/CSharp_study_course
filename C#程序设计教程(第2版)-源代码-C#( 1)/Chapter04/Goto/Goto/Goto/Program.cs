using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goto
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, sum = 0;
        loop:
            if (i <= 100)
            {
                sum += i; i++; goto loop;
            }
        Console.WriteLine(sum);
        Console.ReadKey();
        }
    }
}
