using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalE
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1; double e = 1; double t = 1;
            while (1 / t >= Math.Pow(10, -6))
            {
                t *= i; e += 1 / t; i++;
            }
Console.WriteLine(e);
Console.ReadKey();
        }
    }
}
