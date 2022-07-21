namespace PII_Herencia
{
  public class Driver : User
  {
    public string Car;
    public float Rating;

    protected Driver(string name, string lastName, string id, string car, float rating)
           :base(name, lastName, id)
    {
      this.Car = car;
      this.Rating = rating;
    }

    public string Car { get; set; }
    public float Rating { get; set; }
  }
}
