using System;
namespace CSharpBook.Chapter07
{
    partial class Customer
    {
        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        partial void OnNameChanging(string newName);  //声明分部方法定义
        partial void OnNameChanged();                //声明分部方法定义
    }
    partial class Customer
    {
        partial void OnNameChanging(string newName)  //声明分部方法实现
        {
            Console.WriteLine("Changing " + name + " to " + newName);
        }
        partial void OnNameChanged()               //声明分部方法实现
        {
            Console.WriteLine("Changed to " + name);
        }
    }
}
