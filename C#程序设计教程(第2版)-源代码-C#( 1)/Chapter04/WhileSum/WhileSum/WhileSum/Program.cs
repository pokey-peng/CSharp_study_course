using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, sum, sumOdd, sumEven;
            i = 1; sum = 0;    // 赋初值
            while (i <= 100)
            {
                sum += i;
                i++;        // 很关键，改变循环条件!
            }
            i = 1; sumOdd = 0;    // 赋初值
            while (i <= 100)
            {
                sumOdd += i;
                i += 2;        // 很关键，改变循环条件!
            }
            i = 2; sumEven = 0;    // 赋初值
            while (i <= 100)
            {
                sumEven += i;
                i += 2;        // 很关键，改变循环条件!
            }
            Console.WriteLine("during 1~100, sum={0}, sumOdd={1}, sumEven={2}", sum, sumOdd, sumEven);
            Console.ReadKey();
        }
    }
}
