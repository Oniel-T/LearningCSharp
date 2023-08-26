using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MyCollection
{
  public class CollectionLearning
  {
    public void MyCollectionMethod()
    {
      //Non generic list
      //System.Collections.Stack
      ArrayList arraylist = new ArrayList(); //can add object
      BitArray bitArray = new BitArray(new bool[] { true, false, false, false }); // boolean array
      Hashtable hashtable = new Hashtable(); //key value pair of object // keys taken randomly
      Queue queue1 = new Queue(); //Enqueue Dequeue object
      SortedList sortedList = new SortedList(); //key value pair of object // keys taken in sorted fashion
      Stack stack1 = new Stack(); //Push,Pop object

      //Generic
      List<int> list = new List<int>();
      HashSet<int> hashset = new HashSet<int>();
      
      Dictionary<int, string> dict = new Dictionary<int, string>();
      Stack<int> stack = new Stack<int>();
      Queue<int> queue = new Queue<int>();
      LinkedList<int> linkedList = new LinkedList<int>();
      List<LinkedListNode<int>> linkedListNode = new List<LinkedListNode<int>>(10);

      linkedList.AddFirst(new LinkedListNode<int>(1));
      linkedList.AddAfter(linkedList.Last, new LinkedListNode<int>(2));
      linkedList.AddAfter(linkedList.Last, new LinkedListNode<int>(3));
      linkedList.AddLast(new LinkedListNode<int>(4));

      linkedListNode.Add(new LinkedListNode<int>(1) { });
      linkedListNode.Add(new LinkedListNode<int>(2));
      linkedListNode.Add(new LinkedListNode<int>(3));
      linkedListNode.Add(new LinkedListNode<int>(4));

      //Collection
      List<Customer> customers = new List<Customer>();
      customers.Add(new Customer(1, "Oniel"));
      customers.Add(new Customer(2, "Oniel"));
      Customer ct = (Customer)customers.GetCustomer(1);
      //Customer ct1 = customers.Single(); //This won't work as it needs one and only one item

      //LinkedList<string> LinkedList = new LinkedList<string>();
      //LinkedList.

      //TrimExcess
      //List<string> coll = new List<string>(100);
      //coll.Add("Hello");
      //coll.Add("There");
      //Console.WriteLine(coll.Capacity);
      //coll.TrimExcess();
      //Console.WriteLine(coll.Capacity);
    }
  }
  public static class CustomerUtilities
  {
    public static object GetCustomer(this List<Customer> customers, int id)
    {
      return customers.FirstOrDefault(x => x.Id == id);
    }
  }
  public class Customer
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
    public int GetId()
    {
      return this.Id;
    }
    public string GetName()
    {
      return this.Name;
    }
  }


}
