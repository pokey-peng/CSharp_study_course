using System;
namespace CSharpBook.Chapter11
{
    class Person { }
    class Student : Person { }
    class MyList<T> { }
    class MySortedList<T> : MyList<T> { }
    class Flock<T> { }
    public class GenericConvert
    {
        public static void Main()
        {
            MyList<String> p1 = new MyList<String>();
            MySortedList<String> c1 = new MySortedList<String>();
            p1 = c1;                   //OK，派生类可直接转换为基类
            c1 = (MySortedList<String>)p1;//OK，派生类可直接转换为基类
            MyList<Person> p2 = new MyList<Person>();
            MyList<Student> c2 = new MyList<Student>();
            p2 = c2;               //编译错误，不同类型参数的对象之间不能转化
            c2 = (MyList<Student>)p2;//编译错误，不同类型参数的对象之间不能转化
        }
    }
}
