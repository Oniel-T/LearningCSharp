using System;

namespace KeywordLearning
{
  public static class MyKeys
  {
    
    public static void MyReference(ref int x)
    {
      x = 0; // has to be initialized before entering.
    }
    public static void MyOut(out int x)
    {
      x = 0; // has to be assigned before leaves
    }
    #region ENUM
    //ENUM is STRONGLY typed constant
    public enum MyEnum
    {
      Red,
      Yellow,
      Green,
      Purple
    }
    public static void getEnum()
    {
      Console.WriteLine(MyEnum.Red);
      Console.WriteLine((int)MyEnum.Red); // 0
    }
    #endregion
  }
  public struct MyStruct
  {
    public int x;
    public MyStruct(int x)
    {
      this.x = x; 
    }
  }
  public class MyClass
  {
    public int x;
    public MyClass(int x)
    {
      //this.x = x;
    }
  }
}
