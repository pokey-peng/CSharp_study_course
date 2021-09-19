using System;
public class TryCatchTest
{
    public static void Main()
    {
        int i1 = 1, i2 = 0, i3, i4;
        try
        {
            i3 = i1 / i2;                     //自动抛出异常DivideByZeroException
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("零除错误！");
        }
        try
        {
            i4 = Int32.Parse("abc");       //自动抛出异常System.FormatException
        }
        catch (FormatException e)
        {
            Console.WriteLine("数值字符串格式错误！");
            throw e;                     // 重新抛出异常
        }
    }
}
