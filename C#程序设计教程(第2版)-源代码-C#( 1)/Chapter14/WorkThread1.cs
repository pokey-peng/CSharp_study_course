using System;using System.Threading;
namespace CSharpBook.Chapter14
{
    public class WorkThread1
    {
        static void Main()
        {
            Console.Write("Main线程开始。"); 
            Thread t = new Thread(DoWork); //创建线程对象实例
            t.Start(); //启动工作线程
            for (int i = 0; i < 10; i++) { Console.Write("M"); Thread.Sleep(500); }
            Console.Write(" Main线程结束。"); Console.ReadKey();
        }
        public static void DoWork()
        {
            Console.Write("工作线程开始。");
            for (int i = 0; i < 10; i++) { Console.Write("W"); Thread.Sleep(500);}
            Console.Write(" 工作线程结束。");
        }
    }
}
