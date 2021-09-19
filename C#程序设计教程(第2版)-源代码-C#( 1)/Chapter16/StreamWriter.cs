using System; using System.IO;
namespace CSharpBook.Chapter16
{
   class StreamWriterTest
   {
      private const string FILE_NAME = @"c:\temp\TestFile.txt";
      public static void Main(String[] args)
      { //创建StreamWriter实例以在文件中添加文本
         using (StreamWriter sw = new StreamWriter(FILE_NAME))
         { //在文件中添加文本
            sw.Write("文本文件"); sw.WriteLine("的写入/读取示例：");
            sw.WriteLine("----------------------------------");
            sw.WriteLine("写入整数 {0} 或浮点数 {1}", 1, 4.2);
            bool b = false; char grade = 'A'; string s = "Multiple Data Type!";
            sw.WriteLine("写入Boolean值、字符、字符串、日期：");
            sw.WriteLine(b); sw.WriteLine(grade); sw.WriteLine(s); 
            sw.Write("当前日期为："); sw.WriteLine(DateTime.Now);
         }
         Console.ReadKey();
      }
   }
}
