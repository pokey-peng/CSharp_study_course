// compile：csc /doc:XMLDoc.xml XMLDoc.cs -> XMLDoc.xml以及XMLDoc.exe
using System;
/// <summary>
/// XML注释文档示例。</summary>
/// <remarks>
/// 本示例演示使用XML注释生成XML注释文档的
/// 方法和过程 </remarks>
public class XMLDoc
{
   /// <summary>
   /// 在控制台窗口中显示欢迎信息。 </summary>
   /// <param name="sName">sName：用户名字符串。</param>
   /// <seealso cref="String">
   /// 请参见String。</seealso>
   public static void SayHello(string sName)
   {
   	   Console.WriteLine(sName + ", Welcome to C# world!");
   }
   /// <summary>
   /// 应用程序的入口点。
   /// </summary>
   /// <param name="args">用户名</param>
   public static int Main(String[] args)
   {
   	   if (args.Length == 0)
   	   {
    		Console.WriteLine("请输入您的姓名，形式如下：XMLDoc.exe yourname");
    		return 1;
		}
   	   XMLDoc.SayHello(args[0]);
       return 0;
   }
}
