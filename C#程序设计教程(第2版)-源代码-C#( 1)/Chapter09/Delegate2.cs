using System;
namespace CSharpBook.Chapter09
{
    delegate void D(int[] A);   // 声明委托
    class ArraySort
{   
        public static void DisplayArray(int[] A) //打印数组
        {  foreach (int i in A) Console.Write("{0,5} ", i); Console.WriteLine(); }
        public static void GeneralSort(int[] A, D sort) 
        {   //通用排序程序
            sort(A);  // 调用排序算法
            Console.WriteLine("升序数组: ");  DisplayArray(A); //显示数组
         }
        public static void BubbleSort(int[] A) 
        {   //冒泡算法
            int i, t;
            int N = A.Length;   //获取数组A的长度N
            for (int loop = 1; loop <= N - 1; loop++)//外循环进行N-1轮比较
            {   for (i = 0; i <= N - 1 - loop; i++) //内循环两两比较，大数下沉
                  if (A[i] > A[i + 1])       //相邻两数交换
                  { t = A[i]; A[i] = A[i + 1]; A[i + 1] = t; }
            }
        }
        public static void SelectSort(int[] A)
        {   //选择算法
            int i, t, MinI;
            int N = A.Length;  //获取数组A的长度N
            for (int loop = 0; loop <= N - 2; loop++)//外循环进行N-1轮比较
            {  MinI = loop;
               for (i = loop; i <= N - 1; i++) //内循环中在无序数中找最小值
                   if (A[i] < A[MinI]) MinI = i;
               t = A[loop]; A[loop] = A[MinI]; A[MinI] = t;//最小值与第一个元素交换
            }
        }
        static void Main()
        {   int[] A = new int[10];  Random rNum = new Random();
            //数组A赋值(0~100之间的随机数)
            for (int i = 0; i < A.Length; i++) A[i] = rNum.Next(101);
            Console.WriteLine("原始数组: "); DisplayArray(A);  //显示数组
            D d1 = new D(ArraySort.BubbleSort);//创建委托实例，指向冒泡算法
            Console.Write("冒泡算法---"); GeneralSort(A, d1);
            D d2 = new D(ArraySort.SelectSort); //创建委托实例，指向选择算法
            Console.Write("选择算法---"); GeneralSort(A, d2); Console.ReadKey();
        }
    }
}
