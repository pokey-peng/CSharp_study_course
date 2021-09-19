using System;
namespace CSharpBook.Chapter07
{
    public class RecursionTest
    {
        public static int factorial(int n)
        {
            if (n <= 1)
            {                     //终止递归
                return 1;
            }
            else
            {
                return factorial(n - 1) * n;     //递归调用
            }
        }
        public static void Main()
        {
            for (int i = 5; i <= 10; i++)Console.Write("{0}!={1}  ", i, factorial(i));
            Console.ReadKey();
        }
    }
}