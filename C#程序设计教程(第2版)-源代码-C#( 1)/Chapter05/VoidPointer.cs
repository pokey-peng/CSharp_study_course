// compile：csc /unsafe VoidPointer.cs  ->  VoidPointer.exe
using System;
namespace CSharpBook.Chapter05
{
    unsafe class VoidPointer
    {
        static void Main()
        {   //pv是指向未知类型的指针，pi是指向整数的指针
            //注意：一元间接寻址运算符“*”不能用于void指针
            //使用强制转换将void指针转换为整数（int）指针类型
            int i = 10;  void* pv = &i;  int* pi = (int*)pv;
            Console.WriteLine("i={0}, pi={1:X},pv={2:X}, &i={3:X}, *pi={4}", i, (int)pi, (int)pv, (int)&i, *pi);
        }
    }
}
