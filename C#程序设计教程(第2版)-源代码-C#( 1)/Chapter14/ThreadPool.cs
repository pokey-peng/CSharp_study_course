using System;using System.Threading;
namespace CSharpBook.Chapter14
{
    class TimerDemo
    {
        public static void DoWork(object state)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0}-{1} ", state.ToString(), i); Thread.Sleep(100);
            }
        }
        public static void Main()
        {
            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(DoWork, "W"+i);
            }
            Console.ReadKey();
        }
    }
}
