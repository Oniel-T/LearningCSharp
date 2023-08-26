using System;
using System.Collections.Generic;
using System.Linq;
using LinqExpressions;
using KeywordLearning;
using LearningConstructor;
using LearningOOPS;
using LearningReflection;
using MyCollection;
using LearningThreading;
using LearnThreading;
using LearningInheritance;
using LearningInterfaceAbstractClass;
using MyGenerics;
using CharacterProgram;

namespace LearningCSharp
{
  internal class MyApp
  {
    static void Main(string[] args)
    {
      //Loop.MyMethod();
      //MyThreading.CallThreading();
      //JoinThread.UseOfJoin();
      //Class1
      MyLINQ.callLinq();
      Console.WriteLine("-------------------------******-------------------------");
      //ref out
      int x;
      MyKeys.MyOut(out x);
      x = 10;
      MyKeys.MyReference(ref x);
      MyKeys.getEnum();
      Console.WriteLine("-------------------------******-------------------------");
      MyOOPS myOOPS = new MyOOPS();
      myOOPS.Add(4, 3);
      myOOPS.Add(43, 3333333333);
      Console.WriteLine("-------------------------******-------------------------");
      MyInterfaceAbstractClass.main();
      Console.WriteLine("-------------------------******-------------------------");
      MyInheritance myInheritance = new MyInheritance();
      myInheritance.MyInheritanceMethod();
      Console.WriteLine("-------------------------******-------------------------");

      CharacterLogic characterLogic = new CharacterLogic();
      Console.WriteLine(characterLogic.SortString("oniel"));
      Console.WriteLine("-------------------------******-------------------------");
      //myOOPS.MyFunction(0);
      IMyOOPS myOOPS1 = new MyOOPS();
      myOOPS1.MyFunction();
      MyOOPS myOOPS2 = new MyOOPS();
      myOOPS2.MyFunction();
      Console.WriteLine("-------------------------******-------------------------");
      MyReflection reflection = new MyReflection();
      reflection.MyMethod();
      ReflectionUsedCase reflectionUsedCase = new ReflectionUsedCase();
      reflectionUsedCase.MySearch();
      Console.WriteLine("-------------------------******-------------------------");
      CollectionLearning collection = new CollectionLearning();
      collection.MyCollectionMethod();
      Console.WriteLine("-------------------------******-------------------------");
      //object[] arr = new object[] { 2, 1, 3, 4 }; //Works
      //object[] arr = new object[] { "Bob", "Larry", "Andrew", "Drake" }; //Works
      MyGenerics.Employee[] arr = new MyGenerics.Employee[]
        { new MyGenerics.Employee(2,"Bob"),
        new MyGenerics.Employee(4,"Larry"),
        new MyGenerics.Employee(3,"Andrew"),
        new MyGenerics.Employee(1,"Drake")
      };
      //SortArray sortArray = new SortArray();
      SortArrayGeneric<MyGenerics.Employee> sortArray = new SortArrayGeneric<MyGenerics.Employee>();
      sortArray.BubbleSort(arr);
      foreach (var item in arr)
      {
        Console.WriteLine(item);
      }
      Console.WriteLine("-------------------------******-------------------------");
      Concurrency.SimpleConcurrency();
      Console.WriteLine("-------------------------******-------------------------");
      MyThreadingDeadlock.Main();
      Console.WriteLine("-------------------------******-------------------------");
      Console.ReadKey();
    }
  }

 
}
