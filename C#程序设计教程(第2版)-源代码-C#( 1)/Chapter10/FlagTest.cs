using System;
namespace CSharpBook.Chapter10 
{ 
  [Flags]   //指示可以将枚举作为位域（即一组标志）处理
  public enum Seasons
  {
    Spring = 0x01, Summer = 0x02, Autumn = 0x04, Winter = 0x08,
  }
  class FlagTest
  {
    static void Main()
    {
        Seasons options = Seasons.Summer | Seasons.Winter;
        Console.WriteLine("options = "+options);
        //Console.WriteLine("(int)options = "+(int)options); 
Console.WriteLine("(int)options = {0:x}",(int)options);Console.ReadLine();
    }
  }
}
