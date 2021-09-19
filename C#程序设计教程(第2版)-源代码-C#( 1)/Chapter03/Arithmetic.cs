using System;
namespace CSharpBook.Chapter03
{
    class ArithmeticTest
    {
        static void Main()
        {  // ++ (增量运算符) ,-- (减量运算符)
            double x,y;
            x = 1.5;  y = ++x;
            Console.WriteLine("x={0}, y={1}",x, y);
            x = 1.5;  y = x++;
            Console.WriteLine("x={0}, y={1}", x, y);
            x = 1.5;  y = --x;
            Console.WriteLine("x={0}, y={1}", x, y);
            x = 1.5;  y = x--;
            Console.WriteLine("x={0}, y={1}", x, y);
            x=5.8;  int i = 5;
            Console.WriteLine("i={0}, +i={1}", i, +i);            // 一元+
            Console.WriteLine("i+5={0}, i+.5={1}", i + 5, i + .5);   // 二元+
            Console.WriteLine("x={0}, x + \"5\"= {1}", x, x + "5");  //字符串拼接(double自动转换为string)
            Console.WriteLine("'5' + '5'= {0}, 'A' + 'A'= {1}", '5' + '5', 'A' + 'A'); //字符转换为ASCII码值进行数值相加
            i= 5;
            Console.WriteLine("i={0}, -i={1}, i-1={2}, i-.5={3}", i, -i, i - 1, i - .5); // - (一元- &二元减法)
            Console.WriteLine("i*8={0}, -i*.8={1}", i * 8, -i * .8);  // * (乘法)
            Console.WriteLine("i/2={0}, -i/2.1={1}", i / 2, -i / 2.1); // (除法)
            Console.WriteLine("i%2={0}", i % 2);              // % ( 取模)
            Console.ReadKey(); 
        }
    }
}
