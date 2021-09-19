using System;using System.Text.RegularExpressions;
namespace CSharpBook.Chapter15
{
class RegularExpressionDemo2
{
    static void Main(string[] args)
    {
        String strIn = @"~@ How are you doing? Fine, thanks.!"; 
        //清除掉除“.”（点）、“?”（问号）、空格和“,”（逗点）以外的所有非字母数字字符
        String results = Regex.Replace(strIn, @"[^\w\. ?,]", ""); 
        Console.WriteLine(strIn); Console.WriteLine(results); Console.ReadKey();
    }
}
}
