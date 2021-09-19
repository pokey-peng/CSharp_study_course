using System;using System.Threading;
namespace CSharpBook.Chapter14
{
    public class AutoResetEventTest
    {
        private static AutoResetEvent waitHandle = new AutoResetEvent(false);//同步事件
        static void Main()
        {
            Console.Write("主线程开始。");
            Thread t = new Thread(DoWork);
            t.Start();
            waitHandle.WaitOne(); //等待waitHandle
            Console.Write(" 主线程结束。"); Console.ReadKey();
        }
        public static void DoWork()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write("."); Thread.Sleep(100);
            }
            waitHandle.Set(); //设置waitHandle
        }
    }
}
