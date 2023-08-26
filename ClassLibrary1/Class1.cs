using AccessSpecifier;
using System;

namespace AccessSpecifier
{
  public class Class1
  {
    protected int ID;
    //private: Accessible only  within the class
    //internal: Accessible only within the namespace
    //public: Accessible every where
    //protected: Acessiob
    //protected internal: Accessible only from the same assembly/namespace or any derived class
    protected internal void DoNothing()
    {

    }
  }
  public class Class2 : Class1
  {
    public void Caller()
    {
      Class2 class2 = new Class2();
      class2.DoNothing(); //protected accessible
      Class1 class1 = new Class1();
      class1.DoNothing(); //protected not accessible. Need to use protected internal
    }
  }

  public class MyAnotherClass
  {
    public void AnotherMethod()
    {
      Class2 class2 = new Class2();
      class2.DoNothing(); //protected not accessible.  Need to use protected internal
    }
  }
}
namespace AccessSpecifier3
{
  public class InDifferentNamespace
  {
    public void AnotherMethod()
    {
      Class2 class2 = new Class2();
      class2.DoNothing(); //protected not accessible.  Need to use protected internal
    }
  }
}