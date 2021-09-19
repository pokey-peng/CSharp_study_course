// compile：csc /r:Person.dll PersonTest2.cs  ->  PersonTest2.exe
using System;
namespace CSharpBook.Chapter06
{
  class PersonTest2
  {
    static void Main(string[] args)
    {
		Person personA;                //声明Person类型变量
		personA = new Person("张三", 25); //创建Person对象实例并赋值给变量personA
		Person personB = new Person("李四", 18); //创建对象：调用带2个参数的构造方法
		Person personC = new Person();         //创建对象：调用不带参数的构造方法
		personC.name = "王五";                 //访问对象成员变量
		personA.print(); personB.print(); personC.print();//访问对象方法
    }
  }
}
