using System;
namespace CSharpBook.Chapter07
{
  class SimpleMath
  {
    public int AddTwoNumbers(int number1, int number2) //两数相加
    {
        return number1 + number2;
    }
    public int SquareANumber(int number) //求某数的平方
    {
        return number * number;
    }
    public static void DisplayResult(int number) //显示结果
    { 
        Console.WriteLine("结果为：{0}", number);
    }
  }
  class SimpleMathTest
  {
    public static void Main()
    {
        int result; SimpleMath obj=new SimpleMath();
        result=obj.AddTwoNumbers(1, 2);  //两数相加
        SimpleMath.DisplayResult(result);  //显示相加结果
        SimpleMath.DisplayResult(obj.SquareANumber(result)); //显示某数的平方
        Console.ReadLine();
    }
  }
}
