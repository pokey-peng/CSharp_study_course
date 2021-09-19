using System;
namespace CSharpBook.Chapter07
{
  public class MyColor
  {
    public static readonly MyColor Black = new MyColor(0, 0, 0);
    public static readonly MyColor White = new MyColor(255, 255, 255);
    public static readonly MyColor Red = new MyColor(255, 0, 0);
    public static readonly MyColor Green = new MyColor(0, 255, 0);
    public static readonly MyColor Blue = new MyColor(0, 0, 255);
    public byte red, green, blue;
    public MyColor(byte r, byte g, byte b)
    {
        red = r;  green = g;  blue = b;
    }
  }
  public class ColorTest
  {
    static void Main()
    {
        Console.WriteLine("r={0}, g={1}, b={2}", MyColor.Red.red, MyColor.Red.green, MyColor.Red.blue);
        Console.ReadLine();
    }
  }
}
