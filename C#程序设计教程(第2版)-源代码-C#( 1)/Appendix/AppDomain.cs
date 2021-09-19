using System;using System.Reflection;
namespace CSharpBook.ChapterAI
{
 class AppDomain1
 {
   public static void Main()
   {
      Console.WriteLine("主应用程序域： " + AppDomain.CurrentDomain.FriendlyName);
      //创建应用程序域
      AppDomain newDomain = AppDomain.CreateDomain("NewApplicationDomain");
      Console.WriteLine("子应用程序域： " + newDomain.FriendlyName);
      //载入并执行应用程序集
      Console.WriteLine("运行应用程序： " + @"C:\C#\Chapter01\Hello.exe"); 
      newDomain.ExecuteAssembly(@"C:\C#\Chapter01\Hello.exe");
      //卸载应用程序域
      AppDomain.Unload(newDomain);
   }
 }
}
