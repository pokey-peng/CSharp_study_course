using System;
namespace CSharpBook.Chapter09
{
    delegate void D(int x);
    class C
    {
        public static void M1(int i) { Console.WriteLine("C.M1: " + i);} 
        public static void M2(int i) { Console.WriteLine("C.M2: " + i);}
    }
    class Test
    {
        static void Main()
        {  D cd1 = new D(C.M1);  cd1(-1); //调用 M1
           D cd2 = new D(C.M2);  cd2(-2); //调用M2
           D cd3 = cd1 + cd2; 	cd3(10);   //先调用M1，然后调用M2
           cd3 -= cd1;  cd3(20); //删除M1，调用M2
           cd3 -= cd2;        //删除M2后，调用列表为null
           // cd3(70);         //抛出System.NullReferenceException异常
           cd3 -= cd1;        //没有M1可删除，但不报错
           Console.ReadLine();
        }
    }
}
