using System;
namespace CSharpBook.Chapter04
{
    class SingleDecision
    {
       static void Main()
        {                            
            int a, b, t;  Random rNum = new Random();
            a = rNum.Next(101); b = rNum.Next(101); //产生0~100之间的随机整数a、b
            Console.WriteLine("原始值：  a={0}, b={1}", a, b);
            if (a < b) { t = a; a = b; b = t; } //如果a<b，则交换a、b，使得a大于b
           Console.WriteLine("降序值：  a={0}, b={1}", a, b); Console.ReadLine();
        }
    }
}
