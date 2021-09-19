using System;using System.Collections.Generic;using System.Linq;
namespace CSharpBook.Chapter13
{
  class SumColumns
  {
    static void Main(string[] args)
    {   // csv文件格式
        // Student ID    Exam#1  Exam#2  Exam#3  Exam#4
        // 2014111,      97,      92,      81,      60
        string[] lines = System.IO.File.ReadAllLines(@"./scores.csv");
        // 创建查询
        IEnumerable<IEnumerable<int>> query =
            from line in lines
            let x = line.Split(',')      //转换为数组
            let y = x.Skip(1)        //跳过第1列学号
            select (from str in y
                  select Convert.ToInt32(str));
        var results = query.ToList();//执行查询并缓存，以提高程序性能
        int columnCount = results[0].Count();// 列数
        for (int column = 0; column < columnCount; column++)
        {// 创建查询：查询各列，并执行聚合运算
            var res2 = from row in results
                    select row.ElementAt(column);
            double average = res2.Average();
            int max = res2.Max(); int min = res2.Min();
            // 显示每次考试的结果：平均分、最高分、最低分
            Console.WriteLine("Exam #{0} 平均分：{1:##.##} 最高分：{2} 最低分：{3}", column + 1, average, max, min);
        }
        Console.ReadKey();
    }
  }
}
