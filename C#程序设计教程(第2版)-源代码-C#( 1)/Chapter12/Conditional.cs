using System; using System.Diagnostics;
namespace CSharpBook.Chapter12
{
    public class MyTrace
    {
        [Conditional("DEBUG")]
        public static void Msg(string msg) { Console.WriteLine(msg); }
        [Conditional("DEBUG"), Conditional("TRACE")]
        public static void Method2()
        {
            Console.WriteLine("DEBUG or TRACE is defined");
        }
    }
    public class ConditionalTest
    {
        static void Main()
        {
            MyTrace.Msg("Now in Main..."); MyTrace.Method2();
            Console.WriteLine("Main Done."); Console.ReadKey();
        }
    }
}
