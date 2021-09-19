using System; using System.Linq;
namespace CSharpBook.Chapter13
{
    class IntroToLINQ
    {
      static void Main()
      {
        string[] words = { "the", "quick", "brown", "fox", "jumps" };
        Console.Write("排序前的字符串：");
        foreach (var w in words) Console.Write("{0} ", w);
        var q1 = from w in words orderby w.Length descending, w.Substring(0, 1) descending select w;
        Console.Write("\n排序后的字符串（使用查询表达式）：");
        foreach (var w in q1) Console.Write("{0} ", w);
        var q2 = words.OrderByDescending(w => w.Length).ThenByDescending(w => w.Substring(0, 1));
        Console.Write("\n排序后的字符串（使用查询方法）：");
        foreach (var w in q2) Console.Write("{0} ", w); Console.ReadKey();
      }
   }
}
