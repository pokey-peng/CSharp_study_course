using System;  using System.Collections.Generic;
namespace CSharpBook.Chapter11
{
  class Program
  {
    static void Main()
    {
        int[] arr = { 0, 1, 2, 3, 4 };
        List<int> list = new List<int>();
        for (int x = 5; x < 10; x++) list.Add(x); //形成列表5、6、7、8、9
        Console.WriteLine("输出数组列表ArrayList的内容：");
        ProcessItems<int>(arr); Console.WriteLine("输出列表List的内容：");
        ProcessItems<int>(list); Console.ReadLine();
    }
    static void ProcessItems<T>(IList<T> coll)
    {
        foreach (T item in coll) Console.Write(item.ToString() + " ");
        Console.WriteLine();
    }
  }
}
