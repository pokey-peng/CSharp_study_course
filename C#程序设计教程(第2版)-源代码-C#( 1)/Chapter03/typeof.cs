using System;
namespace CSharpBook.Chapter03
{
    public class SampleClass
    {
        static void Main()
        {
            Type t1 = typeof(bool);
            Console.WriteLine("typeof(bool) is {0}", t1);
            int radius = 5;  Type t2 = radius.GetType();
            Console.WriteLine("radius.GetType() is {0}", t2);
            Console.WriteLine("Area = {0}", radius * radius * Math.PI);
            Console.WriteLine("The type of Area is {0}", (radius * radius * Math.PI).GetType());
            Console.ReadKey();
        }
    }
}
