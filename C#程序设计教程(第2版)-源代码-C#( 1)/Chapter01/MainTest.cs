// compile error£º// csc MainTest.cs  -> MainTest.exe
// compile OK£º // csc /main:CSharpBook.Chapter01.HelloWorld2 MainTest.cs  -> MainTest.exe
using System;
namespace CSharpBook.Chapter01
{
    class HelloWorld1
    {
        static void Main() 
        {
            Console.WriteLine("Hello World 1!");
        }
    }
    class HelloWorld2
    {
        static void Main() 
        {
            Console.WriteLine("Hello World 2!");
        }
    }
}
