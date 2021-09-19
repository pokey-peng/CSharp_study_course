using System;
namespace CSharpBook.Chapter02
{
  class BoolVariable
  {
      static void Main()
      {
		bool b1 = true;
		//bool b2 = 0;	     //编译错误：常量值“0”无法转换为“bool”
		char c = '0';
		bool b3 = (c > 64 && c < 123);
		Console.WriteLine("{0}\t{1}",b1,b3);
           Console.ReadKey();
      }
  }
}
