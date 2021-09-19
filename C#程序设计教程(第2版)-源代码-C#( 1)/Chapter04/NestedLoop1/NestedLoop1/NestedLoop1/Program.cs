// Chapter04/4-18-NestedLoop.cs 
// compile：csc 4-18-NestedLoop.cs  -> 4-18-NestedLoop.exe
using System;
namespace CSharpBook.Chapter04
{
    class NestedLoop
    {
        static void Main()
        {
            Console.WriteLine("                          九九乘法表");
            String s;
            for (int i = 1; i <= 9; i++)
            {
                s = "";
                for (int j = 1; j <= 9; j++)
                {   //字符串左对齐，在右边用空格填充以达到指定的总长度8
                    s += (String.Format("{0}*{1}={2}", i, j, i * j)).PadRight(8);
                }
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
