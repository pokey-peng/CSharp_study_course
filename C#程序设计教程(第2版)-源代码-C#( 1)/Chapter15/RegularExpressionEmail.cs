using System;using System.Text.RegularExpressions;
namespace CSharpBook.Chapter15
{
class RegularExpressionEmail
{
    static void Main(string[] args)
    {  //有效的电子邮件正则表达式格式
       String pattern = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
       String strIn1 = "hjiang@yahoo.com";    //有效的电子邮箱
       bool b1 = Regex.IsMatch(strIn1, pattern);
       String strIn2 = "hjiang.yahoo.com";     //无效的电子邮箱
       bool b2 = Regex.IsMatch(strIn2, pattern);
       Console.WriteLine("hjiang@yahoo.com是有效的电子邮件格式吗？"+b1);
       Console.WriteLine("hjiang.yahoo.com是有效的电子邮件格式吗？" +b2); Console.ReadKey();
    }
}
}
