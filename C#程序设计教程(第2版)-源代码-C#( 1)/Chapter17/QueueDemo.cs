using System;using System.Collections.Generic;
namespace CSharpBook.Chapter17
{
    public class QueueDemo
    {
        public static void Main()
        {
            Queue<int> myQ = new Queue<int>(); //创建实例对象
            myQ.Enqueue(10); myQ.Enqueue(20); myQ.Enqueue(30); myQ.Enqueue(40);
            while (true)
                try
                {
                    Console.Write("{0} ", myQ.Dequeue());
                }
                catch (InvalidOperationException e)
                {
                    break;
                }
        }
    }
}
