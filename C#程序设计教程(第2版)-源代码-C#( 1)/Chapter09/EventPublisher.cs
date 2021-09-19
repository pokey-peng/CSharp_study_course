using System;
namespace CSharpBook.Chapter09
{  //声明事件处理委托
    public delegate void SampleEventHandler(object sender, EventArgs e);
    public class Publisher 
    {
        public event SampleEventHandler SampleEvent; //声明事件
        protected virtual void RaiseSampleEvent()     //产生事件
        {  //若不需要传递消息参数，可直接使用EventArgs对象
            SampleEvent(this, new EventArgs());    //引发事件
        }
    }
}
