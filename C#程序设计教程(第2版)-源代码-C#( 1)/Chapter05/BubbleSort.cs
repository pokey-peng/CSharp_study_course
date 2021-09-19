using System;
namespace CSharpBook.Chapter05
{
    class BubbleSort
    {
        public static void DisplayArray(int[] A)    //打印数组
        { 
            foreach (int i in A) Console.Write("{0,5} ", i);
            Console.WriteLine();
        }
        static void Main()
        {
            int i, t;  int[] A = new int[10];  Random rNum = new Random();
            //数组A赋值(0~100之间的随机数)
            for (i = 0; i < A.Length; i++) A[i] = rNum.Next(101);
            Console.WriteLine("原始数组: ");  DisplayArray (A);
            int N = A.Length;                     //获取数组A的长度N
            for (int loop = 1; loop <= N - 1; loop++)   //外循环进行N-1轮比较
            {
                for (i = 0; i <= N - 1 - loop; i++)     //内循环两两比较，大数下沉
                    if (A[i] > A[i + 1])
                    {
                        t = A[i];  A[i] = A[i + 1];  A[i + 1] = t;
                    }
            }
            Console.WriteLine("升序数组: ");  DisplayArray (A); // 打印数组
        }
    }
}
