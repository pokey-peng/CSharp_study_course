using System;
namespace CSharpBook.Chapter09
{
    public delegate void SampleEventHandler(object sender, EventArgs e);
    public class Publisher
    {
        public event SampleEventHandler SampleEvent; //声明事件
        protected virtual void RaiseSampleEvent()     //产生事件
        {  //若不需要传递消息参数，可直接使用EventArgs对象
            SampleEvent(this, new EventArgs());    //引发事件
        }
    }
    public class Subscriber
    {
        public static void Method1(object sender, EventArgs e)
        {
            Console.WriteLine("To Do Something...");
        }
        public static void Method2(object sender, EventArgs e)
        {
            Console.WriteLine("To Do Something...");
        }
        public static void Main()
        {  //创建委托实例
            SampleEventHandler d1 = new SampleEventHandler(Subscriber.Method1);
            Publisher p = new Publisher(); //订阅事件
            p.SampleEvent += d1;
            p.SampleEvent += new SampleEventHandler(Subscriber.Method2);//订阅事件
            p.SampleEvent -= d1;       //取消事件
        }
    }
}
