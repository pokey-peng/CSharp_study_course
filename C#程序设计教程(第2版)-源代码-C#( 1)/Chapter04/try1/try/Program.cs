using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @try
{
    class Program
    {
        static void Main(string[] args)
        {
            //double x,y1=0,y2=0,y3=0,y4=0;
            //x = -1;
            //y1 = Math.Sin(x) + 2 * Math.Sqrt(x + Math.Exp(4)) - Math.Pow(x + 1, 3);
            //if (x < 0)
            //    y1 = Math.Log(-5 * x) - Math.Abs(x * x - 8 * x) / (7 * x) + Math.E;
            //Console.WriteLine(y1);

            //if (x >= 0)
            //    y2 = Math.Sin(x) + 2 * Math.Sqrt(x + Math.Exp(4)) - Math.Pow(x + 1, 3);
            //if (x < 0)
            //    y2 = Math.Log(-5 * x) - Math.Abs(x * x - 8 * x) / (7 * x) + Math.E;
            //Console.WriteLine(y2);

            //if (x >= 0)
            //    y3 = Math.Sin(x) + 2 * Math.Sqrt(x + Math.Exp(4)) - Math.Pow(x + 1, 3);
            //else
            //    y3 = Math.Log(-5 * x) - Math.Abs(x * x - 8 * x) / (7 * x) + Math.E;
            //Console.WriteLine(y3);

            //y4 = (x >= 0) ? Math.Sin(x) + 2 * Math.Sqrt(x + Math.Exp(4)) - Math.Pow(x + 1, 3) : Math.Log(-5 * x) - Math.Abs(x * x - 8 * x) / (7 * x) + Math.E;
            //Console.WriteLine(y4);

            //int x, y;
            //x=10;y=0;
            //if (x > 0 && y > 0) Console.WriteLine("x={0}, y={1}, 位于第一象限", x, y);
            //else if (x < 0 && y > 0) Console.WriteLine("x={0}, y={1}, 位于第二象限", x, y);
            //else if (x < 0 && y < 0) Console.WriteLine("x={0}, y={1}, 位于第三象限", x, y);
            //else if (x > 0 && y < 0) Console.WriteLine("x={0}, y={1}, 位于第四象限", x, y);
            //else if (x == 0 && y == 0) Console.WriteLine("x={0}, y={1}, 位于原点", x, y);
            //else if (x == 0) Console.WriteLine("x={0}, y={1}, 位于y轴", x, y);
            //else Console.WriteLine("x={0}, y={1}, 位于x轴", x, y);

            //int x = 0, y1=0,y2=0,y3=0,y4=0;
            //if (x > 0)
            //    y1 = 1;
            //else if (x == 0)
            //    y1 = 0;
            //else
            //    y1 = -1;
            //Console.WriteLine(y1);

            //if (x >= 0)
            //{
            //    if (x > 0)
            //        y2 = 1;
            //    else
            //        y2 = 0;
            //}
            //else
            //    y2 = -1;
            //Console.WriteLine(y2);

            //y3 = 1;
            //if (x != 0)
            //{
            //    if (x < 0)
            //        y3 = -1;
            //}
            //else
            //    y3 = 0;
            //Console.WriteLine(y3);

            //y4 = 1;
            //if (x != 0)
            //    if (x < 0)
            //        y4 = -1;
            //    else
            //        y4 = 0;
            //Console.WriteLine(y4);

            //char ch = '!';
            //if (Char.IsLetter(ch))
            //{
            //    if (Char.IsUpper(ch))
            //        Console.WriteLine("字符 {0} 是大写字母", ch);
            //    else
            //        Console.WriteLine("字符 {0} 是小写字母", ch);
            //}
            //else if (Char.IsNumber(ch))
            //    Console.WriteLine("字符 {0} 是数字字符", ch);
            //else
            //    Console.WriteLine("字符 {0} 是其他字符", ch);

            //if (Char.ToUpper(ch) >= 'A' && Char.ToUpper(ch) <= 'Z')
            //{
            //    if (ch >= 'A' && ch <= 'Z')
            //        Console.WriteLine("字符 {0} 是大写字母", ch);
            //    else
            //        Console.WriteLine("字符 {0} 是小写字母", ch);
            //}
            //else if (ch >= '0' && ch <= '9')
            //    Console.WriteLine("字符 {0} 是数字字符", ch);
            //else
            //    Console.WriteLine("字符 {0} 是其他字符", ch);

            int year = 2008;
            if (DateTime.IsLeapYear(year))
                Console.WriteLine("{0} year is a leap year!", year);
            else
                Console.WriteLine("{0} year is not a leap year!", year);


            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
    Console.WriteLine("{0} year is a leap year!", year);
else
    Console.WriteLine("{0} year is not a leap year!", year);

            if (year % 400 == 0)
    Console.WriteLine("{0} year is a leap year!", year);
else
{
    if (year % 4 == 0)
    {
        if (year % 100 == 0)Console.WriteLine("{0} year is not a leap year!", year);
        else Console.WriteLine("{0} year is a leap year!", year);
    }
    else
        Console.WriteLine("{0} year is not a leap year!", year);
}

            if (year % 400 == 0)
    Console.WriteLine("{0} year is a leap year!", year);
else if (year % 4 != 0)
    Console.WriteLine("{0} year is not a leap year!", year);
else if (year % 100 == 0)
    Console.WriteLine("{0} year is not a leap year!", year);
else
    Console.WriteLine("{0} year is a leap year!", year);


            Console.ReadKey();

        }
    }
}
