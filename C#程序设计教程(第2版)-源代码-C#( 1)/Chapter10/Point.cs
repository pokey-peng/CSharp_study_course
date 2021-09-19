using System;
namespace CSharpBook.Chapter10 
{ 
  public struct Point       // 平面坐标点
  {
    public int x, y;
    public Point(int x, int y) //有2个参数的构造函数
    {
        this.x = x;  this.y = y;
    }
  }
  class PointTest
  {
    static void Main()
    {
        Point p1 = new Point ();    //调用默认构造函数
        Console.WriteLine("平面坐标 1: x = {0}, y = {1}", p1.x, p1.y);
        Point p2 = new Point(10, 10);  //调用有2个参数的构造函数
        Console.WriteLine("平面坐标 2: x = {0}, y = {1}", p2.x, p2.y);
        Point p3; 
        //Console.WriteLine("平面坐标3: x = {0}, y = {1}", p3.x, p3.y);//编译错误
        p3.x = 22;  p3.y = 33;
        Console.WriteLine("平面坐标 3: x = {0}, y = {1}", p3.x, p3.y);
        Console.ReadKey();
    }
  }
}
