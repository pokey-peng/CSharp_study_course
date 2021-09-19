using System;
namespace CSharpBook.Chapter01
{
   
    class PointTest
    {
        static void Main()
        {
            Point p1 = new Point(0, 4);         //创建对象p1（坐标点1）
            Point p2 = new Point(3, 0);       //创建对象p2（坐标点2）
            double dist = p2.Distance(p1);      //调用对象p1的方法Distance
            Console.WriteLine("点p1的坐标为：(" + p1.x + "," + p1.y + ")"); //访问p1的属性x和y
            Console.WriteLine("点p2的坐标为：(" + p2.x + "," + p2.y + ")"); //访问p2的属性x和y
            Console.WriteLine("两点之间的距离为：" + dist); Console.ReadKey();
        }
    }
}
