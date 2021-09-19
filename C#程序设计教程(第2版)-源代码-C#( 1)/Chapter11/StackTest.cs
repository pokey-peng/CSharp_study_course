using System;
public class Stack<T>
{
    int pos;
    T[] data = new T[100];
    public void Push(T obj) { data[pos++] = obj; }//进栈
    public T Pop() { return data[--pos]; }        //出栈
}
public class StackTest
{
    public static void Main()
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(2); stack.Push(4);   //数据进栈
        //stack.Push("a");            //编译错误
        Console.WriteLine(stack.Pop()); //输出结果：4
        Console.ReadKey();
    }
}
