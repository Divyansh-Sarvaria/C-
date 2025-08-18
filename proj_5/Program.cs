using System;
namespace proj_4
{
public class Kata
  {
    public static bool IsIsogram(string str)
    {
      char[] a = new char[1] ;
      String st = str.ToLower();
      int sz = st.Length;
      for (int i = 0; i < sz; i++)
      {
        a[0] = st[i];
        for (int j = i+1; j < sz; j++)
        {
          if (a[0] == st[j])
          {
            return false;
          }
        }                
      }
      return true;
    }
}
  static class proj
  {
    public static void Main(String[] arg)
    {
      string x = "divyanshd";
      bool res = Kata.IsIsogram(x);
      Console.WriteLine(res);
    }
 }
}
