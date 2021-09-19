using System;using System.Threading;
namespace CSharpBook.Chapter14
{
  public class WorkerThreadExample
  {
    static void Main()
    {
        Console.WriteLine("主线程：开始……");
        Thread.Sleep(5000); // 主线程睡眠5秒钟
        Console.WriteLine("主线程：结束！"); Console.ReadKey();
    }
  }
}
