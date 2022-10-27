
using System;

namespace LearningInterfaceAbstractClass
{
  public static class MyInterfaceAbstractClass
  {
    public static void main()
    {
      IMyMain myMain = new MyMain(); //Calls constructor of Abstract class and then of Concrete class (**all MyMethod from 1 to 3 accessible)
      MyMainAbstract myMainAbstract = new MyMain(); //Calls constructor of Abstract class and then of Concrete class (**MyMethod 1 and 2 accessible)
    }
  }
  public class MyMain : MyMainAbstract,IMyMain
  {
    public MyMain()
    {
      Console.WriteLine("Constructor of Concrete");
    }
    public void MyMethod1()
    {
      Console.WriteLine("MyMethod1");
    }

    public void MyMethod2()
    {
      Console.WriteLine("MyMethod2");
    }
  }
  public interface IMyMain
  {
    public void MyMethod1();
    public void MyMethod2();
    public void MyMethod3();
  }
  public abstract class MyMainAbstract
  {
    public MyMainAbstract()
    {
      Console.WriteLine("Constructor of Abstract");
    }
    public void MyMethod3()
    {
      Console.WriteLine("MyMethod3");
    }
  }
}
