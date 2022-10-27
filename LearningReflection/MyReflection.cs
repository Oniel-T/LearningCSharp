using System;
using System.Reflection;


namespace LearningReflection
{
  public class MyClass
  {
    public void MyMethod()
    {
      //Type T = Type.GetType("LearningReflection.Customer");
      //Type T = typeof(Customer);
      Customer C1 = new Customer();

      //Predefined methods in every class while we create object.
      Type T = C1.GetType();
      int HashCode = C1.GetHashCode();
      string C1Name = C1.ToString();

      Console.WriteLine("Full name: {0}", T.FullName);
      Console.WriteLine("Just the name: {0}", T.Name);
      Console.WriteLine("Just the namespace: {0}", T.Namespace);
      Console.WriteLine();
      Console.WriteLine("Properties in customers");
      PropertyInfo[] properties = T.GetProperties();
      foreach (var item in properties) {
        Console.WriteLine(item.Name + " " + item.PropertyType.Name);
      }
      Console.WriteLine();
      Console.WriteLine("Get method");
      MethodInfo[] methods = T.GetMethods();
      foreach (var item in methods) {
        Console.WriteLine(item.Name + " " + item.ReturnType.Name);
      }

      Console.WriteLine();
      Console.WriteLine("Get constructor");
      ConstructorInfo[] constructors = T.GetConstructors();
      foreach (var item in constructors) {
        Console.WriteLine(item.ToString());
      }


    }
    
  }

  class Customer
  {
    public Customer(int ID, string Name)
    {
      this.Id = ID;
      this.Name = Name;
    }
    public Customer()
    {
      this.Id = -1;
      this.Name = string.Empty;
    }
    public int Id { get; set; }
    public string Name { get; set; }
    public int GetId(){
      return this.Id;
    }
    public string GetName(){
      return this.Name;
    }
  }
}
