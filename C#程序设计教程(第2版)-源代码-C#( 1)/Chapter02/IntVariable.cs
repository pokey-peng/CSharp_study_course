using System;
namespace CSharpBook.Chapter02
{
    class IntVariable
    {
        static void Main(string[] args)
        {
            Console.Write("请输一个整数：");    //提示输入
            String str1 = Console.ReadLine();      //读取1行，以回车结束
            long data1 = long.Parse(str1); Console.WriteLine("{0}的十六进制为：{0:X}", data1); 
            Console.ReadKey();
        }
    }
}
