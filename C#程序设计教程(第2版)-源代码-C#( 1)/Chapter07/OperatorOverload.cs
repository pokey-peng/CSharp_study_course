using System;
namespace CSharpBook.Chapter07
{
  public struct Complex       // 复数
  {
    public int real;           // 实部
    public int imaginary;      // 虚部

    public Complex(int real, int imaginary)  //构造函数
    {
        this.real = real;  this.imaginary = imaginary;
    }
    public static Complex operator +(Complex c1, Complex c2) // 重载运算符(+)
    {
        return new Complex(c1.real + c2.real, c1.imaginary + c2.imaginary);
    }
    public override string ToString()  //重载ToString方法以显示复数的实部和虚部
    {
        return (String.Format("{0} + {1}i", real, imaginary));
    }
  }
  class TestComplex
  {
    static void Main()
    {
        Complex num1 = new Complex(2, 3);  Complex num2 = new Complex(3, 4);
        Complex sum = num1 + num2;        //使用重载运算符(+)
        //调用重载的ToString方法
        Console.WriteLine("第一个复数：   {0}", num1);
        Console.WriteLine("第二个复数：   {0}", num2);
        Console.WriteLine("两个复数之和： {0}", sum); Console.ReadLine();
    }
  }
}
