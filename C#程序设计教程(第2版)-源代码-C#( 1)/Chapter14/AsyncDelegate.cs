using System;using System.Threading;
namespace CSharpBook.Chapter09
{   //声明委托
    public delegate int MyDelegate(int op1, int op2, out int result); 
    class AsyncDelegate
    {
        public static int Add(int op1, int op2, out int result)
        {
            Thread.Sleep(5000); //睡眠5000ms，模拟实际的耗时操作
            return (result = op1 + op2);
        }
        static void Main()
        {
            int result;
            MyDelegate d = new MyDelegate(AsyncDelegate.Add); //创建MyDelegate类型委托实例
            //调用BeginInvoke方法用于启动异步调用
            Console.WriteLine("异步调用AsyncDelegate.Add()方法开始");
            IAsyncResult iar = d.BeginInvoke(123, 456, out result, null, null);
            //执行其它操作
            Console.Write("执行其它操作");
            for (int i = 0; i < 10; i++) //模拟其它操作，每隔500ms中打印一个句号
            {
                Thread.Sleep(500);
                Console.Write(".");
            }
            Console.WriteLine("等待");
            //使用AsyncWaitHandle获取WaitHandle，使用其WaitOne方法将执行一直阻塞
            //等待。异步调用完成时会发出WaitHandle信号，可以通过WaitOne来等待它
            iar.AsyncWaitHandle.WaitOne();
            Console.WriteLine("异步调用AsyncDelegate.Add()方法结束");
            //调用BeginInvoke后可随时调用EndInvoke方法；如果异步调用
            //未完成，EndInvoke将一直阻塞到异步调用完成
            d.EndInvoke(out result, iar); //使用EndInvoke方法用于检索异步调用结果
            Console.WriteLine("异步调用AsyncDelegate.Add()方法结果：{0}", result);
            Console.ReadKey();
        }
    }
}
