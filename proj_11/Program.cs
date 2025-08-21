using System;
namespace program
{
class AreTheySame
{
    public static bool comp(int[] a, int[] b)
    {
        if (a == null || b == null) return false;

        if (a.Length != b.Length) return false;

        
        Array.Sort(a);
        Array.Sort(b);

        for (int i = 0; i < a.Length; i++)
        {
            if (b[i] != a[i] * a[i])
            {
                return false;
            }
        }

        return true;
    }
}
  class prog_10
  {
    public static void Main(string[] arg)
    {
      int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
      int[] b = new int[] { 11 * 12, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };
      bool res = AreTheySame.comp(a, b);
      Console.WriteLine(res);
    }  
 }
}