using System;
class car
{
  private int speed ;
  public string brand {get;set;} 
  public void setspeed(int x)
  {
    if (x > 0)
    {
      speed = x;
    }
    else
    {
      Console.WriteLine("cant be zero or less then zero");
    }
  }
  public void display()
  {
    Console.WriteLine($"the name is = {brand} , the speed is  {speed}");
  }
}
class proj20
{
  static void Main(string[] arg)
  {
    car c  = new car();
    c.setspeed(2000);
    c.brand = "xyz";
    c.display(); 
  }
}