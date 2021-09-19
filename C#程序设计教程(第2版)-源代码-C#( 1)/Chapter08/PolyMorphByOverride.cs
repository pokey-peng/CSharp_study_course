using System;
class A0 // 基类
{ 
    public virtual void MethodA()
    {
        Console.WriteLine("调用A0的类的实例方法MethodA()");
    }
}
class A01 : A0 // 派生类
{ 
    public override void MethodA()//重写方法：重写从基类A0继承的方法
    {    
        Console.WriteLine("调用A01的类的实例方法MethodA()");
    }
}
class A02 : A0 // 派生类
{
    public override void MethodA()//重写方法：重写从基类A0继承的方法
    {    
        Console.WriteLine("调用A02的类的实例方法MethodA()");
    }
}
public class PolyMorphByOverride1
{
    public static void Main()
    {
        A0 obj0 = new A0(); A0 obj01 = new A01(); A0 obj02 = new A02();
        obj0.MethodA(); //obj0运行时对象为类型A0，故调用基类A0的MethodA方法
        obj01.MethodA();//obj01运行时对象为类型A01，故调用类A01的MethodA方法
        obj02.MethodA();//obj02运行时对象为类型A02，故调用类A02的MethodA方法
        Console.ReadKey();
    }
}
