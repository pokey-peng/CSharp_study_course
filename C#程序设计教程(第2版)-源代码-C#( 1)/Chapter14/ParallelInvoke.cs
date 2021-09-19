using System;using System.Threading;using System.Threading.Tasks;
namespace CSharpBook.Chapter14
{
    class ParallelInvoke
    {
        public static void DoWork1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("1-{0} ", i); Thread.Sleep(100);
            }
        }
        public static void DoWork2()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("2-{0} ", i); Thread.Sleep(100);
            }
        }
        public static void Main()
        {
            Parallel.Invoke(DoWork1, DoWork2);
            Console.ReadKey();
        }
    }
}
