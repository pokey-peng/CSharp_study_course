// compile：csc /unsafe 5-11-PointerOp.cs  -> 5-11-PointerOp.exe
using System;
namespace CSharpBook.Chapter05
{
    struct CoOrds  // 平面坐标点
    {
        public int x;  public int y;
    }
    unsafe class PointerOp
    {
        static void Main()
        {   //（1）获取变量的地址和变量的值，并通过指针操作更改变量的值
            int number=10;
            int* pi = &number; // 将整数number的地址赋给指针变量pi
            Console.WriteLine("整数number原始的值 = {0}", number);
            Console.WriteLine("*pi原始的值 = {0}", *pi); // 打印*p原始的值
            // 打印pi的值（即整数number的地址）
            Console.WriteLine("pi（即整数number的地址） = {0:X}", (int)pi);
            *pi = 20; // 通过指针操作更改整数number的值
            Console.WriteLine("指针操作后*pi的值 = {0}", *pi); // 打印*pi的值
            // 打印整数number更改后的值
            Console.WriteLine("指针操作后整数number的值 = {0}", number);
            //（2）通过指针访问成员
            CoOrds school;  // 学校坐标
            CoOrds* p = &school;
            p->x = 25; p->y = 12;     // 学校坐标x、y
            Console.WriteLine("\n(p->x形式打印)学校的坐标值 ： x={0}, y={1}", p->x, p->y);
            //表达式 p->x 等效于表达式 (*p).x，使用这两个表达式可获得相同的结果
            Console.WriteLine("(*p).x形式打印)学校的坐标值 ： x={0}, y={1}", (*p).x, (*p).y);
            //（3）通过指针访问数组元素
            char* charPointer = stackalloc char[123]; //在堆栈上分配内存
            for (int i = 65; i < 123; i++)
            {
                charPointer[i] = (char)i;         // 等价于 *(charPointer+i) = (char)i;
            }
            // 打印大写字母
            Console.Write ("\n大写字母：");
            for (int i = 65; i < 91; i++)
            {
                Console.Write(charPointer[i]);   // 等价于 Console.Write(*(charPointer+i));
            }
            // 打印小写字母
            Console.Write ("\n小写字母：");
            for (int i = 97; i < 123; i++)
            {
                Console.Write(charPointer[i]);  // 等价于 Console.Write(*(charPointer+i));
            }
            Console.WriteLine("\n");
            //（4）递增和递减指针
            // 通过将指针增加int的大小来遍历一个数组。对于每一步，均显示数组元素的内容和地址
            int[] numbers = { 0, 1, 2, 3, 4 };
            // 将数组地址赋给指针
            fixed (int* p1 = numbers)  //临时固定一个变量，以获取其地址
            {  // 遍历数组元素
                for (int* p2 = p1; p2 < p1 + numbers.Length; p2++)
                {
                    Console.WriteLine("数组元素的内容：{0}， 地址：{1:X}", *p2, (int)p2);
                }
            }
            //（5）使用算术运算符+和-来操作指针
            int* memory = stackalloc int[30];
            long* difference;
            int* pi1 = &memory[4];
            int* pi2 = &memory[10];
            difference = (long*)(pi2 - pi1);
            Console.WriteLine("\n指针（&memory[10]-&memory[4]）相减的差为： {0}\n", (long)difference);
            //（6）指针比较
            int x = 234;  int y = 236;  int* px = &x;  int* py = &y;
            Console.WriteLine("x为{0}, y为{1}, px为{2:X}, py为{3:X}", x ,y, (int)px, (int)py);
            Console.WriteLine("指针比较：px>py为{0}, px<py为{1}",  px > py,  px < py);
        }
    }
}
