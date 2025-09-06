using System;
 
namespace program
{
  public static class Kata
  {
    public static bool IsPrime(int n)
    {
      int lim =(int)Math.Sqrt(n);
      if (n == 1 || n == -1 || n ==0 || n%2 == 0 &&n!=2)
      {
        return false;
      }
      if (n == 2)
      {
        return true;
      }
      else
      {
        for (int i = 3; i <= lim; i += 2)
        {
          if (n % i == 0)
          {
            return false;
          }
        }
      }
      return true;
    }
  }
  class prog {
    public static void Main(String[] arg)
    {
      bool x = Kata.IsPrime(2);
      Console.WriteLine(x);
    }
}
  
}