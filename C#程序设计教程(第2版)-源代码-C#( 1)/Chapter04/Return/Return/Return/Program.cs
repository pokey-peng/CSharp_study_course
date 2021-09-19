using System;
namespace CSharpBook.Chapter04
{
    class ReturnTest
    {
        static double CalculateArea(int r)   // 计算面积
        {
            double area = r * r * Math.PI;
            return area; //方法CalculateArea以double值的形式返回变量Area
        }
        static void Main()
        {
            Console.Write("请输入圆的半径：   ");
            int radius = int.Parse(Console.ReadLine()); //将数字字符串转换为等效的整数
            Console.WriteLine("圆的面积为： {0:0.00}", CalculateArea(radius));
            Console.ReadLine();
        }
    }
}
