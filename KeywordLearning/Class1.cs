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

  }
}
