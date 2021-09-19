using System;
namespace CSharpBook.Chapter12
{
    [System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Struct,
                      AllowMultiple = true)  //允许单个实体应用多次该特性
    ]
    public class AuthorAttribute : System.Attribute
    {
        private string name; public double version;
        public AuthorAttribute(string name)
        {
            this.name = name; version = 1.0;
        }
    }
    [Author("Qingsong YU", version = 1.1)]
    [Author("Hong JIANG", version = 1.2)]
    class SampleClass
    {   //书写关于Qingsong YU的代码...
        //书写关于Hong JIANG的代码...
        public static void Main() //主程序
        {
          Console.WriteLine("Hello!"); Console.ReadLine();
        }
    }
}
