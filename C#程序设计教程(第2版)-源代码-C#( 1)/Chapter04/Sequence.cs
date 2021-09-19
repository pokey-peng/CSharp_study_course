using System;
namespace CSharpBook.Chapter04
{
    class Sequence
    {
       static void Main()
        {
           double a, b, c, p, area;
           Console.Write("请输入三角形的边A：   ");
           a = double.Parse(Console.ReadLine());       //将数字字符串转换为等效的双精度浮点数
           Console.Write("请输入三角形的边B：   ");
           b = double.Parse(Console.ReadLine());
           Console.Write("请输入三角形的边C：   ");
           c = double.Parse(Console.ReadLine());
           Console.WriteLine("三角形三边分别为： a={0}, b={1}, c={2}", a,b,c);
           p = (a + b + c) / 2; area = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
           Console.WriteLine("三角形的面积 = {0}",area);  Console.ReadLine();
        }
    }
}
