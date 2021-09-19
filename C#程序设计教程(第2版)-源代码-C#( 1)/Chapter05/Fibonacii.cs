using System;
namespace CSharpBook.Chapter05
{
    class Fibonacii
    {
        static void Main()
        {
            int i; int[] Fab= new int[20];
            Fab[0] = 1;  Fab[1] = 1;
            for (i = 2; i < 20; i++) Fab[i] = Fab[i-1]+Fab[i-2];
            for (i = 0; i < 20; i++)
            {   if (i % 5 == 0) Console.WriteLine();     //一行显示5个数
                Console.Write("{0,6} ", Fab[i]);
            }
        }
    }
}
