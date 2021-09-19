//ExtensionMethodTest.cs
//compile£ºcsc /r:ExtensionMethod.dll ExtensionMethodTest.cs -> ExtensionMethodTest.exe
using System; using ExtensionMethods;
namespace CSharpBook.Chapter13
{
    class ExtensionMethodTest
    {
        public static void Main()
        {
            string s = "Hello, Extension Methods. Testing...";
            int i = s.WordCount();
            Console.WriteLine("×Ö·û´®£º{0}£¬°üÀ¨{1}¸öµ¥´Ê", s, i);
            Console.ReadKey();
        }
    }
}
