using System;
namespace CSharpBook.Chapter01
{
    class ComFormat
    {
       static void Main(string[] args)
       {
          Console.WriteLine("{0:C3}", 12345.6789); // 显示： ￥12,345.679
          Console.WriteLine("{0:D8}", 12345);     // 显示： 00012345
          Console.WriteLine("{0:E10}", 12345.6789); // 显示： 1.2345678900E+004
          Console.WriteLine("{0:F3}", -17843);      // 显示：  -17843.000
          Console.WriteLine("{0:00000.000}", 123.45);// 显示： 00123.450
          Console.WriteLine("{0:#####.###}", 123.45); // 显示： 123.45
          DateTime date1 = new DateTime(2014, 4, 10, 6, 30, 0);
          Console.WriteLine(date1.ToString("yyyy/MM/dd hh:mm:ss")); //显示： 2014/04/10 06:30:00
       }
    }
}
