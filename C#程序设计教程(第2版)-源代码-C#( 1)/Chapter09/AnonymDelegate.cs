using System;
namespace CSharpBook.Chapter09
{
   delegate void Printer(string s); //声明委托
   class TestClass
   {  
      static void Main()
      {  // 使用匿名方法实例化delegate类
         Printer p = delegate(string j) { Console.WriteLine(j); };
         p("使用匿名方法的委托的调用。"); //匿名delegate调用结果
      }
  }
}
