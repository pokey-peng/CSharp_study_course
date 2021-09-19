using System;using System.Collections.Generic;using System.Linq;
namespace CSharpBook.Chapter13
{
class SplitWithGroups
{
    static void Main()
    {   //读取当前目录中的names1.txt
        string[] fileA = System.IO.File.ReadAllLines(@"./names1.txt");
        //读取当前目录中的names2.txt
        string[] fileB = System.IO.File.ReadAllLines(@"./names2.txt"); 
        var mergeQuery = fileA.Union(fileB); //合并文件内容
        //创建查询：按第一个单词（姓）的第一个字母分组
        var groupQuery = from name in mergeQuery
                         let n = name.Split(',')
                         group name by n[0][0] into g
                         orderby g.Key
                         select g;
        //执行查询，为每个组创建一个新文件，并循环显示结果
        foreach (var g in groupQuery)
        {   //创建新文件的名称
            string fileName = @"./testFile_" + g.Key + ".txt";
            //输出内容到控制台：分组
            Console.WriteLine(g.Key);
            //写入文件
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(fileName))
            {
                foreach (var item in g)
                {
                    sw.WriteLine(item);
                    Console.WriteLine("   {0}", item); //输出内容到控制台
                }
            }
        }
        Console.ReadKey();
    }
  }
}
