using System;
class Parent {        // 基类
	public void MethodA() {Console.WriteLine("调用methodA()");}
}
class Child : Parent {  // 派生类
	public void MethodB() { Console.WriteLine("调用methodB()");}
}
public class PolyMorphDemo1 {
	public static void Main() {
		Parent oParent = new Parent();
		oParent.MethodA();  // OK，调用ParentClass类的成员方法
		//运行错误：无法将类型为Parent的对象强制转换为类型Child
		//Child oChild1 = (Child)oParent;
		Child oChild = new Child();
		oChild.MethodB();    // OK，调用派生类Child的成员方法
		oChild.MethodA();    // OK，调用基类Parent的成员方法
		Parent oParent1 = oChild;
		oParent1.MethodA();
		//oParent1.MethodB();   //编译错误，Parent不包含MethodB的定义
		Child oChild2 = (Child) oParent1;
		oChild2.MethodB();   // OK，调用派生类ChildClass的成员方法
		oChild2.MethodA();   // OK，调用基类ParentClass的成员方法
		Console.ReadKey();
	}
}
