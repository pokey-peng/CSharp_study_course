using System;
namespace CSharpBook.Chapter05
{
    class Array1Ds
    {
        public static void DisplayArray(int[] A)  // 打印数组内容
        { 
            foreach (int i in A) Console.Write("{0,5} ", i);
            Console.WriteLine();
        }
        static void Main()
        {
            int i, sum = 0, MaxA, MinA, MaxI=0, MinI=0, t;
            int[] A = new int[10] ;  Random rNum = new Random();
            for (i = 0; i < A.Length; i++) A[i] = rNum.Next(11); //数组赋值(0~10随机数)
            Console.WriteLine("原始数组: ");  DisplayArray(A);
            //求数组各元素之和、平均值
            for (i = 0; i < A.Length; i++) sum += A[i];
            Console.WriteLine("数组各元素之和={0},平均值={1}", sum, sum/A.Length);
            //求数组最大值、最小值以及所在位置
            MaxA = A[0];  MinA = A[0];
            for (i = 0; i < A.Length; i++)
            {
                if (A[i] < MinA)
                {
                    MinA = A[i];  MinI = i;
                }
                if (A[i] > MaxA)
                {
                    MaxA = A[i];  MaxI = i;
                }
            }
            Console.WriteLine("数组最大值 = {0}, 最小值 = {1}", MaxA, MinA);
            //最小值与数组第一个元素交换
            t = A[0]; A[0] = A[MinI]; A[MinI] = t;
            //最大值与最后一个元素交换
            t = A[A.Length - 1]; A[A.Length - 1] = A[MaxI]; A[MaxI] = t;
            Console.WriteLine("元素交换后的数组: "); DisplayArray(A); //打印数组
        }
    }
}
