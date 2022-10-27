using System;
using System.Threading;
using System.Threading.Tasks;

namespace LearnThreading
{
  class MyTask
  {
    public static void SimpleTask()
    {
      Task task = new Task(()=> { });
    }
    public static void CallThreading()
    {
      CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
      CancellationToken token = cancellationTokenSource.Token;
      Task t1 = Task.Factory.StartNew(() =>
      {
        while (!token.IsCancellationRequested) {
          Console.Write("* ");
          Thread.Sleep(1000);
        }
        if (token.IsCancellationRequested) {
          //token.ThrowIfCancellationRequested();
          Console.WriteLine("Cancel requested.");
        }
      }, token);
      Console.WriteLine("Stop process:");
      Console.ReadKey();
      cancellationTokenSource.Cancel();
      t1.Wait();
    }
  }
  public static class Parellism
  {
    public static void SimpleParellism()
    {
      Parallel.For(0, 1000000, x => RunMillionIterations());
    }

    internal static void RunMillionIterations()
    {
      string x = "";
      for (int iIndex = 0; iIndex < 1000000; iIndex++) {
        x = x + "s";
      }
    }
  }
  public static class ConcurrencyScenario
  {
    private static int Total = 0;

    public static void MyConcurrencyIssue()
    {
      Thread T1 = new Thread(AddOneMillion);
      Thread T2 = new Thread(AddOneMillion);
      Thread T3 = new Thread(AddOneMillion);

      T1.Start();
      T2.Start();
      T3.Start();
      T1.Join();
      T2.Join();
      T3.Join();

      Console.WriteLine("Total = " + Total); //Here every time the output will be different as the property is global
    }

    public static void AddOneMillion()
    {
      for (int i = 0; i < 1000000; i++) {
        Total++;
      }
    }

    public static void MyConcurrencyFix()
    {
      Thread T1 = new Thread(AddOneMillionByInterlocking);
      Thread T2 = new Thread(AddOneMillionByInterlocking);
      Thread T3 = new Thread(AddOneMillionByInterlocking);

      T1.Start();
      T2.Start();
      T3.Start();
      T1.Join();
      T2.Join();
      T3.Join();

      Console.WriteLine("Total = " + Total); //Here every time the output will be different as the property is global
    }

    public static void AddOneMillionByInterlocking()
    {
      for (int i = 0; i < 1000000; i++) {
        Interlocked.Increment(ref Total);
      }
    }

    public static void MyConcurrencyFix2()
    {
      Thread T1 = new Thread(AddOneMillionByInterlocking2);
      Thread T2 = new Thread(AddOneMillionByInterlocking2);
      Thread T3 = new Thread(AddOneMillionByInterlocking2);

      T1.Start();
      T2.Start();
      T3.Start();
      T1.Join();
      T2.Join();
      T3.Join();

      Console.WriteLine("Total = " + Total); //Here every time the output will be different as the property is global
    }
    static object _lock = new object();
    public static void AddOneMillionByInterlocking2()
    {
      for (int i = 0; i < 1000000; i++) {
        lock (_lock) {
          Total++;
        }
      }
    }

    public static void MyConcurrencyFix3()
    {
      Thread T1 = new Thread(AddOneMillionByInterlocking3);
      Thread T2 = new Thread(AddOneMillionByInterlocking3);
      Thread T3 = new Thread(AddOneMillionByInterlocking3);

      T1.Start();
      T2.Start();
      T3.Start();
      T1.Join();
      T2.Join();
      T3.Join();

      Console.WriteLine("Total = " + Total);
    }
    public static void AddOneMillionByInterlocking3()
    {
      for (int i = 0; i < 1000000; i++) {
        bool lockTaken = false;
        Monitor.Enter(_lock, ref lockTaken);
        try {
          Total++;
        } finally {
          if (lockTaken)
            Monitor.Exit(_lock);
        }
      }
    }
  }
}
