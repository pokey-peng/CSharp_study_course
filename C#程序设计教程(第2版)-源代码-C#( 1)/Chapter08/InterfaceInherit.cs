using System;
namespace CSharpBook.Chapter08
{  
   public interface IBankAccount    //银行账户
   { 
     void PayIn(decimal amount);    //存款
     bool Withdraw(decimal amount); //取款，并返回是否成功
     decimal Balance { get; }        //余额
   }
   public interface ITransferBankAccount : IBankAccount //转账银行账户
  {  bool TransferTo(IBankAccount destination, decimal amount);  }
   public class CurrentAccount : ITransferBankAccount   //当前账户
  {  
     private decimal balance;              //余额
      public void PayIn(decimal amount) { balance += amount; }//存款
     public bool Withdraw(decimal amount)  //取款
      {  // 账户有足够余额，则取款，并返回是否成功
         if (balance >= amount) { balance -= amount;  return true; }
         Console.WriteLine("余额不足，取款失败！");  return false;
      }
      public decimal Balance { get { return balance; }}  //返回余额
      public bool TransferTo(IBankAccount destination, decimal amount)//银行转账
      {
         bool result; 
         if ((result = Withdraw(amount)) == true) destination.PayIn(amount);
         return result;
      }
      public override string ToString()  //返回银行当前账户中的余额
      {  
         return String.Format("Current Bank Account: Balance= {0,6:C}", balance);
      }
  }
  class TestClass
  {  
     static void Main()
     {  IBankAccount account1 = new CurrentAccount();       //账户1
        ITransferBankAccount account2 = new CurrentAccount(); //账户2
        account1.PayIn(200);              //账户1存款200元
        account2.PayIn(500);              //账户2存款500元
        account2.TransferTo(account1, 100); //账户2转账100元到账户1
        Console.WriteLine("account1's "+account1.ToString()); //显示账户1余额
        Console.WriteLine("account2's "+account2.ToString()); //显示账户2余额
        Console.ReadKey();
    }
  }
}
