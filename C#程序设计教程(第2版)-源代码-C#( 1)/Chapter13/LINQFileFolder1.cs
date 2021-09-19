using System;using System.Collections.Generic;using System.Linq;
namespace CSharpBook.Chapter13
{
  class FindFileByExtension
  {
    static void Main()
    {
        string path = @".\";    //当前目录
        //获取当前目录中所有文件列表
        string[] fileNames = System.IO.Directory.GetFiles(path);
        List<System.IO.FileInfo> fileList = new List<System.IO.FileInfo>();
        foreach (string name in fileNames) fileList.Add(new System.IO.FileInfo(name));
        //创建查询1：查询所有后缀为.cs的文件
        IEnumerable<System.IO.FileInfo> fileQuery1 =from file in fileList
                    where file.Extension == ".cs"
                    orderby file.Name
                    select file;
        //执行查询1，并循环显示查询结果
        foreach (System.IO.FileInfo fi in fileQuery1) Console.WriteLine(fi.FullName);
        //创建查询2：查询所有文件，并按创建时间排序 
        var fileQuery2 = from file in fileQuery1
                     orderby file.CreationTime
                     select new { file.FullName, file.CreationTime };
        var newestFile = fileQuery2.Last();//执行查询，返回最后创建的文件
        //显示结果
        Console.WriteLine("\r\n最新的.cs文件为：{0}，创建时间为：{1}",newestFile.FullName, newestFile.CreationTime);
        Console.ReadKey();
    }
  }
}
