using System;using System.Threading.Tasks;
namespace CSharpBook.Chapter14
{
    class AsyncAwait
    {
        private static async Task DoWorkAsync()
        {
            await Task.Run(() =>
            {
                long sum = 0;
                for (long i = 0; i < 99999999; i++) { sum += i; }
                Console.WriteLine("异步方法计算结果为：{0}", sum);
            });
        }
        public static void Main()
        {
            Console.WriteLine("开始调用异步方法");
            DoWorkAsync();
            Console.WriteLine("继续执行Main方法");
            Console.ReadKey();
        }
    }
}
