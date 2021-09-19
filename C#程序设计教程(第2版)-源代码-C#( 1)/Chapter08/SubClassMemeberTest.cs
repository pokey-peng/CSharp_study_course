using System;
public class ClassA  // 基类ClassA
{                           
    protected double x_protected;  // 受保护实例字段
    private double y_private;     // 私有实例字段
    public void setY(double y)   // 公共实例方法
    {                  
        this.y_private = y;
    }
    public double getY()     // 公共实例方法
    {                       
        return this.y_private;
    }
    public ClassA(double x, double y) // 带2个参数的构造函数
    {                 
        this.y_private = y;
    }
}
public class ClassB : ClassA
{
    public double z_public;     // 公共实例字段
    public void print()         // 公共实例方法
    {                       
        Console.WriteLine(this.x_protected); //OK，可访问基类的protected成员
        //Console.WriteLine(this.y_private); //编译错误，不能直接访问基类的private成员
        Console.WriteLine(this.getY());   //OK，通过基类的方法间接访问其private成员
        Console.WriteLine(this.z_public);
    }
    public ClassB(double x, double y, double z)
        : base(x, y)// 带3个参数的构造函数，调用基类的构造函数
    {
        this.z_public = z;
    }
}
public class SubClassMemeberTest
{
    static void Main(string[] args)
    {
        ClassB obj = new ClassB(1.0, 2.0, 3.0);
        obj.setY(2.2);                 //访问ClassB的成员setY(double y)，从类ClassA继承
        obj.z_public = 3.3;             //访问ClassB的成员z_public
        Console.WriteLine(obj.GetType());//访问ClassB的成员getClass()，从类Object继承
        obj.print();                   //访问ClassB的成员print()
        Console.ReadKey();
    }
}
