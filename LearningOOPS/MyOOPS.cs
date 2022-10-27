using System;

namespace LearningOOPS
{
  public class MyOOPS: IMyOOPS
  {
    public double Add(int x, int y)
    {
      return x + y;
    }
    public double Add(double x, double y)
    {
      return x + y;
    }
    //public double Add(double x, double y=0)  //Cannot do optional
    //{
    //  return x + y;
    //}
    public double Add(double x, double y,string z = "")
    {
      return x + y;
    }
    public void MyFunction(int x)
    {
      Console.WriteLine(x);
    }
  }
  public interface IMyOOPS
  {
    void MyFunction(int x = 100);
  }
}
