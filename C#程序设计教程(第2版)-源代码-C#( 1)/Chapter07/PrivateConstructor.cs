using System;
namespace CSharpBook.Chapter07
{
  public class Counter
  {
    private Counter() { }   //私有构造函数：阻止被实例化
    public static int currentCount;
    public static int IncrementCount()
    {
        return ++currentCount;
    }
  }
  class TestCounter
  {
    static void Main()
    {
        // Counter aCounter = new Counter();   //编译错误
        Counter.currentCount = 100;
        Console.WriteLine("count初值为：{0}", Counter.currentCount);
        Counter.IncrementCount();
        Console.WriteLine("count增值为：{0}", Counter.currentCount); Console.ReadLine();
    }
  }
}
