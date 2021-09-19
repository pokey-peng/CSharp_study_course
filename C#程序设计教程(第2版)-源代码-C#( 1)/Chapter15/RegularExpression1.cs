using System;using System.Text.RegularExpressions;
namespace CSharpBook.Chapter15
{
    class RegularExpressionDemo1
    {
        static void Main(string[] args)
        {
            MatchCollection mc;
            String[] results = new String[20]; int[] matchposition = new int[20];
            Regex r = new Regex("abc");   //创建Regex对象，并定义正则表达式
            mc = r.Matches("123abc4abcd");//使用Matches方法查找所有匹配项
            Console.WriteLine("源字符串   = " + "123abc4abcd");
            Console.WriteLine("匹配字符串 = " + "abc");
            for (int i = 0; i < mc.Count; i++) // 通过循环检索所有匹配项和位置
            {  
                results[i] = mc[i].Value; //将匹配的string添加到string数组中
                matchposition[i] = mc[i].Index; // 记录匹配的字符位置
                Console.WriteLine("索引位置 = {0}； 结果 = {1}", mc[i].Index, mc[i].Value);
            }
            Console.ReadKey();
        }
    }
}