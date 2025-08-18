using System.Collections.Generic;
using System;

namespace Program
{
  public class Kata
  {
    public static Dictionary<char, int> Count(string str)
    {
      int cnt=1;
      Dictionary<char, int> dict = new Dictionary<char, int>();
      foreach (char n in str)
      {
        if (dict.ContainsKey(n))
        {
          dict[n] = dict[n] + 1;
        }
        else if (!dict.ContainsKey(n))
        {
          dict.Add(n, cnt);
        }

      }
      return dict;
    }
  }
  class prog_10
  {
    public static void Main(string[] arg) {
    var result = Kata.Count("hello");
    Console.WriteLine("Character counts:");
    foreach (var kv in result)
    {
        Console.WriteLine($"{kv.Key} : {kv.Value}");
    }
  }
  }
}