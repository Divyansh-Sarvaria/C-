using System;
namespace program
{
  class cunst
  {
    public cunst()
    {
      Console.WriteLine("runing cunstructor");
    }
  }
  class prog_13
  {
    public static void Main(string[] arg)
    {
      cunst res = new cunst();
    }
  }
}