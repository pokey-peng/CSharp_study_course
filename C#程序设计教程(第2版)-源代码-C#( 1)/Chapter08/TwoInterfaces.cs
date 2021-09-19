using System;
namespace CSharpBook.Chapter08 
{ 
  interface IEnglishDimensions //声明接口IEnglishDimensions（以英制inch为单位）
  {
    float Length();  float Width();
  }
  interface IMetricDimensions //声明接口IMetricDimensions（以公制cm为单位）
  {
    float Length();  float Width();
  }
//声明派生类Box，实现两个接口IEnglishDimensions和IMetricDimensions
class Box : IEnglishDimensions, IMetricDimensions
  {
    float lengthInches;  float widthInches;
    public Box(float length, float width)
    {
        lengthInches = length;  widthInches = width;
    }
    // 显式实现IEnglishDimensions中的成员
    float IEnglishDimensions.Length() { return lengthInches;}
    float IEnglishDimensions.Width() { return widthInches;}
    // 显式实现IMetricDimensions中的成员
    float IMetricDimensions.Length()
    {
        return lengthInches * 2.54f;  //英制inch转换为公制cm
    }
    float IMetricDimensions.Width()
    {
        return widthInches * 2.54f;  //英制inch转换为公制cm
    }
    static void Main()
    {   // 类Box的实例box1
        Box box1 = new Box(30.0f, 20.0f);
        //（以英制inch为单位的）IEnglishDimensions的实例
        IEnglishDimensions eDimensions = (IEnglishDimensions)box1;
        // （以公制cm为单位的）IMetricDimensions的实例
        IMetricDimensions mDimensions = (IMetricDimensions)box1;
        // 打印以英制inch为单位的长宽信息
        Console.WriteLine("Length(in): {0}", eDimensions.Length());
        Console.WriteLine("Width (in): {0}", eDimensions.Width());
        //打印以公制cm为单位的长宽信息
        Console.WriteLine("Length(cm): {0}", mDimensions.Length());
        Console.WriteLine("Width (cm): {0}", mDimensions.Width()); Console.ReadKey();
    }
  }
}
