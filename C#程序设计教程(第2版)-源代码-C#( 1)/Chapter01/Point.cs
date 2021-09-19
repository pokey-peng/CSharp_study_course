using System;
namespace CSharpBook.Chapter01
{
  public class Point             //声明类Point
  { 
	public int x, y;         //声明字段x和y，表示左边(x,y)
	public Point(int x, int y)  //构造函数
	{ 
		this.x = x;  this.y = y; 
	}
	public double Distance(Point p) //声明方法Distance，计算该对象（坐标点）与对象p（另一坐标点）的距离
		{ 
			return Math.Sqrt( (x-p.x) *(x-p.x)+ (y-p.y)*(y- p.y));
		}
  }
  class PointTest
  {
      static void Main()
      {
            Point p1 = new Point(0, 0);         //创建对象p1（坐标点1）
            Point p2 = new Point(10, 20);       //创建对象p2（坐标点2）
            double dist = p1.Distance(p1);      //调用对象p1的方法Distance
            Console.WriteLine("点p1的坐标为：(" + p1.x + "," + p1.y + ")"); //访问p1的属性x和y
            Console.WriteLine("点p2的坐标为：(" + p2.x + "," + p2.y + ")"); //访问p2的属性x和y
            Console.WriteLine("两点之间的距离为：" + dist);  Console.ReadKey();
        }
  }
}
