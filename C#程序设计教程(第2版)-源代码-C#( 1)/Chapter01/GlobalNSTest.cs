// compile：csc GlobalNSTest.cs  ->  GlobalNSTest.exe 
using System;
namespace CSharpBook.Chapter01
{
    class GlobalNSTest
    {
        // 定义一个名为'System'的新类，为系统制造麻烦.
        public class System { }
        // 定义一个名为'Console'的常量，为系统制造麻烦.
        const int Console = 7;
        const int number = 66;
        static void Main()
        {
            // Console.WriteLine(number);  // 出错：访问TestApp.Console
            global::System.Console.WriteLine(number);   //OK！访问正确的命名空间中的类型
        }
    }
}
