using System;
namespace CSharpBook.Chapter04
{
    class ForEachLoop
    {
        static void Main()
        {
            int[] myArray = new int[3] { 10, 20, 30 };  //3个整数的整数数组
            foreach (int item in myArray) Console.Write(item+" "); //输出整数数组各元素
            Console.ReadLine();
        }
    }
}
