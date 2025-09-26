using System;
namespace prog
{
  public static class TimeFormat
  {
    public static string GetReadableTime(int seconds)
    {
      int hr=0, min = 0 , second;
      if (seconds > 359999)
      {
        return " out of bounds ";
      }
      else
      {
         hr = seconds / 3600;
         min = (seconds % 3600) / 60;
        second = seconds % 60;
      }
      return $"{hr}:{min}:{second}";
    }
  }
  class prog
  {
    public static void Main(String[] arg)
    {
      int x = 8900;
      string k = TimeFormat.GetReadableTime(x);
      Console.WriteLine(k);

    }
  }
}