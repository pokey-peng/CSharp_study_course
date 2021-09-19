using System;
namespace CSharpBook.Chapter07
{
  class OverloadExample
  {
    public void SampleMethod(double i) 
    {
        Console.WriteLine("SampleMethod(double i):{0}", i);
    }
    public void SampleMethod(int i) 
    {
        Console.WriteLine("SampleMethod(int i):{0}", i);
    }
    public void SampleMethod(ref int i) 
    {
        Console.WriteLine("SampleMethod(ref int i):{0}", i);
    }
    //public void SampleMethod(out int i) { }     //编译错误
    static void Main()
    {
        OverloadExample o = new OverloadExample();
        int i = 10;  double d = 11.1;
        o.SampleMethod(i);     //调用SampleMethod(int i)
        o.SampleMethod(d);    //调用SampleMethod(double i)
        o.SampleMethod(ref i);  //调用SampleMethod(ref int i)
        Console.ReadLine();
    } 
  }
}
