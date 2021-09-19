using System;
namespace CSharpBook.Chapter03
{
    class LogicalTest
    {
        static bool Method1()
        {
            Console.WriteLine("调用Method1，返回False");
            return false;
        }
        static bool Method2()
        {
            Console.WriteLine("调用Method2，返回True");
            return true;
        }
        static void Main()
        {   // 逻辑“非”
            Console.WriteLine("!true={0}, !false={1}", !true, !false);
            // 逻辑“与”& 条件“与”
            Console.WriteLine("逻辑“与”(&):");
            Console.WriteLine("Method1()&Method2()结果是{0}", Method1() & Method2());
            Console.WriteLine("条件“与”(&&):");
            Console.WriteLine("Method1()&&Method2()结果是{0}", Method1() && Method2());
            Console.WriteLine("位逻辑与: 0xf8 & 0x3f = 0x{0:x}", 0xf8 & 0x3f); 
            // 逻辑“或”& 条件“或”
            Console.WriteLine("逻辑“或”(|):");
            Console.WriteLine("Method2()|Method1()结果是{0}", Method2() | Method1());
            Console.WriteLine("条件“或”(||):");
            Console.WriteLine("Method2()||Method1()结果是{0}", Method2() || Method1());
            Console.WriteLine("位逻辑或: 0xf8 | 0x3f = 0x{0:x}", 0xf8 | 0x3f);   
            // 逻辑“异或”
            Console.WriteLine("true^false={0}, false^false={1}", true ^ false, false ^ false);
            Console.WriteLine("位逻辑异或: 0xf8 ^ 0x3f = 0x{0:x}", 0xf8 ^ 0x3f);
            // 混合逻辑运算
            Console.WriteLine("true^!false&false|false={0}",true^!false&false|false);
            Console.ReadKey(); 
        }
    }
}
