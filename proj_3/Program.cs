using System;
using System.Diagnostics.CodeAnalysis;
namespace proj_3
{
  public static class Kata
  {
    public static bool XO(string input)
    {
      int x = 0, o = 0, sz = input.Length;
      for (int i = 0; i < sz; i++)
      {
        if (input[i] == 'x' || input[i] == 'X')
        {
          x++;
        }
        else if (input[i] == 'o' || input[i] == 'O')
        {
          o++;
        }
      }
      if (x == o)
        return true;
      return false;
    }
  };
  class program
  {
    static void Main(string[] arg)
    {
      bool res = Kata.XO("xoxo");
      Console.WriteLine($"{res}");
    }
   }
}