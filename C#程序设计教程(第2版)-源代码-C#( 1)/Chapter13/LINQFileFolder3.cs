using System;using System.Collections.Generic;using System.Linq;
namespace CSharpBook.Chapter13
{
    class QuerySize
    {
        public static void Main()
        {
            string path = @"c:\C#\Chapter13";
            //获取c:\C#\Chapter13目录中所有的文件列表
            IEnumerable<string> fileNames = System.IO.Directory.GetFiles(path, "*.cs");
            List<System.IO.FileInfo> fileList = new List<System.IO.FileInfo>();
            foreach (string name in fileNames) fileList.Add(new System.IO.FileInfo(name));
            string searchTerm = @"foreach";
            //创建查询：获取.cs源文件的文件大小列表
            var queryMatchingFiles = from file in fileList
                         let fileText = GetFileText(file.FullName)
                         where fileText.Contains(searchTerm)
                         select file.FullName;
            //执行查询，并循环显示结果
            foreach (string filename in queryMatchingFiles) Console.WriteLine(filename);
            Console.ReadKey();
        }
        static string GetFileText(string name) //读取文件列表
        {
            string fileContents = String.Empty;
            if (System.IO.File.Exists(name)) fileContents = System.IO.File.ReadAllText(name);
            return fileContents;
        }
    }
}
