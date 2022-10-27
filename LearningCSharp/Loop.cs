using System;
using System.Collections.Generic;

namespace LearningCSharp
{
  public static class Loop
  {
    public static void MyMethod()
    {
      List<int> x = new List<int>();
      x.Add(256741038);
      x.Add(623958417);
      x.Add(467905213);
      x.Add(714532089);
      x.Add(938071625);
      miniMaxSum(x);
    }
    public static void miniMaxSum(List<int> arr)
    {
      long maxEnd = 0, minEnd = 0;
      //sort
      for (int i = 0; i < arr.Count; i++)
      {
        if (i < arr.Count - 1)
        {
          for (int j = i + 1; j < arr.Count; j++)
          {
            if (arr[i] > arr[j])
            {
              int temp = arr[i];
              arr[i] = arr[j];
              arr[j] = temp;
            }
          }
        }
      }
      Console.WriteLine();
      foreach (int a in arr)
      {
        Console.WriteLine(a + " ");
      }
      for (int i = 0; i < arr.Count; i++)
      {
        if (i == 0)
        {
          minEnd += arr[i];
          continue;
        }
        else if (i == arr.Count - 1)
        {
          maxEnd += arr[i];
          continue;
        }
        minEnd += arr[i];
        maxEnd += arr[i];
      }
      Console.WriteLine(minEnd + " " + maxEnd);
    }
  }

}
