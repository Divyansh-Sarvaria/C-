using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
namespace Prog1
{
  public partial class Kata
  {
    public static string FstName(string fName)
    {
      var firstNames = new Dictionary<string, string>()
     {
        { "A", "Anomaly" },
        { "B", "Bong" },
        { "C", "Coconut" },
        { "D", "Doodle" },
        { "E", "Eclipse" },
        { "F", "Fizzle" },
        { "G", "Giggle" },
        { "H", "Hobnob" },
        { "I", "Igloo" },
        { "J", "Jellybean" },
        { "K", "Krazy" },
        { "L", "Lollipop" },
        { "M", "Muffin" },
        { "N", "Noodle" },
        { "O", "Oompa" },
        { "P", "Pickle" },
        { "Q", "Quirky" },
        { "R", "Rascal" },
        { "S", "Snickerdoodle" },
        { "T", "Twizzle" },
        { "U", "Umbrella" },
        { "V", "Velcro" },
        { "W", "Wobble" },
        { "X", "Xylobop" },
        { "Y", "Yoyo" },
        { "Z", "Zigzag" }
      };
      string Fn = fName.Substring(0, 1).ToUpper();
      return firstNames.ContainsKey(Fn) ? firstNames[Fn] : " Invalid name must start with a letter !! ";
    }
  }
  public partial class Kata
  {
    public static string LasName(string lName)
    {
      var lastNames = new Dictionary<string, string>()
{
    { "A", "Asteroid" },
    { "B", "Bubblegum" },
    { "C", "Cabbage" },
    { "D", "Dynamite" },
    { "E", "Eclair" },
    { "F", "Fandango" },
    { "G", "Gingersnap" },
    { "H", "Hiccup" },
    { "I", "Inkblot" },
    { "J", "Jamboree" },
    { "K", "Ketchup" },
    { "L", "Lasagna" },
    { "M", "Marshmallow" },
    { "N", "Nacho" },
    { "O", "Octopus" },
    { "P", "Pancake" },
    { "Q", "Quicksand" },
    { "R", "Rhubarb" },
    { "S", "Sprinkle" },
    { "T", "Taco" },
    { "U", "Unicorn" },
    { "V", "Volcano" },
    { "W", "Waffles" },
    { "X", "Xenon" },
    { "Y", "Yakitori" },
    { "Z", "Zamboni" }
};
      string sn = lName.Substring(0, 1).ToUpper();
      return lastNames.ContainsKey(sn) ? lastNames[sn] : " Invalid name must start with a letter !! ";

    }
    
  }
  public partial class Kata
  {
    public static string AliasGen(string fName , string lName)
    {
            string cusFst = FstName(fName);
            string cusLst = LasName(lName);
            return $"{cusFst} - {cusLst}";
    }
  }
  class Program
  {
    static void Main(String[] args)
    {
      Console.WriteLine("Write First Name:");
      string fstnm = Console.ReadLine();
      Console.WriteLine("Write Last Name:");
      string lstnm = Console.ReadLine();
      string funkyName = Kata.AliasGen(fstnm, lstnm);
      Console.WriteLine($"The funky name is: {funkyName}");
    }
  }
}