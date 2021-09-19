using System;
public class Person //等同于：class Person : Object
{ 
    public String name;  public int age;
    public Person(String name, int age) //基类构造函数
    { 
        this.name = name;  this.age = age;
    }
    public void print()  //基类的实例方法
    {             
        Console.Write("name={0},age={1}", this.name, this.age);
    }
}
public class Student : Person //派生类
{          
    public String studentID;
    public Student(String name, int age, String id)
        : base(name, age) //派生类构造函数，使用base调用基类构造函数
    { 
        this.studentID = id;
    }
    public new void print()
    {
        base.print();          //使用base调用基类的方法
        Console.WriteLine(",studentID={0}", this.studentID);
    }
}
public class BaseDemo
{
    static void Main(string[] args)
    {
        Student objstudent = new Student("张三", 25, "2014101001");
        objstudent.print(); Console.ReadKey();
    }
}
