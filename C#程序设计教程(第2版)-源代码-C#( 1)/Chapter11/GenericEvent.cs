using System;
namespace CSharpBook.Chapter11
{
    delegate void StackEventHandler<T, U>(T sender, U eventArgs);
    class Stack<T>
    {
        public class StackEventArgs : System.EventArgs { }
        public event StackEventHandler<Stack<T>, StackEventArgs> stackEvent;
        protected virtual void OnStackChanged(StackEventArgs a)
        {
            stackEvent(this, a);
        }
        public void add(T a)
        {   //对参数a实施add操作... 
            //引发事件...
            StackEventArgs se = new StackEventArgs();
            OnStackChanged(se);
        }
    }
    class SampleClass
    {
        public void HandleStackChange<T>(Stack<T> stack, Stack<T>.StackEventArgs args)
        {
            Console.WriteLine("HandleStackChange...");
        }
    }
    class TestClass
    {
        public static void Main()
        {
            Stack<double> s = new Stack<double>();
            SampleClass o = new SampleClass();
            s.stackEvent += o.HandleStackChange;
            s.add(1.0); Console.ReadLine();
        }
    }
}
