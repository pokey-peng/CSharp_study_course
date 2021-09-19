using System;
namespace CSharpBook.Chapter11
{
    class Person { }
    class Student : Person { }
    public interface IGroup<out T> { };
    public class Group<T> : IGroup<T> { };
    public interface ICollect<T> { };
    public class Collect<T> : ICollect<T> { };
    public class CovariantInterface
    {
        public static void Main()
        {
            IGroup<Student> groupOfStudent = new Group<Student>();
            IGroup<Person> groupOfPerson = groupOfStudent; //接口协变
            groupOfStudent = (IGroup<Student>)groupOfPerson;
            ICollect<Student> collectOfStudent = new Collect<Student>();
            //ICollect<Person> collectOfPerson = collectOfStudent;//编译错误。不支持协变
        }
    }
}
