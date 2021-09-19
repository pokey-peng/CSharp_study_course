using System;
class P0 // 基类
{ 
    public void MethodA(){Console.WriteLine("调用类P0的方法methodA()");}
}
class C0 : P0 // 派生类
{ 
    public void MethodA(String str1) //重载方法：重载从基类继承的MethodA()
    { 
      Console.WriteLine("调用类C0的方法MethodA()：" + str1);
    }
    public void MethodB(String str1) //重载方法：重载MethodB(int a)
    { 
      Console.WriteLine("调用C0类的实例方法MethodB(String str1)：" + str1);
    }
    public void MethodB(int a) // 重载方法：重载MethodB(String str1)
    { 
      Console.WriteLine("调用C0类的实例方法MethodB(int a)：" + a);
    }
}
public class PolyMorphByOverload
{
    public static void Main()
    {
      C0 obj0 = new C0();
      obj0.MethodA("abc"); //静态绑定到C0的对象实例的实例方法MethodA(String str1)
      obj0.MethodB("xyz");//静态绑定到C0的对象实例的实例方法MethodB(String str1)
      obj0.MethodB(123); //静态绑定到C0的对象实例的实例方法MethodB(int a)
      Console.ReadKey();
    }
}
