using System;using System.Threading;
namespace CSharpBook.Chapter14
{
    public class ParameterizedThread
    {
        static void Main()
        {
            Console.Write("主线程开始。");
            Thread t1 = new Thread(ParameterizedThread.DoWork);
            t1.Start(5);
            Thread t2 = new Thread(ParameterizedThread.DoWork);
            t2.Start("F");
            t1.Join(); t2.Join(); //使用Join方法阻止当前线程，直至对象线程终止
            Console.WriteLine("主线程结束。"); Console.ReadKey();
        }
        public static void DoWork(object data)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0}", data); Thread.Sleep(500);
            }
        }
    }
}
