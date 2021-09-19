using System;using System.Threading;
namespace CSharpBook.Chapter14
{
    class TimerDemo
    {
        public static void PrintTime(object state)
        {
            Console.WriteLine("{0} {1} ", state.ToString(),DateTime.Now.ToString("HH:MM:ss"));
        }
        public static void Main()
        {
            TimerCallback timerCB = new TimerCallback(PrintTime);
            Timer timer1 = new Timer(timerCB, "timer1", 0, 1000);
            Console.ReadKey();
        }
    }
}
