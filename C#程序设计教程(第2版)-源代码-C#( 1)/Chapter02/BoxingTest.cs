using System;
namespace CSharpBook.Chapter02
{
  class BoxingTest
  {
    static void Main()
    {
            int i = 123;
            object obj1 = i;          //隐式装箱（boxing）
            object obj2 = (object)i;    //显式装箱（boxing）
            i = 456;                // 改变 i 的内容
            int j = (int)obj1;          // 拆箱（unboxing）
            Console.WriteLine("The value-type value(i) = {0}", i);
            Console.WriteLine("The value-type value(j) = {0}", j);
            Console.WriteLine("The object-type value(obj1) = {0}", obj1);
            Console.WriteLine("The object-type value(obj2) = {0}", obj2);
            Console.ReadKey();
    }
  }
}
