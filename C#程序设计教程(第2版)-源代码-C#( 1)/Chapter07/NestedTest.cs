using System;
namespace CSharpBook.Chapter07
{
class Container
{
    public class Nested  //Ç¶Ì×Àà
    {
      public void SayHello()
      {
         Console.WriteLine("Hello, I am a nested class!");
      }
    }
}
class nestTest
{
    static void Main(string[] args)
    {
      Container.Nested nest = new Container.Nested(); nest.SayHello(); Console.ReadKey();
    }
}
}
