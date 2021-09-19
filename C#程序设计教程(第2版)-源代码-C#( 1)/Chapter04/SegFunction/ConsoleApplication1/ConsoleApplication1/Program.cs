using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y1 = 0, y2 = 0, y3 = 0, y4 = 0;
            x = -1;
            y1 = Math.Sin(x) + 2 * Math.Sqrt(x + Math.Exp(4)) - Math.Pow(x + 1, 3);
            if (x < 0)
                y1 = Math.Log(-5 * x) - Math.Abs(x * x - 8 * x) / (7 * x) + Math.E;
            Console.WriteLine(y1);

            if (x >= 0)
                y2 = Math.Sin(x) + 2 * Math.Sqrt(x + Math.Exp(4)) - Math.Pow(x + 1, 3);
            if (x < 0)
                y2 = Math.Log(-5 * x) - Math.Abs(x * x - 8 * x) / (7 * x) + Math.E;
            Console.WriteLine(y2);

            if (x >= 0)
                y3 = Math.Sin(x) + 2 * Math.Sqrt(x + Math.Exp(4)) - Math.Pow(x + 1, 3);
            else
                y3 = Math.Log(-5 * x) - Math.Abs(x * x - 8 * x) / (7 * x) + Math.E;
            Console.WriteLine(y3);

            y4 = (x >= 0) ? Math.Sin(x) + 2 * Math.Sqrt(x + Math.Exp(4)) - Math.Pow(x + 1, 3) : Math.Log(-5 * x) - Math.Abs(x * x - 8 * x) / (7 * x) + Math.E;
            Console.WriteLine(y4);

            Console.ReadKey();
        }
    }
}
