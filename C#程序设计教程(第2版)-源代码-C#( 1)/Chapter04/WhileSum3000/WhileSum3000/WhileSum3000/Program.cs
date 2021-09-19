using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileSum3000
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1; int sum = 0;
            while (sum <= 3000)
            {
                sum += i;
                i++;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
