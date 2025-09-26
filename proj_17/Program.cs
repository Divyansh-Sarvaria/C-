using System;
using System.Collections.Generic;
namespace prog{
  public static class Kata
  {
    public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
    {
      T previous = default(T);
      bool first = true;

      foreach (T item in iterable)
      {
        if (first || !item.Equals(previous))
        {
          yield return item;
        }
        previous = item;
        first = false;
      }
    }
  }
}
