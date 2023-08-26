using System;
using System.Collections.Generic;

namespace LearningInheritance
{
  public class MyInheritance
  {
  public void MyInheritanceMethod()
  {
      Parent parentChild = new Child(1, "Oniel"); //Instance of B which has properties of A to use and properties of B hidden
      //parentChild.Name; !ERROR!

      Child childParent = (Child)parentChild; //properties of B can be retrieved by type casting.
      Console.WriteLine(childParent.Name);
      //Child parentChild = new Parent(); //This will give compilation error (Type casting)
      //Child bba = (Child)new Parent(2);  //This too won't work explicit casting. But the error will be thrown on runtime.
      Parent pc = new Child2(2,"Peter");

      parentChild.HidingMethod(); //Calls parent class
      parentChild.OverridingMethod(); //Calls child class
      pc.OverridingMethod(); // multi level also calls child class

      List<Parent> runtimePolymorphism = new List<Parent>();
      runtimePolymorphism.Add(parentChild);
      runtimePolymorphism.Add(pc);
      foreach (var runtime in runtimePolymorphism)
      {
        runtime.OverridingMethod(); //here method can be virtual method or if overriden, that method.
      }
    }
  }
  class Parent
  {
    public int Id { get; set; }
    public Parent(int ID)
    {
      this.Id = ID;
    }
    public void MyMethodA()
    {

    }

    public void HidingMethod()
    {

    }
    public virtual void OverridingMethod()
    {

    }
  }
  class Child : Parent
  {
    public Child(int ID, string Name) : base(ID)
    {
      this.Name = Name;
    }
    public string Name { get; set; }
    public void MyMethodB()
    {

    }

    public new void HidingMethod()
    {

    }
    public override void OverridingMethod()
    {

    }
  }

  class Child2 : Child
  {
    public Child2(int ID, string Name) : base(ID,Name)
    {
      this.Name = Name;
    }
    public string SkinTone { get; set; }
    public void MyMethodC()
    {

    }

    public override void OverridingMethod()
    {

    }
  }


  sealed class SealedClass
  {
    public int Id { get; set; }
  }
  //sealed class OveridingSealed : SealedClass //Not Possible
  //{
  //  public int Id { get; set; }
  //}

  #region SEALED METHOD
  class Child3 : Parent
  {
    public Child3(int ID) : base(ID)
    {
    }

  public sealed override void OverridingMethod() //we can block further overriding by sealed on method
    {

    }
  }

  class Child4 : Child3
  {
    public Child4(int ID) : base(ID)
    {
    }

    //public override void OverridingMethod() //ERROR DUE TO SEALED METHOD
    //{

    //}
  }
  #endregion

}
