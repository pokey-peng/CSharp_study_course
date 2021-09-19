using System;using System.Collections.Generic;
namespace CSharpBook.Chapter17
{
    public class LinkedListDemo
    {
        public static void Main()
        {
            LinkedList<int> list = new LinkedList<int>(); //创建双向链表
            list.AddFirst(0); list.AddLast(8);
            LinkedListNode<int> lln1 = new LinkedListNode<int>(1); //创建节点
            LinkedListNode<int> lln2 = new LinkedListNode<int>(2); //创建节点
            list.AddFirst(lln1); list.AddLast(lln2);
            list.AddBefore(list.Last, 33); list.AddAfter(list.Last, 25);
            LinkedListNode<int> mark1 = list.Find(8); //查找节点
            list.AddBefore(mark1, 11);
            LinkedListNode<int> node = list.First; //输出列表内容
            while (node != null)
            {
                Console.Write("{0} ", node.Value);
                node = node.Next;
            }
            foreach (var i in list)   //输出列表内容
                Console.Write("{0} ", i);
            Console.ReadKey();
        }
    }
}
