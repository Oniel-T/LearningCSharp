using System;

namespace LearningParams
{
  public class Params
  {
   public void MyFunction()
   {
      MyFunction1("Oniel", "Peter", "Telies");
   }
    public void MyFunction1(params string[] x) //params should be last element
    {

    }
  }
}
