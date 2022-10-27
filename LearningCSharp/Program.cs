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
      //myOOPS.MyFunction(0);
      IMyOOPS myOOPS1 = new MyOOPS();
      myOOPS1.MyFunction();
      Console.WriteLine("-------------------------******-------------------------");
      MyClass reflection = new MyClass();
      reflection.MyMethod();
      ReflectionUsedCase reflectionUsedCase = new ReflectionUsedCase();
      reflectionUsedCase.MySearch();
      Console.WriteLine("-------------------------******-------------------------");
      CollectionLearning collection = new CollectionLearning();
      collection.MyCollectionMethod();
      Console.WriteLine("-------------------------******-------------------------");
      Concurrency.SimpleConcurrency();
      Console.WriteLine("-------------------------******-------------------------");
      MyThreadingDeadlock.Main();
      Console.ReadKey();
    }
  }

 
}
