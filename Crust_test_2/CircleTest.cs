using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crust_test_2
{
    class CircleTest
    {
        static void Main(string[] args)
        {
            Circle C1 = new Circle(3, 4, 5);
            Circle C2 = new Circle(7, 2, 4);
            Point p1 = new Point(2, 6);
            Rectangle rect1 = new Rectangle(3, 4);
            Console.WriteLine($"C1的圆心坐标为({C1.p.x},{C2.p.y}), 面积：{C1.Area().ToString("f2")}, 周长：{C1.perimeter().ToString("f2")}");
            Console.WriteLine($"C2的圆心坐标为({C2.p.x},{C2.p.y}), 面积：{C2.Area().ToString("f2")}, 周长：{C2.perimeter().ToString("f2")}");

            if (C1.CircleIntersect(C2))
            {
                Console.WriteLine("圆C1与圆C2相交");
            }
            else
            {
                Console.WriteLine("圆C1与圆C2不相交");
            }
            Console.WriteLine("圆C1与圆C2圆心之间的距离为" + C1.p.Distance(C2.p).ToString("f2"));
            Console.WriteLine($"长宽为({rect1.width},{rect1.height})的矩形");
            Console.WriteLine($"面积为: {rect1.getArea()}");
            Console.WriteLine($"周长为: {rect1.getPerimeter()}");
            Console.WriteLine($"对角线长度为: {rect1.getDiagonal()}");

        }
    }
}
