using System;using System.Threading;
namespace CSharpBook.Chapter14
{
    public class PriorityThread
    {
        static void Main()
        {
            Thread tLowest = new Thread(PriorityThread.DoWork1); //创建线程对象实例
            Thread tHighest = new Thread(PriorityThread.DoWork2); //创建线程对象实例
            tLowest.Priority = ThreadPriority.Lowest; //设置线程的优先级
            tHighest.Priority = ThreadPriority.Highest; //设置线程的优先级
            tLowest.Start("Lowest"); //启动线程
            tHighest.Start("Highest"); //启动线程
            Console.WriteLine("请耐心等待5秒......"); Thread.Sleep(5000);
            tLowest.Abort(); tHighest.Abort(); Console.ReadKey();
        }
        public static void DoWork1(object data)
        {
            long count1 = 0;
            try{
                while (true) { count1++;}
            }catch (ThreadAbortException e){
                Console.WriteLine("{0} , count1={1}", data, count1);
            }
        }
        public static void DoWork2(object data)
        {
            long count2 = 0;
            try{
                while (true) { count2++; }
            }catch (ThreadAbortException e){
                Console.WriteLine("{0}, count2={1}", data, count2);
            }
        }
    }
}
