using System;
using System.Threading;
namespace CSharpBook.Chapter09
{   //声明AddDelegate委托
    public delegate int MyDelegate(int op1, int op2, out int result); 
    class AsyncDelegate
    {
        public static int Add(int op1, int op2, out int result)
        {
            Thread.Sleep(5000); //睡眠5000ms，模拟实际耗时操作
            return (result = op1 + op2);
        }
        static void Main()
        {
            int result;
            MyDelegate d = new MyDelegate(AsyncDelegate.Add);//创建委托实例
            //调用BeginInvoke方法用于启动异步调用
            Console.WriteLine("异步调用AsyncDelegate.Add()方法开始");
            IAsyncResult iar = d.BeginInvoke(123, 456, out result, null, null);
            Console.Write("执行其它操作");
            for (int i = 0; i < 10; i++) //模拟其它操作，每隔500ms打印一个句号
            {
                Thread.Sleep(500); Console.Write(".");
            }
            Console.WriteLine("等待");
            //使用IAsyncResult.AsyncWaitHandle获取WaitHandle，使用WaitOne方法执行
            //阻塞等待。异步调用完成时会发出WaitHandle信号，可通过WaitOne等待
            iar.AsyncWaitHandle.WaitOne();
            Console.WriteLine("异步调用AsyncDelegate.Add()方法结束");
            //使用EndInvoke方法检索异步调用结果。调用BeginInvoke后，可随时调用
            //EndInvoke方法；若异步调用未完成，EndInvoke将一直阻塞到异步调用完成
            d.EndInvoke(out result, iar);
            Console.WriteLine("异步调用AsyncDelegate.Add()方法结果：{0}", result);
            Console.ReadKey();
        }
    }
}
