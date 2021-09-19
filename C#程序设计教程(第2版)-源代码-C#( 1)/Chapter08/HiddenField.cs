using System;
class Parent            // 基类Parent
{
    public String name;
    public String sex;
}
class Child : Parent      // 派生类Child
{
    public String name;  // 成员变量，隐藏从基类继承的同名成员变量name
    public Child(String name, String sex) // 构造函数
    {
        this.name = name;            //this.name引用Child声明的成员变量
        this.sex = sex;               //this.sex引用从Parent继承的成员变量
        base.name = name + "'s parent"; //base.name引用从基类Parent继承的同名成员变量name
    }
    public void print()
    {
        Console.WriteLine(this.name + " " + this.sex + " " + base.name);
    }
}
public class HiddenFieldDemo
{
    static void Main(string[] args)
    {
        Child obj1 = new Child("Mary", "F");
        obj1.print();  Console.ReadKey();
    }
}
