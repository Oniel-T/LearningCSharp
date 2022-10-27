using AccessSpecifier;
using System;

namespace AccessSpecifier2
{
  public class MyAnotherClass : Class1
  {
    public void AnotherMethod()
    {
      MyAnotherClass class2 = new MyAnotherClass();
      class2.DoNothing(); //protected accessible
    }
  }
}
