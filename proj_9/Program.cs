using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace Program
{
  public class Brace
  {

    public static bool validBraces(String braces)
    {
      Stack<char> stk = new Stack<char>();
      foreach (char ch in braces)
      {
        if (ch == '(' || ch == '{' || ch == '[')
        {
          stk.Push(ch);
        }

        else if (ch == ')' || ch == '}' || ch == ']')
        {
          if (stk.Count == 0) return false;
          char top = stk.Pop();
          if ((ch == ')' && top != '(') ||
              (ch == '}' && top != '{') ||
              (ch == ']' && top != '['))
          {
            return false;
          }
        }
      }
      return stk.Count==0;
    }
  }
  class prog_9
  {
    public static void Main(string[] arg)
    {
      String s = "{([{()}])}";
      bool res = Brace.validBraces(s);
      Console.WriteLine(res);
      
    }
}  
}