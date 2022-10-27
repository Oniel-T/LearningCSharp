using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExpressions
{
  public static class MyLINQ
  {
    public static void callLinq()
    {
      List<Department> departments = new List<Department>() {
        { new Department(1, "ID") },
        { new Department(2, "Support") },
        { new Department(3, "Admin") }
    };
      List<Employee> employees = new List<Employee>() {
        { new Employee(1, "Oniel", 1) },
        { new Employee(2, "Peter", 2) },
        { new Employee(2, "Annie", 0) }
    };
      Console.WriteLine("**************Inner join**************");
      var EmpInnDep = from emp in employees
                      join dep in departments on emp.DepID equals dep.ID
                      select new { EmpID = emp.ID,EmpName = emp.Name, DepName = dep.Name } ;

      Console.WriteLine("Dep Name\tEmp ID\tEmp Name");
      foreach (var item in EmpInnDep)
      {
        Console.WriteLine(item.DepName + "\t" + item.EmpID + "\t" + item.EmpName);
      }
      Console.WriteLine("**************Left join**************");
      var EmpLeftDep = from emp in employees
                       join dep in departments on emp.DepID equals dep.ID into temp
                       from d in temp.DefaultIfEmpty()
                       select new { EmpID = emp.ID, EmpName = emp.Name, DepName = (d != null) ? d.Name : "", DepID = (d != null) ? (int?)d.ID : null };

      //var result = (from p in Products
      //              join o in Orders on p.ProductId equals o.ProductId into temp
      //              from t in temp.DefaultIfEmpty()
      //              select new
      //              {
      //                p.ProductId,
      //                OrderId = (int?)t.OrderId,
      //                t.OrderNumber,
      //                p.ProductName,
      //                Quantity = (int?)t.Quantity,
      //                t.TotalAmount,
      //                t.OrderDate
      //              }).ToList();

      Console.WriteLine("Dep Name\tEmp ID\tEmp Name");
      foreach (var item in EmpLeftDep)
      {
        Console.WriteLine(item.DepName + "\t" + item.EmpID + "\t" + item.EmpName);
      }
    }
  }
  public class Employee
  {
    public Employee(int ID, string Name, int DepID)
    {
      this.ID = ID;
      this.Name = Name;
      this.DepID = DepID;
    }
    public int ID { get; set; }
    public string Name { get; set; }
    public int DepID { get; set; }
  }
  public class Department
  {
    public Department(int ID, string Name)
    {
      this.ID = ID;
      this.Name = Name;
    }
    public int ID { get; set; }
    public string Name { get; set; }
  }
}
