using System;using System.Reflection;
namespace CSharpBook.ChapterAI
{
    public class CustomBinder
    {
        static void Main(string[] args)
        {
            Type t = typeof(CustomBinder);
            BindingFlags flags = BindingFlags.InvokeMethod | BindingFlags.Instance |
                BindingFlags.Public | BindingFlags.Static;
            Object[] args1 = new Object[] { };
            switch (args.Length)
            {
                case 0:
                    t.InvokeMember("PrintInfo", flags, null, null, args1); break;
                default:
                    t.InvokeMember("PrintError", flags, null, null, args1); break;
            }
            Console.ReadKey();
        }
        public static void PrintInfo()
        {
            Console.WriteLine("本程序无任何命令行参数!");
        }
        public static void PrintError()
        {
            Console.WriteLine("命令行参数太多!");
        }
    }
}
