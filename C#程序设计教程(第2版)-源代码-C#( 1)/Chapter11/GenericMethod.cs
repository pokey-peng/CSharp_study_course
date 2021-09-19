using System;
namespace CSharpBook.Chapter11
{
  public class GenericMethod
  { 
    static void Swap<T>(ref T lhs, ref T rhs) //声明泛型方法：两者交换
    {
        T temp; temp = lhs; lhs = rhs; rhs = temp;
    }
    public static void Main()
    {
        int a = 1; int b = 2;
        Console.WriteLine("Original value, a = {0} , b = {1}", a, b);
        Swap<int>(ref a, ref b); //调用泛型方法：指定泛型参数的类型
        Console.WriteLine("After swapping, a = {0} , b = {1}", a, b);
        double c = 1.1d; double d = 2.2d;
        Console.WriteLine("Original value, c = {0} , d = {1}", c, d);
        Swap(ref c, ref d); //调用泛型方法：省略类型参数，编译器将推断出该参数
        Console.WriteLine("After swapping, c = {0} , d = {1}", c, d); Console.ReadLine();
    }
  }
}
