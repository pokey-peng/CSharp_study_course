using System;
namespace CSharpBook.Chapter07
{
  class SimpleClassA
  {
    public SimpleClassA ()
    {
        Console.WriteLine("执行SimpleClassA的构造函数");
    }
    ~SimpleClassA ()
    {
        Console.WriteLine("执行SimpleClassA的析构函数");
    }
  }
  class SimpleClassB
  {
    public SimpleClassB()
    {
        Console.WriteLine("执行SimpleClassB的构造函数");
    }
    ~SimpleClassB()
    {
        Console.WriteLine("执行SimpleClassB的析构函数");
    }
    public void CreateObject()
    {
        Console.WriteLine("进入SimpleClassB.CreateObject()");
        SimpleClassA oSimpleClassA = new SimpleClassA();
        Console.WriteLine("退出SimpleClassB.CreateObject()");
    }
  }
  class Test
  {
    static void Main()
    {
      Console.WriteLine("进入Main()"); SimpleClassB oSimpleClassB = new SimpleClassB();
      oSimpleClassB.CreateObject(); Console.WriteLine("退出Main()"); Console.ReadLine();
    }
  }
}
