using System;
using System.Collections.Generic;
using System.Text;

namespace LearningConstructor
{
//Sealed keyword here is used to avoid Inheritance for nested class.
  public sealed class Singleton
  {
    private static int counter = 0;
    private static Singleton instance = null;
    public static Singleton GetInstance
    {
      get
      {
        if (instance == null)
          instance = new Singleton();
        return instance;
      }
    }
    private Singleton()
    {
    //Only created once
    }
    public void PrintDetails(string message)
    {
      Console.WriteLine(message);
    }
    //public class ParentSingleton : Singleton  //To avoid this scenario sealed class is used.
    //{

    //}
  }
}
