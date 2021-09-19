using System;using System.Threading.Tasks;
namespace CSharpBook.Chapter14
{
    class TaskDemo
    {
        public static void Main()
        {   //创建任务实例
            Task taskA = new Task(() => Console.WriteLine("Hello from taskA."));
            taskA.Start();
            Task taskB = Task.Run(() => Console.WriteLine("Hello from taskB."));
            Task taskC = Task.Factory.StartNew(() => Console.WriteLine("Hello from taskC."));
            Console.ReadKey();
        }
    }
}
