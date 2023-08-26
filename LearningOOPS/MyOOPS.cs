using System;

namespace LearningOOPS
{
  public class MyOOPS: IMyOOPS
  {
    public double Add(int x, int y)
    {
      return x + y;
    }
    //public int Add(int x, int y) //Cannot be added .Compile time error
    //{
    //  return x + y;
    //}
    public double Add(double x, double y)
    {
      return x + y;
    }
    //public double Add(double x, double y=0)  //Cannot be added .Compile time error
    //{
    //  return x + y;
    //}
    public double Add(double x, double y,string z = "") //Only if 3rd parameter is supplied, this function will be called otherwise above is called.
    {
      return x + y;
    }
    public void MyFunction(int x = 200) //If MyOOPS x = new MyOOPS();//then 200;
    {
      Console.WriteLine(x);
    }
  }
  public interface IMyOOPS //If IMyOOPS x = new MyOOPS();//then 100;
  {
    void MyFunction(int x = 100);
  }

  //Extension Method
  public static class myClass
  {
    public static string ReturnString(this string str)
    {
      return str.ToString();
    }
  }
}
