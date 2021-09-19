using System;
namespace CSharpBook.Chapter07
{
  class TimePeriod
  {
    private double seconds;
    public double Hours
    {   
        get { return seconds / 3600; }       //秒转换为小时
        set
        {
            if (value > 0)
                seconds = value * 3600;   //小时转换为秒
            else
                Console.WriteLine("Hours的值不能为负数");
        }
    }
  }
  class Program
  {
    static void Main()
    {
        TimePeriod t = new TimePeriod();
        t.Hours = -6;         //调用set访问器
        t.Hours = 6;          //调用set访问器
        //调用get访问器
        Console.WriteLine("以小时为单位的时间： " + t.Hours);
        Console.ReadLine();
    }
  }
}
