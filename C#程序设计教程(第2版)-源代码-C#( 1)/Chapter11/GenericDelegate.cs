using System;
namespace CSharpBook.Chapter11
{
  public delegate void StackDelegate<T>(T item); 
  class Stack<T>
  {
    private static void DoWork(float item) 
    {
        Console.WriteLine("Do some work:{0}",item);
    }
    public static void TestStack()
    {
        Stack<float> s = new Stack<float>();
        StackDelegate<float> d = DoWork;  d(1.1f);
    }
  }
  class Test
  {
    public static void Main()
    {
        Stack<float>.TestStack(); Console.ReadLine();
    }
  }
}
