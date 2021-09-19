using System;
namespace CSharpBook.Chapter03
{
    class StatementTest
    {
        void PrintArea(int r)
        {  //代码块：printArea的方法体
            const double PI = 3.14;   //声明语句：声明常量
            double a;              //声明语句：声明变量
            if (r > 0)               //控制语句
            {
                a = PI * r * r;       //赋值语句，计算圆面积
                Console.WriteLine("半径={0}, 面积={1}", r, a);
            }
            else
            {
                Console.WriteLine("半径={0}，半径<=0，错误！", r); //调用静态方法
            }
        }
        static void Main()
        {  //代码块：Main的方法体
            StatementTest obj;        //声明语句：声明对象
            obj = new StatementTest(); //赋值语句/创建对象
            for (int i = -2; i < 3; i++)  //循环语句
            {
                obj.PrintArea(i);    //调用对象方法
            }
            Console.ReadKey();
        }
    }
}
