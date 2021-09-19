using System;using System.IO;using System.Reflection;
namespace CSharpBook.ChapterAI
{
    class Mymemberinfo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Reflection.MemberInfo");
            // 获取Type和MemberInfo
            Type MyType = Type.GetType("System.IO.File");
            MemberInfo[] Mymemberinfoarray = MyType.GetMembers();
            // 显示结果
            Console.WriteLine("{0}的成员数目： {1}.",
                            MyType.FullName, Mymemberinfoarray.Length);
            foreach (var item in Mymemberinfoarray)
            {
                Console.WriteLine("成员名称：{0} 成员类型：{1}",
                                item.Name, item.MemberType.ToString());
            }
        }
    }
}
