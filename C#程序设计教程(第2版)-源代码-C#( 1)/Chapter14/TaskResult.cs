using System;using System.Threading.Tasks;
namespace CSharpBook.Chapter14
{
    class TaskResult
    {
        public static void Main()
        {
            Task<double> task1 = Task<double>.Factory.StartNew(() => Math.Pow(2, 10));
            double result = task1.Result;
            Console.WriteLine("2的10次方为{0}", result);
            Console.ReadKey();
        }
    }
}
