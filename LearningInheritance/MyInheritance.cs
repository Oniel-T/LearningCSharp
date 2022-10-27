using System;

namespace LearningInheritance
{
  public class MyInheritance
  {
  public void MyInheritanceMethod()
  {
      Parent parentChild = new Child(1, "Oniel"); //Instance of B which has properties of A to use and properties of B hidden
      Child childParent = (Child)parentChild; //properties of B can be retrieved by type casting.
      //Child parentChild = new Parent(); //This will give compilation error (Type casting)
      //Child bba = (Child)new Parent(2);  //This too won't work explicit casting. But the error will be thrown on runtime.
      Parent pc = new Child2(2,"Peter");

      parentChild.HidingMethod(); //Calls parent class
      parentChild.OverridingMethod(); //Calls child class
      pc.OverridingMethod(); // multi level also calls child class
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
}
