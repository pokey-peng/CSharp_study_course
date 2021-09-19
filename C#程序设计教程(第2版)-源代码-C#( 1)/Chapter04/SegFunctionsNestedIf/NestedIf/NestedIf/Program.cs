using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedIf
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 0, y1 = 0, y2 = 0, y3 = 0, y4 = 0;
            if (x > 0)
                y1 = 1;
            else if (x == 0)
                y1 = 0;
            else
                y1 = -1;
            Console.WriteLine(y1);

            if (x >= 0)
            {
                if (x > 0)
                    y2 = 1;
                else
                    y2 = 0;
            }
            else
                y2 = -1;
            Console.WriteLine(y2);

            y3 = 1;
            if (x != 0)
            {
                if (x < 0)
                    y3 = -1;
            }
            else
                y3 = 0;
            Console.WriteLine(y3);

            y4 = 1;
            if (x != 0)
                if (x < 0)
                    y4 = -1;
                else
                    y4 = 0;
            Console.WriteLine(y4);
            Console.ReadKey();
        }
    }
}
