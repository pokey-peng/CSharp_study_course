using System;using System.Threading;
namespace CSharpBook.Chapter14
{
    public class AbortThread
    {
        public static void Main()
        {
            Console.WriteLine("主程序开始。创建并启动工作线程。");
            Thread t = new Thread(new ThreadStart(TestMethod));
            t.Start(); Thread.Sleep(1000);
            Console.Write("主程序试图销毁工作线程。");
            t.Abort("Main"); //销毁t
            t.Join();//等待线程终止
            Console.WriteLine("工作程终止。主线程终止。"); Console.ReadKey();
        }
        static void TestMethod()
        {
            try
            {
                while (true)
                {
                    Console.Write("T"); Thread.Sleep(100);
                }
            }
            catch (ThreadAbortException abortException)
            {
                Console.WriteLine("线程被{0}终止。", (string)abortException.ExceptionState);
            }
        }
    }
}
