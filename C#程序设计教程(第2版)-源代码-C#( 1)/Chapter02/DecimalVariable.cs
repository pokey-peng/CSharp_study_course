using System;
namespace CSharpBook.Chapter02
{
  class DecimalVariable
  {
     static void Main()
     {
        // decimal x0=99.99;      // 编译错误：不能隐式地将double类型转换为decimal类型
        decimal x1 = 99.99m;    // 使用后缀m或M初始化decimal类型变量
        decimal x2 = 9999999999999999999999999999m;
        Console.WriteLine("{0:C}", x1);
        Console.WriteLine("{0:C}",x2);
        Console.ReadKey();
      }
  }
}
