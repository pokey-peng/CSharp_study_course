using System;
namespace CSharpBook.Chapter07
{
  public class CalendarDate
  {
    public int month=1; public int day=1; public int year=2014; //声明字段并初始化
  }
  public class CalendarDateTest
  {
    public static void Main()
    {
      CalendarDate birth = new CalendarDate();
      birth.month = 7;      //访问字段
      Console.WriteLine("{0}/{1}/{2}",birth.year,birth.month,birth.day);
      Console.ReadKey();
    }
  }
}
