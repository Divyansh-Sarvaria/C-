using System.Collections.Generic;
using System.Linq;

namespace Program
{
  public class Kata
  {
    public static int GetUnique(IEnumerable<int> numbers)
    {


      return numbers.GroupBy(x => x).Where(g => g.Count() == 1).Select(g => g.Key).FirstOrDefault();
    }
  }
  class proj_8
  {
    public static void Main(string[] arg)
    {
      int[] num = new int[] { 1, 1, 1, 4, 1, 1, 1 };
      int res = Kata.GetUnique(num);
      Console.WriteLine(res);
    }
  }

}