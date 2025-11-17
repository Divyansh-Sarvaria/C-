using System;
public class student
{
  int id = 1;
  String name = "x";
  public void display()
  {
    Console.WriteLine($"the name is = {name} , the id is = {id}");
  }
}
class proj4
{
  static void Main(string[] arg)
  {
    student s = new student();
    s.display();
  }
}