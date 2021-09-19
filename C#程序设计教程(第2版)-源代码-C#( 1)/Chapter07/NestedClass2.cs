using System;
namespace CSharpBook.Chapter07
{
  class Container
  {
    protected string name = "Container";
    private void sayHello()
    {
        Console.WriteLine("Hello, Container!");
    }
    public class Nested  // 嵌套类
    {
        protected string name = "Nested:";
        public void sayHello()
        {
            Container c = new Container();
            Console.WriteLine("Contatiner c.name={0}",c.name);
            //引用包含类Container的protected字段
            c.sayHello(); //调用包含类Container的private方法sayHello()
        }
    }
  }
  class Test
  {
    static void Main()
    {
      Container.Nested n = new Container.Nested(); n.sayHello(); Console.ReadKey();
    }
  }
}
