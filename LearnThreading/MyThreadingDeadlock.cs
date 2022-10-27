using System;
using System.Threading;

namespace LearnThreading
{
  public static class MyThreadingDeadlock
  {
    public static void Main()
    {
      Console.WriteLine("Main Started");
      Account accountA = new Account(101, 5000);
      Account accountB = new Account(102, 3000);

      AccountManager accountManagerA = new AccountManager(accountA, accountB, 1000);
      Thread T1 = new Thread(accountManagerA.Transfer);
      T1.Name = "T1";

      AccountManager accountManagerB = new AccountManager(accountB, accountA, 2000);
      Thread T2 = new Thread(accountManagerB.Transfer);
      T2.Name = "T2";

      T1.Start();
      T2.Start();

      T1.Join();
      T2.Join();
    }
  
  }

  class AccountManager
  {
    Account _fromAccount; Account _toAccount; double _amountToTransfer;
    public AccountManager(Account fromAccount, Account toAccount, double amountToTransfer)
    {
      this._fromAccount = fromAccount;
      this._toAccount = toAccount;
      this._amountToTransfer = amountToTransfer;
    }
    public void Transfer()
    {
      Console.WriteLine(Thread.CurrentThread.Name + " trying to acquire lock on " + _fromAccount.ID.ToString());
      lock (_fromAccount) {
        Console.WriteLine(Thread.CurrentThread.Name + " acquired lock on " + _fromAccount.ID.ToString());
        Console.WriteLine(Thread.CurrentThread.Name + " suspended for 1 second " + _fromAccount.ID.ToString());
        Thread.Sleep(1000);
        lock (_toAccount) {
          Console.WriteLine("This code will not be executed");
          _fromAccount.Withdraw(_amountToTransfer);
          _toAccount.Deposit(_amountToTransfer);
        }
      }
    }
  }
  class Account
  {
    double _balance;int _id;
    public Account(int id, double balance)
    {
      this._id = id;
      this._balance = balance;
    }
    public int ID
    {
      get { return _id; }
    }
    public void Withdraw(double amount)
    {
      _balance -= amount;
    }
    public void Deposit(double amount)
    {
      _balance += amount;
    }
  }
}
