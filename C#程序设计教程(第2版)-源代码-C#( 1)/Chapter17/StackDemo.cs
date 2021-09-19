using System;using System.Collections.Generic;
namespace CSharpBook.Chapter17
{
    public class SortedListGenericDemo
    {
        public static void Main()
        {
            Stack<int> myS = new Stack<int>(); //创建实例对象
            myS.Push(10); myS.Push(20); myS.Push(30); myS.Push(40);
            while (true)
                try
                {
                    Console.Write("{0} ", myS.Pop());
                }
                catch (InvalidOperationException e)
                {
                    break;
                }
        }
    }
}
