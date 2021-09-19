using System;
namespace CSharpBook.Chapter07
{
  class CoOrds        // 平面坐标
  {
    public int x, y;
    // 默认构造函数
    public CoOrds()      //默认构造函数
    {
        x = 0; y = 0;
    }
    // 有2个参数的构造函数:
    public CoOrds(int x, int y) //带2个参数的构造函数
    {
        this.x = x; this.y = y;
    }
    // 重写ToString方法:
    public override string ToString()
    {
        return (String.Format("({0},{1})", x, y));
    }
  }
  class MainClass
  {
    static void Main()
    {
        CoOrds p1 = new CoOrds();       //调用默认构造函数
        CoOrds p2 = new CoOrds(5, 3);    //调用有2个参数的构造函数
        // 使用重载的ToString方法显示结果
        Console.WriteLine("平面坐标 #1 位于 {0}", p1);
        Console.WriteLine("平面坐标 #2 位于 {0}", p2); Console.ReadLine();
    }
  }
}
