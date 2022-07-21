using System;

namespace DateFormat
{
  public class Program
  {
    public static String ChangeFormat(String date)
    {
      string day = date.Substring(0, 2);
      string month = date.Substring(3, 2);
      string year = date.Substring(6);

      return $"{year}-{month}-{day}";
    }

    public static String ChangeFormat2(String date)
    {
      string day = date.Substring(0, 2);
      string month = date.Substring(3, 2);
      string year = date.Substring(6);

      return $"{day}-{month}-{year}";
    }

    public static void Main(string[] args)
    {
      string testDate = "10/11/1977";
      Console.WriteLine($"{testDate} se convierte a: {ChangeFormat(testDate)}");
    }
  }
}