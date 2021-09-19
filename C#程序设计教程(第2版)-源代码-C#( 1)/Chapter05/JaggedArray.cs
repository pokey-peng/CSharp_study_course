using System;
namespace CSharpBook.Chapter05
{
    class JaggedArray
    {
        static void Main()
        {
            int i, j, k;
            int[][] jaggedArray3 = 
            {   new int[] {1,3,5,7,9},
                new int[] {0,2,4,6},
                new int[] {11,22}
            };
            Console.WriteLine("Àý5 µÄjaggedArray3£º");
            for (i = 0; i < jaggedArray3.Length; i++)
            {
                for (j = 0; j < jaggedArray3[i].Length; j++)
                    Console.Write("A[{0},{1}]={2} ", i,j,jaggedArray3[i][j]);
                Console.WriteLine();
            }
            int[][,] jaggedArray4 = new int[3][,] 
            {   new int[,] { {1,3}, {5,7} },
                new int[,] { {0,2}, {4,6}, {8,10} },
                new int[,] { {11,22}, {99,88}, {0,9} } 
            };
            Console.WriteLine("Àý6µÄjaggedArray4£º");
            for (i = 0; i < jaggedArray4.Length; i++)
            {
                for (j = 0; j<jaggedArray4[i].GetLength(0); j++)
                    for (k = 0; k < jaggedArray4[i].GetLength(1); k++)
                        Console.Write("A[{0}][{1},{2}]={3} ", i,j,k,jaggedArray4[i][j, k]);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
