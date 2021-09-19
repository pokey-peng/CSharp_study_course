using System;
namespace CSharpBook.Chapter07
{
    class Counter
    {
        public int number;      //实例字段
        public static int count;   //静态字段
        public Counter()       //构造函数
        {
            count = count + 1; number = count;
        }
        public void showInstance()
        {
            Console.Write("object{0} :", number);  //正确：实例方法内可直接引用实例字段
            Console.WriteLine("count={0}", count);//正确：实例方法内可直接引用静态字段
        }
        public static void showStatic()
        {
            //Console.Write("object{0} :", number); //错误：静态方法内不能直接引用实例字段
            Console.WriteLine("count={0}", count); //正确：静态方法内可以直接引用静态字段
        }
    }
    class CounterTest
    {
        public static void Main()
        {
            Counter c1 = new Counter();           //创建对象
            c1.showInstance();                   //正确：用对象调用实例方法
            //c1.showStatic();                     //错误：不能用对象调用静态方法
            Console.Write("object{0} :", c1.number); //正确：用对象引用实例字段
            //Console.Write("object{0} :", Counter.number); //错误：不能用类名引用实例字段
            //Console.WriteLine("count={1}", c1.count); //错误：不能用对象名引用静态字段
            Counter.showStatic();                   //正确：用类名调用静态方法
            //Counter.showInstance ();               //错误：不能用类名调用实例方法
            Counter c2 = new Counter();             //创建对象
            c1.showInstance(); c2.showInstance(); Console.ReadKey();
        }
    }
}
