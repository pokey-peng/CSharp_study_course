class Person
{
    public const int RETIREMENT_AGE = 65;  //访问不受限制
    public string name;       //访问不受限制
    internal string nickName;  //在自定义Person类的程序内可访问
    protected bool isMarried;  //在Person类或者其派生类中可访问
    private int age;          //只在Person类内可访问
    string creditCardNum;    //使用默认访问修饰符private，只在Person类内可访问
    public void Speak()      //访问不受限制
    {
       System.Console.WriteLine("Hello!");
    }
    private void Method1()      //只在Person类内可访问
    {  //…
      // 类Person内的方法对本类所有成员都可访问，具体地：
      //（1）RETIREMENT_AGE可访问（2）name可访问（3）nickName可访问
     //（4）isMarried可访问（5）age可访问（6）creditCardNum可访问（7）Speak()可访问
    }
}
class Student : Person
{
    private void Method2()
    {  //…
       // 位于同一个程序的派生类Student内的方法，对于Person成员的访问权限如下：
       // public、protected和internal成员都可访问；private成员不可访问，具体地：
       // （1）RETIREMENT_AGE可访问（public）（2）name可访问（public）
       // （3）nickName可访问（internal）（4）isMarried可访问（protected）
       // （5）age不可访问（private）（6）creditCardNum不可访问（private）
       // （7）Speak()可访问（public）（8）Method1()不可访问（private）
    }
}
class Dog
{
    private void Method3()
    {  //…
       // 程序内的非派生类内的方法，对于Person成员的访问权限如下：
       // public和internal成员都可访问；protected和private成员不可访问，具体地：
      //（1）RETIREMENT_AGE可访问（public）（2）name可访问（public）
      //（3）nickName可访问（internal）（4）isMarried不可访问（protected）
      //（5）age不可访问（private）（6）creditCardNum不可访问（private）
      //（7）Speak()可访问（public）（8）Method1()不可访问（private）
   }
}
