using System;
namespace CSharpBook.Chapter02
{
    public class DynamicDemo
    {
        static void Main()
        {
            for (int i = 0; i < 2; i++)
            {
                dynamic arg = (i == 0) ? (dynamic)10 : "A";
                dynamic result = plus(arg);//第一次循环返回int类型，第二次是string类型
                M(result);//根据传给M的值的实际类型，调用相应的重载方法
            }
            Console.ReadKey();
        }
        static dynamic plus(dynamic arg) { return arg + arg; }
        static void M(int n) { Console.WriteLine("M(int):{0}", n); }
        static void M(string s) { Console.WriteLine("M(string):{0}", s); }
    }
}
