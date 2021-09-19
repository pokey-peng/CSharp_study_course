using System;using System.Threading;using System.Threading.Tasks;
namespace CSharpBook.Chapter14
{
    class TaskDemo
    {
        public static void Main()
        {
            Task taskA = new Task(() =>{Console.WriteLine("taskA开始…");
                                   Thread.Sleep(5000);//模拟工作过程
                                   });
            taskA.Start();
            taskA.ContinueWith((t) =>{ Console.WriteLine("任务完成，完成时候的状态为：");
            Console.WriteLine("IsCanceled={0};IsCompleted={1};IsFaulted={2}", t.IsCanceled, t.IsCompleted, t.IsFaulted); });
            Console.ReadKey();
        }
    }
}
