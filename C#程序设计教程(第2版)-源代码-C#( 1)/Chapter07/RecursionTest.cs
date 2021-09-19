using System;
namespace CSharpBook.Chapter07
{
    public class RecursionTest
    {
        public static int factorial(int n)
        {
            if (n <= 1)   //ÖÕÖ¹µÝ¹é
            { 
                return 1;
            }
            else        //µÝ¹éµ÷ÓÃ
            {
                return factorial(n - 1) * n;
            }
        }
        public static void Main()
        {
            for (int i = 5; i <= 10; i++) Console.Write("{0}!={1}  ", i, factorial(i));
            Console.ReadKey();
        }
    }
}
