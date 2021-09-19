using System;
namespace CSharpBook.Chapter03
{
    class ExpressionTest
    {
        static void Main(string[] args)
        {
            int a = 1,b = 2,c = 3;
            a += b++ + c;
            Console.WriteLine(" a = {0},  b = {1},  c = {2}", a, b, c);
            Console.WriteLine(" c >= b && b >= a 结果为： {0}", c >= b && b >= a);
            Console.WriteLine(" a < b ? a++ : b++ 结果为： {0}", a < b ? a++ : b++);
            Console.WriteLine(" a = {0},  b = {1},  c = {2}", a, b, c);
            Console.WriteLine(" c += a > b ? a++ : b++ 结果为： {0}", c += a > b ? a++ : b++);
            Console.WriteLine(" a = {0},  b = {1},  c = {2}", a, b, c);
            a = b = c = 2; Console.WriteLine(" a = {0},  b = {1},  c = {2}", a, b, c);
            a = 3; b = 8; c = 4; Console.WriteLine(" a = {0},  b = {1},  c = {2}", a, b, c);
            Console.WriteLine(" a < b ? a : b < c ? b : c 结果为： {0}", a < b ? a : b < c ? b : c);
            Console.WriteLine(" (a < b ? a : b) < c ? b : c 结果为： {0}", (a < b ? a : b) < c ? b : c);
            Console.WriteLine(" (b2-4ac)的平方根为： {0}", Math.Sqrt(Math.Pow(b,2)-4*a*c));
            bool m = false, n = true, p = true;
            Console.WriteLine(" m = {0},  n = {1},  p = {2}", m, n, p);
            Console.WriteLine(" m | n ^ p = {0}", m | n ^ p);
            Console.WriteLine(" m | n ^ p = {0}", n | m ^ p); Console.ReadLine();
        }
    }
}
