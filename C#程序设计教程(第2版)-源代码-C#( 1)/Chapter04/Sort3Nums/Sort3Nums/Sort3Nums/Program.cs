using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort3Nums
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 10, c = 5,t;
            if (a < b) { t = a; a = b; b = t; }//交换a、b，使得a>b
            if (a < c) { t = a; a = c; c = t; }//交换a、c，使得a>c
            if (b < c) { t = b; b = c; c = t; }//交换b、c，使得b>c
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            a = 1; b = 10; c = 5;
            int Nmax,Nmin,Nmid;
            Nmax = Math.Max(Math.Max(a, b), c); //三者最大数
            Nmin = Math.Min(Math.Min(a, b), c); //三者最小数
            Nmid = a + b + c - Nmax - Nmin;       //三者中间数
            a = Nmax; b = Nmid; c = Nmin;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.ReadKey();

        }
    }
}
