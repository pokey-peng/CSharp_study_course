using System;
namespace CSharpBook.Chapter01
{
    class ConsoleIO
    {
        static void Main(string[] args)
        {
           Console.Clear();                      //清屏
           Console.Write("请输入您的姓名：");    //提示输入
           String s = Console.ReadLine();          //读取1行，以回车结束
           Console.Beep();                      //提示音
           Console.WriteLine("欢迎您！" + s);     //输出读取的内容
           Console.Read();                      //按回车键结束
        }
    }
}
