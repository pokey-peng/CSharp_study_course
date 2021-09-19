using System;
interface ICommon { void f();}
abstract class Base { public abstract void g();}
class Derived1 : Base, ICommon
{   //重写从基接口ICommon继承的方法f()
    public override void f() { Console.Write("Derived1.f()"); }
    public void g() { Console.Write("Derived1.g()"); }//重写从基类继承的方法g()
    public void h() { Console.Write("Derived1.h()"); }//新定义方法h()
}
class Derived2 : ICommon
{   //重写从基接口ICommon继承的方法f()
    public void f() { Console.Write("Derived2.f()"); }
    public void h() { Console.Write("Derived2.h()"); } // 新定义方法h()
}
public class PolyMorphDemo2
{
    public static void Main()
   {//Derived1对象实例d1表现为Derived类型，故可调用Derived1类及其继承的所有成员方法
        Derived1 d1 = new Derived1(); d1.f(); d1.g(); d1.h();
      //Derived1对象实例c1表现为ICommon接口，故可调用ICommon接口的所有成员方法
        ICommon c1 = new Derived1(); c1.f();
      //Derived1对象实例b1表现为Base类型，故可调用Base类型的所有成员方法
        Base b1 = new Derived1();
        b1.g();       //访问Derived1中重写的方法f()
        //b1.f();      //编译错误，Base中没有声明方法f() 
      // Derived1对象实例o1表现为Object类型，故可调用Object类型的所有成员方法
        Object o1 = new Derived1();
        Console.WriteLine(o1.GetType()); //访问Object中实现的方法GetType()
        //o1.f();     //编译错误，Object中没有声明方法f()
        //Base b2 = new Derived2(); //编译错误，Derived2对象实例不能表现为Base类型
    }
}
