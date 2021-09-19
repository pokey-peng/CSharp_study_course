using System;
namespace CSharpBook.Chapter12
{
    public class CallerTest
    {
        public static void TraceMessage(string message,
        [CallerMemberName] string memberName = "",
        [CallerFilePath] string sourceFilePath = "",
        [CallerLineNumber] int sourceLineNumber = 0)
        {
            Console.WriteLine("信息: " + message);
            Console.WriteLine("成员名称: " + memberName);
            Console.WriteLine("源代码路径: " + sourceFilePath);
            Console.WriteLine("行号: " + sourceLineNumber);
        }
        public static void f1() { TraceMessage("CallerTest.f1()"); }
        public static void Main()
        {
            TraceMessage("Main()");CallerTest.f1();Console.ReadKey();
        }
    }
}
