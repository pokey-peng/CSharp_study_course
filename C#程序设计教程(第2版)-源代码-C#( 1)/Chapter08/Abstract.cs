using System;
namespace CSharpBook.Chapter08
{
    abstract class Animal      // 基类Animal：抽象类
    {
        public String name;
        public abstract void SayHi();
        public Animal(String name) { this.name = name; }  //构造函数
    }
    class Dog : Animal        // 派生类Dog
    {    //重写SayHi()
        public override void SayHi() { Console.WriteLine(this.name + " Wow Wow!"); }
        public Dog(String name) : base(name) { }   //构造函数
    }
    class Cat : Animal        // 派生类Cat
    {  //重写SayHi()
        public override void SayHi() { Console.WriteLine(this.name + " Mew Mew!"); }
        public Cat(String name) : base(name) { }            //构造函数
    }
    //class Horse : Animal { } //编译错误，非抽象类Horse继承了抽象类Animal，但未实现抽象方法
    abstract class Fish : Animal //编译OK，抽象类Fish继承了抽象类Animal，但未实现抽象方法
    {
        public Fish(String name) : base(name) { }
    }
    class TestClass
    {
        static void Main()
        {
            //Animal animal1 = new Animal(); //编译错误，抽象类不能直接实例化
            Animal[] animals = { new Dog("小白"), new Cat("小花") };
            foreach (Animal a in animals) a.SayHi();
            Console.ReadKey();
        }
    }
}
