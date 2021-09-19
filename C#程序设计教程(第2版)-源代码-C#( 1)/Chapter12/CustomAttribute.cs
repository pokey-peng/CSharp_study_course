using System;
namespace CSharpBook.Chapter12
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct,
                    AllowMultiple = true)  //允许单个实体应用多次该特性
    ]
    public class AuthorAttribute : Attribute
    {
        string name; public double version; //作者姓名、版本
        public AuthorAttribute(string name)
        {
            this.name = name; version = 1.0; //设置作者姓名、默认版本值
        }
        public string GetName()  //获取作者姓名信息
        {
            return name;
        }
    }
    [Author("Qingsong YU")]
    class FirstClass { }
    //无作者特性
    class SecondClass {  }
    [Author("Qingsong YU"), Author("Angela", version = 2.0)]
    class ThirdClass {   }
    class TestAuthorAttribute
    {
        static void Main()
        {  //打印3位作者的信息
            PrintAuthorInfo(typeof(FirstClass));
            PrintAuthorInfo(typeof(SecondClass));
            PrintAuthorInfo(typeof(ThirdClass)); Console.ReadKey();
        }
        private static void PrintAuthorInfo(System.Type t)
        {
            Console.WriteLine("{0} 的作者信息：", t);
            Attribute[] attrs = Attribute.GetCustomAttributes(t);//反射技术
            foreach (Attribute attr in attrs)
            {
                if (attr is AuthorAttribute)
                {
                    AuthorAttribute a = (AuthorAttribute)attr;
                    Console.Write("{0}, 版本 {1:f}\n", a.GetName(), a.version);
                }
            }
        }
    }
}
