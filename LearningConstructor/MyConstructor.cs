using System;

namespace LearningConstructor
{
  #region Default
  public class DefaultConstructor
  {
    public int i = 10;
    //public DefaultConstructor() //**No need of declaring
    //{

    //}
    ~DefaultConstructor()
    {
      i = i * 100;
    }
    //~DefaultConstructor(int x,int y) // NOT possible to overload destructor or pass parameters to it
    //{

    //}
  }
  #endregion
  #region Parameterized
  public class ParameterizedConstructor
  {
    public ParameterizedConstructor(int Id,string Name)
    {
      this.Id = Id;
      this.Name = Name;
    }
    public int Id { get; set; }
    public string Name { get; set; }
  }
  #endregion
  #region Copy
  public class CopyConstructor
  {
    public CopyConstructor(CopyConstructor copyConstructor)
    {
      if(copyConstructor != null)
      {
        this.Id = copyConstructor.Id;
        this.Name = copyConstructor.Name;
      }
    }
    public int Id { get; set; }
    public string Name { get; set; }
  }
  #endregion
  #region Static
  public class StaticConstructor
  {
    static StaticConstructor() //**This is parameterless
    {
      //this.Id //**this doesn't have 'this' reference
      Console.WriteLine("Static"); //Call first while instantiating.
    }
    public StaticConstructor()
    {
      Console.WriteLine("Default"); //Called after static constructor
    }
    public int Id { get; set; }
    public string Name { get; set; }
  }
  #endregion
  //*** Private constructor is used for Singleton Design patter (Refer singleton class)***/
  #region Private constructor
  public class PrivateConstructor
  {
    private PrivateConstructor myConstructor { get; set; }
    private PrivateConstructor()
    {
      Console.WriteLine("private constructor");
    }
    
    public void MyMethod()
    {
      myConstructor = new PrivateConstructor();
    }
  }
  #endregion
}
