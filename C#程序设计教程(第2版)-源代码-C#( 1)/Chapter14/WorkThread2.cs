using System;using System.Threading;
namespace CSharpBook.Chapter14
{
  public class Worker
  {  
    public void DoWork()  //工作线程执行逻辑的实现方法
    {
        Console.Write("工作线程开始：");
        while (!_shouldStop)
        {
            Thread.Sleep(50); //让主线程睡眠50毫秒
            Console.Write(".");
        }
        Console.WriteLine("工作线程结束。");
    }
    public void RequestStop()
    {
        _shouldStop = true;
    }
    private volatile bool _shouldStop; //Volatile变量。本数据成员将被多线程访问
  }
  public class WorkerThreadExample
  {
    static void Main()
    {
        Console.WriteLine("主线程：启动工作线程。");
        Worker workerObject = new Worker();//创建工作线程对象。但不启动线程
        Thread workerThread = new Thread(workerObject.DoWork);
        workerThread.Start();//启动工作线程
        while (!workerThread.IsAlive) ; //循环直至激活工作线程
        Thread.Sleep(5000); //让主线程睡眠5000毫秒，以允许工作线程完成自己的工作
        workerObject.RequestStop();//要求工作线程停止自己
        workerThread.Join();//使用Join方法阻止当前线程，直至对象线程终止
        Console.WriteLine("主线程结束。");Console.ReadKey();
    }
  }
}
