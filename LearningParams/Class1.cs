using System;

namespace LearningParams
{
  public class Params
  {
   public void MyFunction()
   {
      MyFunction1("Oniel", "Peter", "Telies");
      MyFunction1(new MyTempClass(), new MyTempClass(), new MyTempClass());
   }
    public void MyFunction1(params string[] x) //params should be last element
    {

    }
    internal void MyFunction1(params MyTempClass[] x) //params should be last element
    {

    }
  }
  internal class MyTempClass
  {
    public int Id { get; set; }
  }
}
