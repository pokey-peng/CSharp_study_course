using System;
namespace CSharpBook.Chapter07
{
class Container
{
    string name = "Container";
    public void sayHello()
    { // 构造内部类实例时，传入包含内部类的类的this实例
        Nested n = new Nested(this);  n.sayHello();
    }
    public class Nested
    {
        Container c_parent;        // 用于保存外部类的实例
        public Nested(Container parent) // 构造函数
        {
            c_parent = parent;
        }
        public void sayHello()
        {
            Console.WriteLine(c_parent.name);
        }
    }
}
class Test
{
    static void Main()
    {
      Container c = new Container (); c.sayHello(); Console.ReadKey();
    }
}
}
