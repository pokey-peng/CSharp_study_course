using System;
public class ThisTest
{
    public int i1 = 123;        // 声明实例字段并赋初值
    public String s1 = "abc";    // 声明实例字段并赋初值
    public ThisTest(int i1, String s1)
    {
        i1 = i1;       // 变量赋值无意义：左边i1是本地局部变量参数i1，并没有赋值给实例字段this.i1
        s1 = s1;       // 变量赋值无意义：左边s1是本地局部变量参数s1，并没有赋值给实例字段this.s1
        this.i1 = i1;    //OK
        this.s1 = s1;    //OK
    }
    public void printInfo()
    {    //实例方法
        int i1 = 456;       // 声明局部变量，与实例字段重名
        String s1 = "def";   // 声明局部变量，与实例字段重名
        Console.WriteLine(i1 + " " + s1);         // i1和s1为局部变量
        Console.WriteLine(this.i1 + " " + this.s1);  // i1和s1为实例字段
    }
    public static void Main()
    {
        ThisTest obj1 = new ThisTest(999, "zzz");    // 创建对象
        obj1.printInfo();                         // 用对象调用实例方法
        Console.ReadKey();
    }
}
