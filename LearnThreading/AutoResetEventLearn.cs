using System;
using System.Threading;

namespace LearnThreading
{
  class AutoResetEventLearn
  {
    static AutoResetEvent objAuto = new AutoResetEvent(false);
  static void Main()
  {
      new Thread(SomeMethod).Start();
      Console.ReadLine();
      objAuto.Set();
  }

    static void SomeMethod()
    {
      Console.WriteLine("Starting...");
      objAuto.WaitOne();
      Console.WriteLine("Finishing...");
    }
  }


}
