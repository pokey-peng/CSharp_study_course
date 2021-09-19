using System;
namespace CSharpBook.Chapter05
{
  class InsertData
  {
    static void Main()
    {
        int i, k;
        int[] A = new int[]{23,45,78,98,120,156,185,200,0};//最后的0是预留位置,不属于数组内容
        Console.WriteLine("原始有序数组: ");
        for (i = 0; i < A.Length - 1; i++) Console.Write("{0,5} ", A[i]);
        Console.Write("\n请输入要插入到升序数组中的一个整数:   ");
        int x = int.Parse(Console.ReadLine()); //将数字字符串转换为等效的整数
        int N = A.Length-1;         //获取有序数组A的长度N
        for (k = 0; k < N; k++) 
        {
              if (x < A[k]) break;     //找到数据插入的位置k
        }
        //从最后一个元素开始往后平移,为新数据腾出位置
        for (i = N; i > k; i--) A[i] = A[i - 1]; A[k] = x; //插入新数据
        Console.WriteLine("插入数据后的数组: ");
        foreach (int item in A) Console.Write("{0,5} ", item); Console.WriteLine();
    }
  }
}
