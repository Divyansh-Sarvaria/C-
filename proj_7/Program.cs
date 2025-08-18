using System;
using System.Reflection.Metadata;
namespace Program
{
  public class Kata
  {
    public static int Find(int[] integers)
    {
      if (integers.Length < 3)
      {
        return -1;
      }
      int odd = 0, evn = 0, j = 0;
      while (j < 3)
      {
        if (integers[j] % 2 == 0)
        {
          evn++;
        }
        else { odd++; }
        j++;
      }
      bool major = evn > odd;
      foreach (int num in integers)
      {
        if (major && num % 2 != 0) return num;
        if (!major && num % 2 == 0) return num;
      }

      return -1;
    }
  }
  class proj_7
  {
    public static void Main(string[] arg)
    {
      int[] num = new int[] { 3, 3, 5,4, 7 };
      int res = Kata.Find(num);
      Console.WriteLine(res);
    }
  }
}