using System;
namespace CSharpBook.Chapter07
{
  class Test 
  { 
    static void Swap(int x, int y)  // 两数交换（值形参）
    { 
        int temp = x; x = y; y = temp; 
    } 
    static void Main() 
    { 
        int i = 1, j = 2; 
        Console.WriteLine("Before swap, i = {0}, j = {1}", i, j);
        Swap(i, j); 
        Console.WriteLine("After swap, i = {0}, j = {1}", i, j); Console.ReadLine();
    } 
  }
}
