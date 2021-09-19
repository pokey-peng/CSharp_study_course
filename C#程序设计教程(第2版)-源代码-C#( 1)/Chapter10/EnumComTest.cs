using System;
namespace CSharpBook.Chapter10
{
    public class EnumTest
    {   //一周7天
        enum Days {Saturday, Sunday, Monday, Tuesday, Wednesday, Thursday, Friday }; 
        enum BoilingPoints {Celcius = 100, Fahrenheit = 212};//沸点的摄氏和华氏温度
        [FlagsAttribute]
        enum Colors { Red = 1, Green = 2, Blue = 4, Yellow = 8 }; //4种颜色
        public static void Main()
        {
            Type weekdays = typeof(Days); Type boiling = typeof(BoilingPoints);
            Console.WriteLine("一周7天，对应于枚举类型Days中的值：");
            foreach (string s in Enum.GetNames(weekdays))
              Console.Write("{0}={1} ", s, Enum.Format(weekdays, Enum.Parse(weekdays, s), "d"));
            Console.WriteLine("\n枚举类型BoilingPoints定义了如下值项：");
            foreach (string s in Enum.GetNames(boiling))
              Console.Write("{0}={1} ", s, Enum.Format(boiling, Enum.Parse(boiling, s), "d"));
            Colors myColors = Colors.Red | Colors.Blue | Colors.Yellow;
            Console.WriteLine("\n枚举变量myColors存放如下颜色的组合：{0}", myColors);
            Console.ReadLine();
        }
    }
}
