using System;
namespace CSharpBook.Chapter07
{
  class Celsius   //摄氏温度
  {
    private float degrees;
    public Celsius(float temp)  //构造函数
    {
        degrees = temp;
    }
    public static explicit operator Fahrenheit(Celsius c) //显式强制转换
    {   // 摄氏温度转换为华氏温度
        return new Fahrenheit((9.0f / 5.0f) * c.degrees + 32);
    }
    public float Degrees
    {
        get { return degrees; }
    }
  }
  class Fahrenheit   //华氏温度
  {
    private float degrees;
    public Fahrenheit(float temp)  //构造函数
    {
        degrees = temp;
    }
    public static implicit operator Celsius(Fahrenheit f) //隐式自动转换
    {   // 华氏温度转换为摄氏温度
        return new Celsius((5.0f / 9.0f) * (f.degrees - 32));
    }
    public float Degrees
    {
        get { return degrees; }
    }
  }
  class MainClass
  {
    static void Main()
    {
        Fahrenheit f = new Fahrenheit(100.0f);
        Console.Write("{0} 华氏温度", f.Degrees);
        Celsius c = f;            //隐式自动转换
        Console.WriteLine("\n = {0} 摄氏温度", c.Degrees);
        Fahrenheit f2 = (Fahrenheit)c;    //显式强制转换
        Console.WriteLine(" = {0}华氏温度", f2.Degrees);  Console.ReadLine();
    }
  }
}
