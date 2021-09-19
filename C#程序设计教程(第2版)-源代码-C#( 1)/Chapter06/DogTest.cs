//编译出错：csc /r:Dog1.dll DogTest.cs
//编译成功：csc /r:Dog2.dll DogTest.cs  ->  DogTest.exe
namespace CSharpBook.Chapter06
{
  class DogTest
  {
    static void Main(string[] args)
    {
        Dog dog1= new Dog();    // 创建对象
        dog1.SayHello();         // 引用public成员
        System.Console.ReadKey();
    }
  }
}
