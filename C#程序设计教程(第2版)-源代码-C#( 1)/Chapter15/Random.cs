using System;using System.Threading;
namespace CSharpBook.Chapter15
{ 
  public class RandomObjectDemo
  {  //从特定的随机对象生成随机数
     static void RunIntNDoubleRandoms( Random randObj )
    {  //生成6个随机整数
        for( int j = 0; j < 6; j++ ) Console.Write( " {0,10} ", randObj.Next( ) );
        Console.WriteLine( );
        //生成6个随机双精度数.
        for( int j = 0; j < 6; j++ ) Console.Write( " {0:F8} ", randObj.NextDouble( ) );
        Console.WriteLine( );
    }
    //使用特定的种子创建随机对象
    static void FixedSeedRandoms( int seed )
    {
        Console.WriteLine("\n使用特定的种子 seed = {0} 创建随机对象", seed );
        Random fixRand = new Random( seed );
        RunIntNDoubleRandoms( fixRand );
    }
    //使用定时器生成的种子创建随机对象
    static void AutoSeedRandoms( )
    {  //等待以允许定时器计时
        Thread.Sleep( 1 );
        Console.WriteLine( "\n使用自动定时器生成的种子创建随机对象");
        Random autoRand = new Random( ); RunIntNDoubleRandoms( autoRand );
    }
    static void Main( )
    {	
        Console.WriteLine("Random构造函数和Random.NextDouble( )方法示例结果：");
        Console.WriteLine("创建随机对象，然后生成和显示6组整数和双精度数.");
        FixedSeedRandoms(123); FixedSeedRandoms(123); FixedSeedRandoms(456);
        AutoSeedRandoms( ); AutoSeedRandoms( ); Console.ReadLine();
    }
  }
}
