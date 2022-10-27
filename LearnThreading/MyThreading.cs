using System;
using System.Threading;


namespace LearningThreading
{
  public static class MyThreading
  {

  }
  public static class JoinThread
  {
    public static void UseOfJoin()
    {
      Thread t1 = new Thread(Thread1);
      Thread t2 = new Thread(Thread2);
      t1.Start();
      t1.Join();
      t2.Start();
    }
    private static void Thread1()
    {
      Console.WriteLine("Thread1 started.");
      Thread.Sleep(4000);
      Console.WriteLine("Thread1 completed.");
    }
    private static void Thread2()
    {
      Console.WriteLine("Thread2 started.");
    }
  }
  /// <summary>
  /// Concurrency threading
  /// </summary>
  public static class Concurrency
  {
    public static void SimpleConcurrency(){
      Thread o1 = new Thread(RunMillionIterations);
      o1.Start();
      Console.Read();
    }
    internal static void RunMillionIterations()
    {
      string x = "";
      for (int iIndex = 0; iIndex < 1000000; iIndex++) {
        x = x + "s";
      }
    }
  }
  
}
