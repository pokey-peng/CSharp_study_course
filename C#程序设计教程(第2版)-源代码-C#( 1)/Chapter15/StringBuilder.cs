using System;using System.Text;
namespace CSharpBook.Chapter15
{
    public sealed class StringBuilderTest
    {
        static void Main()
        {//创建StringBuilder对象，使其最多可存放50个字符。初始化StringBuilder对象为："ABC"
            StringBuilder sb = new StringBuilder("ABC", 50);
            sb.Append(new char[] { 'D', 'E', 'F' });  //追加3个字符
            sb.AppendFormat("GHI{0}{1}", 'J', 'k'); //追加格式化字符串
            Console.WriteLine("{0} chars，内容为：{1}", sb.Length, sb.ToString());//显示长度和内容
            sb.Insert(0, "Alphabet---");//在最前面插入字符串
            sb.Replace('k', 'K'); //将所有小写字母k替换为大写字母K
            Console.WriteLine("{0} chars，内容为：{1}", sb.Length, sb.ToString());//显示长度和内容
            Console.ReadLine();
        }
    }
}
