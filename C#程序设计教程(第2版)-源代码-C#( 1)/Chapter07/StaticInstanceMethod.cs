using System;
namespace CSharpBook.Chapter07
{
  public static class TemperatureConverter
  {
    public static double CelsiusToFahrenheit(string temperatureCelsius)//摄氏到华氏温度的转换
    {  
        double celsius = Double.Parse(temperatureCelsius);//参数转换为double类型
        double fahrenheit = (celsius * 9 / 5) + 32;       //摄氏转换到华氏温度
        return fahrenheit;
    }
    public static double FahrenheitToCelsius(string temperatureFahrenheit)//华氏到摄氏温度的转换
    {   
        double fahrenheit = Double.Parse(temperatureFahrenheit);//参数转换为double类型
        double celsius = (fahrenheit - 32) * 5 / 9;             //华氏转换到摄氏温度
        return celsius;
    }
  }
  class TestTemperatureConverter
  {
    static void Main()
    {
        Console.WriteLine("1. 从摄氏温度到华氏温度.");
        Console.WriteLine("2. 从华氏温度到摄氏温度.");
        Console.Write("请选择转换方向：");
        string selection = Console.ReadLine();
        double F, C = 0;
        switch (selection)
        {
            case "1":
                Console.Write("请输入摄氏温度： ");
                F = TemperatureConverter.CelsiusToFahrenheit(Console.ReadLine());
                Console.WriteLine("华氏温度为： {0:F2}", F); break;
            case "2":
                Console.Write("请输入华氏温度： ");
                C = TemperatureConverter.FahrenheitToCelsius(Console.ReadLine());
                Console.WriteLine("摄氏温度为： {0:F2}", C); break;
            default:
                Console.WriteLine("无此选项，只能选择1或2！"); break;
        }
        Console.ReadLine();
    }
  }
}
