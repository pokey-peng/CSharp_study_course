using System;using System.Threading;
namespace CSharpBook.Chapter14
{
    public class InterruptThread
    {
        static void Main()
        {
            Console.Write("主线程开始。");
            Thread t = new Thread(InterruptThread.DoWork);
            t.Start();
            Console.WriteLine("请在100秒之内按任意键中断线程!");
            Console.ReadKey();
            t.Interrupt();
            t.Join(); //使用Join方法阻止当前线程，直至对象线程终止
            Console.WriteLine("主线程结束。"); Console.ReadKey();
        }
        public static void DoWork(object data)
        {
            Console.Write("工作线程开始。");
            try {
                Console.Write("工作线程准备睡眠100秒...");
                Thread.Sleep(100000); //延迟100秒
            } catch (ThreadInterruptedException e) {
                Console.WriteLine("睡眠中断!");
            }
        }
    }
}
