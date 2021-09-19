using System;
namespace CSharpBook.Chapter7
{
    public class IteratorMethodDemo
    {
        static void Main()
        {
            foreach (int i in Fibs())
            {
                if (i < 1000) Console.Write("{0} ", i);
                else break;
            }
            Console.ReadKey();
        }
        public static System.Collections.Generic.IEnumerable<int> Fibs()
        {
            int f1 = 1, f2 = 1;
            while (true)
            {
                yield return f1;
                yield return f2;
                f1 += f2; f2 += f1;
            }
        }
    }
}
