using System;
namespace CSharpBook.Chapter07
{
  public class Bus
  { // 静态构造函数
    static Bus()
    {
        Console.WriteLine("调用静态构造函数Bus()");
    }
    public static void Drive()
    {
        Console.WriteLine("调用静态方法Bus.Drive()");
    }
  }
  class TestBus
  {
    static void Main()
    {
        Bus.Drive();
        Console.ReadLine();
    }
  }
}
