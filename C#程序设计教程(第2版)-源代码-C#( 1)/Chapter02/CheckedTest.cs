using System;
class CheckedTest
{
    static void Main(string[] args)
    {
        int i = int.MaxValue;//结果：2147483647
        try
        {
            int j = checked(i + 1); //发生异常
        }
        catch (System.OverflowException e)
        {
            Console.WriteLine(e.ToString());
        }
        unchecked
        {
            long i1 = 2147483649;
            int j1 = (int)i1;//结果：-2147483647
            Console.WriteLine(i1);
            Console.WriteLine(j1);
        }
        Console.ReadKey();
    }
}
