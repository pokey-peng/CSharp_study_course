using System;
namespace CSharpBook.Chapter02
{
    class CharVariable
    {
        static void Main(string[] args)
        {
            //char char0 = "Z";    //使用双引号会产生编译错误
            char ch1 = 'X';        //字符常量
            char ch2 = '\x0058';   //16进制编码
            char ch3 = (char)88;   //从整型转换
            char ch4 = '\u0058';   //Unicode
            Console.WriteLine("{0}\t{1}\t{2}\t{3}", ch1, ch2, ch3, ch4);
            Console.WriteLine("{0}的小写字母是：{1}", ch1, Char.ToLower(ch1));
            Console.WriteLine("{0}是字母吗？{1}", ch1, Char.IsLetter(ch1)); Console.ReadLine();
            Console.ReadKey();
        }
    }
}
