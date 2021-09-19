// compile：csc CommandLine.cs  -> CommandLine.exe
using System;
namespace CSharpBook.Chapter01
{
    class CommandLine
    {
        	static void Main(string[] args)
        	{ // 输出参数个数
             Console.WriteLine("参数个数 = {0}", args.Length);
	        for (int i = 0; i < args.Length; i++)  // 使用for语句输出各参数值
	        {
	            Console.WriteLine("Arg[{0}] = [{1}]", i, args[i]);
	        }
	        foreach (string s in args)  // 使用foreach语句输出各参数值
	        {
	            Console.WriteLine(s);
	        }
	    }
    }
}
