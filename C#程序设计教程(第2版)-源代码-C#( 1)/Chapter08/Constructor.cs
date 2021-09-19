using System;
class SuperClass1 //基类1。编译器自动生成默认构造函数
{
    public String name, sex;
}
class SubClass11 : SuperClass1 // 派生类11。编译器自动生成默认构造函数
{
    public int age;
}
class SubClass12 : SuperClass1 // 派生类12
{ 
    public int age;
    public SubClass12() //默认构造函数, 自动调用基类默认构造函数
    {
        Console.WriteLine("调用构造函数SubClass12()...");
    }
}
class SubClass13 : SuperClass1 // 派生类13
{ 
    public int age;
    public SubClass13(int age)// 派生类13的构造函数。
    {
        Console.WriteLine("调用构造函数SubClass13()...");
    }
}
class SuperClass2// 基类2。定义带2个参数的构造函数。无默认构造函数
{
    public String name;  public String sex;
    public SuperClass2(String name, String sex) // 基类2的构造函数
    {
        this.name = name;  this.sex = sex;
        Console.WriteLine("调用构造函数SuperClass2()...");
    }
}
class SubClass21 : SuperClass2 // 派生类21。编译错误，SuperClass2无默认构造函数
{
    public int age;
}
class SubClass22 : SuperClass2 // 派生类22。编译错误，SuperClass2无默认构造函数
{ 
    public int age;
    public SubClass22()//默认构造函数，自动调用基类默认构造函数。基类无默认构造函数。会导致编译错误
    {
        Console.WriteLine("调用构造函数SubClass22()...");
    }
}
class SubClass23 : SuperClass2
{ // 派生类23
    public int age;
    public SubClass23(String name, String sex, int age)
        : base(name, sex) // 需要显示调用基类构造函数。注释此语句将导致编译错误
    {
        this.age = age;
        Console.WriteLine("调用SubClass23的构造函数SubClass23()...");
    }
}
public class ConstructorDemo
{
    public static void main(String[] args)
    {
        SubClass11 obj11 = new SubClass11();  //调用默认构造函数SubClass11()
        SubClass12 obj12 = new SubClass12();  //调用默认构造函数SubClass12()
        //SubClass13 obj13_1 = new SubClass13();//编译错误，SubClass13无默认构造函数
        SubClass13 obj13_2 = new SubClass13(19);//调用构造函数SubClass13(int age)
        SubClass21 obj21 = new SubClass21();  //调用构造函数SubClass21()
        SubClass22 obj22 = new SubClass22();  //调用构造函数SubClass22()
        //调用构造函数SubClass23(String name, String sex, int age)
        SubClass23 obj23 = new SubClass23("Jack", "M", 19);
    }
}
