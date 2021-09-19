using System;
namespace CSharpBook.Chapter02
{
    public class TestVariableScope
    {
        static int j = 99;           //静态变量j属于TestVariableScope类
        public static void Main()
        {
          //String[] args ="abc";//args与main方法的参数args作用域相同，冲突。注释此行以运行程序
            for (int i = 0; i < 3; i++)  //局部变量i属于当前的for语句
            {
                int k = 10;         //局部变量k属于当前的for语句
                Console.WriteLine(k + " * " + i + " = " + k * i);
            } //局部变量i和k的作用域到此为止
            // System.out.println(i);    //局部变量i不存在，编译错误。注释此行以运行程序
            int j = 20;               //定义局部变量j，与类的静态变量j不冲突
            Console.WriteLine("class j=" + TestVariableScope.j);
            Console.WriteLine("local j=" + j);
            for (int i = 0; i < 3; i++) //局部变量i属于当前的for语句，重新定义局部变量i不会冲突
            {
                int k = 20;       //局部变量k属于当前的for语句，重新定义局部变量k不会冲突
                // int j = 20;      //重复声明，局部变量冲突，编译错误。注释此行以运行程序
                Console.WriteLine(k + " * " + i + " = " + k * i);
            }
            Console.ReadKey();
        }
    }
}
