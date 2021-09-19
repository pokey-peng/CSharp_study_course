// compile：csc NamespaceTest.cs  ->  NamespaceTest.exe
using System;
using CSharpBook.Chapter01;
namespace CSharpBook.Chapter01
{
    class SampleClass
    {
        public void SampleMethod()
        {
          Console.WriteLine("SampleMethod inside CSharpBook.Chapter01");
        }
    }
    namespace NestedNamespace   // 创建嵌套的命名空间
    {
        class SampleClass
        {
            public void SampleMethod()
            {
                Console.WriteLine("SampleMethod inside CSharpBook.Chapter01.NestedNamespace");
            }
        }
    }
    class Program
    {
        static void Main()
        {
            // 显示"SampleMethod inside CSharpBook.Chapter01."
            SampleClass outer = new SampleClass();
            outer.SampleMethod();
            //显示"SampleMethod inside CSharpBook.Chapter01."
            CSharpBook.Chapter01.SampleClass outer2 = new CSharpBook.Chapter01.SampleClass();
            outer2.SampleMethod();
            // 显示"SampleMethod inside CSharpBook.Chapter01.NestedNamespace."
            NestedNamespace.SampleClass inner = new NestedNamespace.SampleClass();
            inner.SampleMethod();
            // 显示"SampleMethod inside CSharpBook.Chapter01.NestedNamespace."
            CSharpBook.Chapter01.NestedNamespace.SampleClass inner2 = 
                new CSharpBook.Chapter01.NestedNamespace.SampleClass();
            inner2.SampleMethod();
        }
    }
}
