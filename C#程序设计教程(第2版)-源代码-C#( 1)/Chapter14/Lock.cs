using System;using System.Threading;
namespace CSharpBook.Chapter14
{
    class Account             //账户类
    {
        private Object thisLock = new Object();
        int balance;
        public Account(int initial)//账户构造函数
        {
            balance = initial;
        }
        public void Withdraw(object amount)//从账户中取款
        {
            lock (thisLock)//注释掉下面的lock语句，测试lock关键字的效果
            {
                if (balance >= (int)amount)   //账户余额>取款额
                {
                    Thread.Sleep(500);
                    balance = balance - (int)amount;
                    Console.WriteLine("{0}操作成功。余额={1}", Thread.CurrentThread.Name, balance);
                }else{
                    Console.WriteLine("{0}操作失败。账户余额不足。余额={1}", Thread.CurrentThread.Name, balance);
                }
            }
        }
    }
    class Test
    {
        static void Main()
        {
            Account acc = new Account(1000); //新建账户对象，余额为1000
            Thread t1 = new Thread(acc.Withdraw); t1.Name = "小明";
            Thread t2 = new Thread(acc.Withdraw); t2.Name = "小红";
            t1.Start(600); t2.Start(600); Console.ReadKey();
        }
    }
}
