using System;using System.Threading.Tasks;
namespace CSharpBook.Chapter14
{
    class ParallelForEach
    {
        public static void Main()
        {
            string[] items = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J","K" };
            Parallel.For(0, 10, i => Console.Write(i));
            Parallel.ForEach(items, item => Console.Write(item));
            Console.ReadKey();
        }
    }
}
