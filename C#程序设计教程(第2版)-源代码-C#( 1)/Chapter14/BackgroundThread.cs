using System;using System.Threading;
namespace CSharpBook.Chapter14
{
    public class BackgroundThread
    {
        static void Main()
        {
            Console.Write("主线程开始。");
            Thread t1 = new Thread(BackgroundThread.NoramlWork);
            t1.Start();
            Thread t2 = new Thread(BackgroundThread.BackgroundWork);
            t2.IsBackground = true; t2.Start();
            Console.WriteLine("主线程结束。");
        }
        public static void NoramlWork()
        {
            Console.Write("前台线程开始。");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("N"); Thread.Sleep(100);
            }
            Console.Write("前台线程结束。");
        }
        public static void BackgroundWork()
        {
            Console.Write("后台线程开始。");
            while (true)
            {
                Console.Write("B"); Thread.Sleep(100);
            }
            Console.Write("后台线程结束。");
        }
    }
}
