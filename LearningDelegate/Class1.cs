using System;
using System.Collections;

namespace LearningDelegate
{
  class rectangle
  {
    public delegate void rectDelegate(double height,
                                      double width);
    public void area(double height, double width)
    {
      Console.WriteLine("Area is: {0}", (width + height));
    }
    public void perimeter(double height, double width)
    {
      Console.WriteLine("Perimeter is: {0} ", 2 * (width + height));
    }
    delegate void del(int p, double k);
    public static void main()
    {
      rectangle rect = new rectangle();

      rectDelegate rectdele = new rectDelegate(rect.area);

      rectdele += new rectDelegate(rect.perimeter);

      rectdele.Invoke(6.3, 4.2);
      Console.WriteLine();
      rectdele.Invoke(16.3, 14.2);
      ArrayList x = new System.Collections.ArrayList();

    }


    public delegate double areaDelegate(double radius);
    public delegate double areaDelegate1(double radius);
    public void LearningPassDelegateAsParameter(){
      areaDelegate1 areaDelegate = new areaDelegate1((r) => { return 2 * 3.14 * r; });
      PassingDelegateAsParameter(areaDelegate);
    }

    public void PassingDelegateAsParameter(areaDelegate1 areaDelegate1rect)
    {
      areaDelegate1rect.Invoke(5);
    }

    public void LambdaExpressionFunctions(){
      Predicate<int> isGreaterThanTen = (x) => { return (x > 10); };
      bool Greater = isGreaterThanTen(100);

      Action<int, string> PerformMultiplicationAndLogIt = (x, display) => { Console.WriteLine(display + ": " + x); };
      PerformMultiplicationAndLogIt(100, "Displaying this");

    }
  }
}
