using System;
class proj4 {
  static void Main(string[] arg)
  {
    Console.WriteLine("enter a string : ");
    string imp = Console.ReadLine();
    if (stringtext(imp))
    {
      Console.WriteLine("true");
    }
    else
    {
      Console.WriteLine("false");
    }
  }
  static bool stringtext(String str)
  {
    int left = 0 ;
    int right = str.Length-1;
    while (left < right)
    {
      if (str[left] != str[right])
      {
        return false;
      }
      left++;
      right--;
    }
    return true;
  }
}





