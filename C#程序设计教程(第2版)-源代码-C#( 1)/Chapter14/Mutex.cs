using System;using System.Threading;
namespace CSharpBook.Chapter14
{
  public class Test
  {
    public static void Main()
    {   //创建命名mutex。只能存在一个名为MyMutex的系统对象
         Mutex m = new Mutex(false, "MyMutex");
        //试图获取对命名mutex的控制权。若命名mutex被另一线程所控制，则等待直至其被释放
        Console.WriteLine("等待MyMutex. . . . . ."); m.WaitOne();
        //保持对mutex的控制，直至用户按ENTER键
        Console.WriteLine("本应用拥有MyMutex。请按任意键释放之并退出！");
        Console.ReadKey(); m.ReleaseMutex();
    }
  }
}
