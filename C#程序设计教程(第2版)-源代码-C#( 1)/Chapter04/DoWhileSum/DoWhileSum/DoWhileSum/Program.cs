using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1; int sum = 0;
            do
            {
                sum += i; i++; //1~100中所有数的和
            } while (i <= 100);
            i = 1; int sumOdd = 0;
            do
            {
                sumOdd += i; i += 2; //1~100中所有奇数的和
            } while (i <= 100);
            i = 2; int sumEven = 0;
            do
            {
                sumEven += i; i += 2;// 1~100中所有偶数的和
            } while (i <= 100);
            Console.WriteLine(sum);
            Console.WriteLine(sumOdd);
            Console.WriteLine(sumEven);
            Console.ReadKey();
        }
    }
}
