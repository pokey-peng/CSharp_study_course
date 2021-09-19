// compile：csc /t:library Person.cs  --> Person.dll

using System;
namespace CSharpBook.Chapter06
{
    public class Person
    {
        public String name; protected int age; //姓名（public）、年龄（protected）
        public Person()
        {               //不带参数的构造方法
            this.name = "未知"; this.age = 0;
        }
        public Person(String name, int age)
        { //带2个参数的构造方法
            this.name = name; this.age = age;
        }
        public void print()
        {             //输出人员信息
            Console.WriteLine("name={0}, age={0}\n", this.name, this.age);
        }
    }
}
