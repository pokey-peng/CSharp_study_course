using System;
namespace CSharpBook.Chapter02
{
  class StringVariable
  {
    static void Main()
    {
       string str1 = "Hello ";  string str2 = "World";
       string str3 = str1 + str2;    // 字符串拼接，形成"Hello World "
       char char1 = str3[1];      // 访问str3的第2个字符（即'e'）。index从0开始
       string str4 = "\"C:\\C#\"";  // 一般字符串常量，使用转义符
       string str5 = @"""C:\C#"""; //@字符串常量(序列不被处理)，故无需转义，但双引号需要两对双引号
       Console.WriteLine(str3);   Console.WriteLine(char1);
       Console.WriteLine(str4);   Console.WriteLine(str5);
       Console.ReadKey();
    }
  }
}
