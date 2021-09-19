using System;using System.Collections.Generic;using System.Linq;
namespace CSharpBook.Chapter13
{
  class QuerySize
  {
    public static void Main()
    {
        string startFolder = @"c:\C#\Chapter13";
        //获取c:\C#\Chapter13目录及其所有子目录中的.cs源文件列表
        IEnumerable<string> fileList = System.IO.Directory.GetFiles(startFolder, "*.cs", System.IO.SearchOption.AllDirectories);
        //创建查询：获取.cs源文件的文件大小列表
        var fileQuery = from file in fileList
                     select (new System.IO.FileInfo(file)).Length;
        long[] fileLengths = fileQuery.ToArray();//执行查询，返回.cs的文件大小列表
        long largestFile = fileLengths.Max();//执行聚合运算，获取最大文件的大小
        long totalBytes = fileLengths.Sum();//执行聚合运算，获取所有文件大小的和
        //显示结果
        Console.WriteLine("文件数：{0}；总字节数：{1}", fileList.Count(), totalBytes);
        Console.WriteLine("最大的文件为 {0} 字节", largestFile);
        Console.ReadKey();
    }
  }
}
