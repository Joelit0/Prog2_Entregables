// See https://aka.ms/new-console-template for more information

namespace LeapYear
{
  class Year
  {
    public static bool isLeap(int year)
    {
      return (year % 4 == 0) && (!(year % 100 == 0) || (year % 400 == 0));
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      bool yearLeap = Year.isLeap(2000);

      Console.WriteLine($"2000 es bisiesto? True : {yearLeap}");
    }
  }
}
