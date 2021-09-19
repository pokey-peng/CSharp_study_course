using System;
using System.Threading;
namespace CSharpBook.Chapter07
{
  class Test
  {
    public static int result; public static volatile bool finished;
    static void Thread2()
    {
        result = 143;  finished = true;
    }
    static void Main()
    {
        finished = false; 
        new Thread(new ThreadStart(Thread2)).Start();//在新线程中运行Thread2()
        //等待Thread2的执行：result赋值，并将finished设置为true 
        for (; ; )
        {
            if (finished)
            {
                Console.WriteLine("result = {0}", result); Console.ReadLine();
            }
        }
    }
  }
}
