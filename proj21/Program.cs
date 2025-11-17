using System;
class Car
{
  public string brand{get;set;}
  private int speed;
  public virtual void drive()
  {
    Console.WriteLine("normal car");
  }
  public int setspeed(int x)
  {
    if(x >= 0){
      speed = x;
    }
    return speed;
  }

}
class SportsCar:Car
{

  public int Turboboost{set;get;}
  public override void drive()
  {
    Console.WriteLine("this is fast one "); 
  }
  public void Showboost()
  {
    Console.WriteLine($"brand : {brand},turboboost : {Turboboost}");
  }
  
}
class proj21
{
  public static void Main(String[] arg)
  {
    Car sp = new SportsCar();
    Car c = new Car();
    sp.drive();
    c.drive();
    
  }
}