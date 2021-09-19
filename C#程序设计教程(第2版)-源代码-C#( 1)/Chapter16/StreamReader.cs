using System; using System.IO;
namespace CSharpBook.Chapter16
{
    class StreamWriterTest
{
        private const string FILE_NAME = @"c:\temp\TestFile.txt";
        public static void Main(String[] args)
        {
           try
           { //创建StreamReader实例以从文本文件中读取内容.
             using (StreamReader sr = new StreamReader(FILE_NAME))
             {
               String line;
               //读取文本文件每一行的内容，直至文件结束
                while ((line = sr.ReadLine()) != null) { Console.WriteLine(line); }
             }
           }
           catch (Exception e) { Console.WriteLine(e.Message); } // 异常处理
           Console.ReadKey();
        }
    }
}
