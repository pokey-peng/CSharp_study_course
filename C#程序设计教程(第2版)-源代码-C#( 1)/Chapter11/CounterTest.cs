using System;
class Counter<T> { public static int Count; }
class CounterTest
{
    static void Main()
    {
        Console.WriteLine(++Counter<int>.Count); // 1
        Console.WriteLine(++Counter<int>.Count); // 2
        Console.WriteLine(++Counter<string>.Count); // 1
        Console.ReadKey();
    }
}
