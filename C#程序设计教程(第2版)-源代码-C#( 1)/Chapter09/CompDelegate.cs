using System;
namespace CSharpBook.Chapter09
{
    class Mammal { }
    class Dog : Mammal { }
    class Comp
    {
        public delegate Mammal HandlerMethod();//定义委托
        public delegate void HandlerMethod1(Mammal m);
        public delegate void HandlerMethod2(Dog d);
        public static Mammal FirstHandler(){Console.WriteLine("first handler"); return null;}
        public static Dog SecondHandler(){Console.WriteLine("second handler"); return null;} 
        public static void ThirdHandler(Mammal m){Console.WriteLine("third handler");}
        static void Main()
        {
            HandlerMethod handler1 = Comp.FirstHandler; //正常匹配
            handler1();
            //协变，返回值Dog默认可转换为Mammal
            HandlerMethod handler2 = Comp.SecondHandler; handler2();
            Mammal m = new Mammal();
            HandlerMethod1 handler11 = Comp.ThirdHandler; //正常匹配
            handler11(m);
            Dog d = new Dog();
            //逆变，参数Dog默认可转换为Mammal
            HandlerMethod2 handler22 = Comp.ThirdHandler;
            handler22(d); Console.ReadKey();
        }
    }
}
