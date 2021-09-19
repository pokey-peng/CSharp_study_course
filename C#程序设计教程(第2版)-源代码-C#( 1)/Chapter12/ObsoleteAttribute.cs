using System; using System.Diagnostics;
namespace CSharpBook.Chapter12
{
  [System.Obsolete("use class B")]
  class A
  {
    public void Method() { }
  }
  class B
  {
    [System.Obsolete("use NewMethod", true)]
    public void OldMethod() { }
    public void NewMethod() { }
  }
  class Test
  {
    public static void Main()
    {//产生2条警告信息：“CSharpBook.Chapter12.A”已过时“use class B”！
        A a = new A(); B b = new B(); b.NewMethod();
     //产生错误信息：CSharpBook.Chapter12.B.OldMethod()已过时use NewMethod并终止编译
        b.OldMethod();
    }
  }
}
