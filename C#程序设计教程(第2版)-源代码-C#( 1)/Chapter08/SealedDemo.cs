using System;
class Parent
{
    public virtual void MethodF(){Console.WriteLine("调用Parent的MethodF()");}
    public virtual void MethodG() { Console.WriteLine("调用Parent的MethodG()"); }
}
class Child : Parent
{
    public sealed override void MethodF()//密封方法。重写从基类继承的方法MethodF()
    {
        Console.WriteLine("调用Child的MethodF()");
    }
    public override void MethodG() //重写从基类继承的方法
    {
        Console.WriteLine("调用Child的MethodG()");
    }
}
sealed class Final : Child //密封类
{
    //public override void MethodF()//编译错误。继承成员Child.MethodF()是sealed，无法重写
    //{    
    //    Console.WriteLine("调用Final的MethodF()");
    //}
    public override void MethodG() //重写从基类继承的方法
    {
        Console.WriteLine("调用Final的MethodG()");
    }
}
//sealed class Final1 : Final{} //编译错误。无法从密封类Final派生
public class FinalDemo
{
    static void Main()
    {
        Final obj = new Final(); obj.MethodF();
        obj.MethodG(); Console.ReadKey();
    }
}
