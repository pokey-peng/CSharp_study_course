using System;
using System.IO;
namespace CSharpBook.Chapter04
{
    class MyExceptionTest
    {
        static void Main(string[] args)
        {
//          Object obj1 = null;  //如果代码为Object obj1 = "abc"，则不抛出异常
Object obj1 = "abc";
          try { InParamTest(obj1); }
          catch (System.ArgumentException e) { System.Console.WriteLine(e.Message); }
          Console.ReadKey();
       }
       static void InParamTest(Object param1)
       {  if (param1 == null) throw new System.ArgumentException("参数不能为空！", " param1");
          else Console.WriteLine("参数正确！");
       }
    }
}
