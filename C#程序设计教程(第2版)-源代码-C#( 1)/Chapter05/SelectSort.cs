using System;
namespace CSharpBook.Chapter05
{
    class SelectSort
    {
        public static void DisplayMatrix(int[] A)
        {
            foreach (int i in A) Console.Write("{0,5} ", i);
            Console.WriteLine();
        }

        static void Main()
        {
            int i, t, MinI;
            int[] A = new int[10];

            Random rNum = new Random();

            for (i = 0; i < A.Length; i++) A[i] = rNum.Next(100); //数组A赋值(0~100之间的随机数)

            Console.WriteLine("原始数组: ");
            DisplayMatrix(A);

            int N = A.Length; //获取数组A的长度N
            for (int loop = 0; loop <= N - 2; loop++)//外循环进行N-1轮比较
            {
                MinI = loop;
                for (i = loop; i <= N - 1; i++)    //内循环中在无序数中找最小值
                    if (A[i] < A[MinI]) MinI = i;
 
                //最小值与无序数中的第一个元素交换
                t = A[loop];
                A[loop]=A[MinI];
                A[MinI] = t;
            }

            Console.WriteLine("升序数组: ");
            DisplayMatrix(A);


            Console.ReadLine();

        }
    }
}