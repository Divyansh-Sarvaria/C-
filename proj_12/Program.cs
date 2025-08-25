using System;
using System.Dynamic;
namespace Program
{
  class PrepList {
    protected List<string> PrpLst(string name, string bookNme)
    {
      List<string> list = new List<string>();
      list.Add(name);
      list.Add(bookNme);
      return list;
    }
  }
  class Book : PrepList
  {
    Dictionary<int, List<string>> dir = new Dictionary<int, List<string>>();
    private static int accnum { get; set; }

    public Book(string name, string bknm)
    {
      List<string> lst = PrpLst(name, bknm);
      accnum++;
      dir.Add(accnum, lst);
      Console.WriteLine(accnum);
    }

    public void addbook(int accno, string bknm)
    {
      if (dir.ContainsKey(accno))
      {
        dir[accno].Add(bknm);
      }
      else
      {
        Console.WriteLine(" NO acc dected ");

      }
    }
    public void disp(int accno)
    {
        if (dir.ContainsKey(accno))
        {
            Console.WriteLine($"\nAccount Number: {accno}");
            Console.WriteLine($"Customer Name: {dir[accno][0]}");
            Console.WriteLine("Books Issued:");
            
            // Start from index 1 (skip customer name at index 0)
            for (int i = 1; i < dir[accno].Count; i++)
            {
                Console.WriteLine($"  {i}. {dir[accno][i]}");
            }
        }
        else
        {
            Console.WriteLine("Account not found!");
        }
    }
  }
  class prog12
  {
    public static void Main(string[] arg)
    {
      string name = "xyz";
      string bkm = "The hole";
      int accno;
      Book res = new Book(name, bkm);
      accno = Convert.ToInt32(Console.ReadLine());
      res.addbook(accno, "pokemon guide");
      res.disp(accno);
    }
  }
}