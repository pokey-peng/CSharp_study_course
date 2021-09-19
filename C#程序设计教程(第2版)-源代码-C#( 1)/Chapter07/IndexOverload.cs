using System;
namespace CSharpBook.Chapter07
{
  class DayCollection
  { // 星期（字符串）数组
    string[] days = { "Sun", "Mon", "Tues", "Wed", "Thurs", "Fri", "Sat" };
    private int GetDay(string testDay)//返回星期对应的整数，如果不存在，返回-1
    {
        int i = 0;
        foreach (string day in days)
        {
            if (day == testDay)
            {
                return i;
            }
            i++;
        }
        return -1;
    }
    public int this[string day]     //定义基于字符串的索引器
    {
        get
        {
            return (GetDay(day));
        }
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
        DayCollection week = new DayCollection();
        Console.WriteLine("{0}:{1}","Friday",week["Fri"]);
        Console.WriteLine("{0}:{1}","Unknown",week["Unknown"]);  Console.ReadLine();
    }
  }
}
