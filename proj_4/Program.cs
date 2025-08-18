using System;

namespace proj_4
{
  public class Kata
  {
    public static long FindNextSquare(long num)
    {
      long chk =(long) Math.Sqrt(num);
      if (chk*chk == num)
      {
        chk ++;
        
        return chk;
      }
      return -1;
    }
  }
  static class prog
  {
    public static void Main(string[] arg)
    {
      long res = Kata.FindNextSquare(155);
      Console.WriteLine($"{res}");
    }
 }
}