using System;
namespace CSharpBook.Chapter05
{
    class DeleteData
    {
        static void Main()
        {
            int i, k;
            int[] A = new int[]{23,45,78,98,120,156,185,200};
            Console.WriteLine("原始有序数组: ");
            foreach (int item in A) Console.Write("{0,5} ", item);
            Console.Write("\n请输入要删除的一个整数:   ");
            int x = int.Parse(Console.ReadLine());  //将数字字符串转换为等效的整数
            int N = A.Length;         //获取有序数组A的长度N
            for (k = 0; k < N; k++) 
            {
                if (x == A[k]) break;   //找到数据插入的位置k
            }
            if (k == N)
            {
                Console.WriteLine("数组中无此数，无法删除！"); return;
            }
            //从第k+1个元素开始到最后一个元素依次往前平移一个位置
            for (i = k+1; i < N; i++) A[i-1] = A[i];
            Console.WriteLine("删除数据后的数组: ");
            for (i = 0; i < A.Length-1; i++) Console.Write("{0,5} ", A[i]);
            Console.WriteLine();
        }
    }
}
