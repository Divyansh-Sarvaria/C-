using System;
namespace Program
{
  public static class Kata
  {
    public static string AddBinary(int a, int b)
    {
      int sum;
      sum = a + b;
      String ans = Convert.ToString(sum, 2);
      return ($"{a},{b} --> {ans} , (the sum of {a} and {b} is {sum} or {ans} in binary !)");
    }
  }
  class proj_6
  {
    public static void Main(string[] arg)
    {
      int a = 1, b = 2;
      string res = Kata.AddBinary(a, b);
      Console.WriteLine(res);
    }
  }
}