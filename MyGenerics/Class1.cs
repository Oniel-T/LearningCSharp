using System;

namespace MyGenerics
{
  public class Class1
  {
    public void GenericClass() {
      Compare<int,int, string> comp = new Compare<int,int, string>();
      Compare<string, string, string> comp2 = new Compare<string, string, string>();
      comp.Check(10,20);
      comp2.Check("", "");
      Compare2 comp3 = new Compare2();
      comp3.Check(10, 20);
    }
  }
 //Generic class
  internal class Compare<Item1,Item2,Item3>
  {
    public bool Check(Item1 num1, Item2 num2)
    {
      if (num1 is int && num2 is int)
      {
        if ((num1 as int?) > (num2 as int?))
          return true;
        else
          return false;
      }
      else if (num1.Equals(num2))
      {
        return true;
      }
      return false;
    }
  }
  //Generic method
  internal class Compare2
  {
    public bool Check<Item1,Item2>(Item1 num1, Item2 num2)
    {
      if (num1 is int && num2 is int)
      {
        if ((num1 as int?) > (num2 as int?))
          return true;
        else
          return false;
      }
      else if (num1.Equals(num2))
      {
        return true;
      }
      return false;
    }
  }
  //Constraints

}
