using System;
namespace CSharpBook.Chapter08 
{ 
  public interface IDimensions  //基类：接口IDimensions
  {
    float getLength(); float getWidth();
  }
  public class Box : IDimensions    //派生类Box
  {
    float length;  float width;
    Box(float length, float width)
    {
        this.length = length;  this.width = width;
    }
    public float getLength() { return length;}
    public float getWidth() { return width; }
    static void Main()
    {
        Box box1 = new Box(30.0f, 20.0f);
        Console.WriteLine("Length: {0}", box1.getLength());
        Console.WriteLine("Width: {0}", box1.getWidth());Console.ReadKey();
    }
  }
}
