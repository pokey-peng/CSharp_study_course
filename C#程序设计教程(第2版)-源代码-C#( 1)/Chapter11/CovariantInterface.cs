using System;
namespace CSharpBook.Chapter11
{
    class Person { }
    class Student : Person { }
    //public delegate T D<out T>();
    public delegate T D1<out T>();
    public delegate void D2<in T>(T t);
    public class CovariantInterface
    {
        static Person Mp1() { return new Person(); }
        static Student Ms1() { return new Student(); }
        static void Mp2(Person p) { }
        static void Ms2(Student s) { }
        public static void Main()
        {
            D1<Student> d1s = CovariantInterface.Ms1;
            D1<Person> d1p = d1s;      //委托的协变
            D2<Person> d2p = CovariantInterface.Mp2;
            D2<Student> d2s = d2p;      //委托的逆变
        }
    }
}
