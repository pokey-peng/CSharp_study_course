using System;
namespace CSharpBook.Chapter02
{  
   class VariableTest
   {  
        static void Main()
        {
            int i1;                                //声明整型变量
            i1 = 123;                              //变量赋初值
            int i2 = 456;                           //声明整型变量并赋初值
            double d1 = 12.3, d2 = 45.6, d3;           //声明double型变量，并有两个变量赋初值
            Console.WriteLine("i1={0}, i2={1}", i1, i2); 
            Console.WriteLine("d1={0}, d2={1}", d1, d2);
            // Console.WriteLine("d3={0}", d3);        //编译错误：变量d3被访问之前没有赋值
            Console.ReadLine();
        }
    }
}
