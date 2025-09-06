using System;
using System.Linq;
namespace prog
{
  public class Kata
  {
    public static int[] SortArray(int[] array)
    {
      int[] odd = array.Where(x => x % 2 != 0).OrderBy(x => x).ToArray();
      int odind = 0;
      for (int i = 0; i < array.Length; i++)
      {
        if (array[i] % 2 != 0)
        {
          array[i] = odd[odind];
          odind++;
        }
      }
      return array;
    }
  }
  class prog15
  {
    public static void Main(String[] arg)
    {
      Kata k = new Kata();
      int[] arr = {5, 3, 2, 8, 1, 4 };
      int[] res = Kata.SortArray(arr);
      foreach (int i in res) {
        Console.Write(i + " "); 
      }
    }
  }
}