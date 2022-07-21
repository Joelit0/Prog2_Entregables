namespace PII_Herencia
{
  public class Passenger : User
  {
    public float Rating;

    protected Passenger(string name, string lastName, string id, float rating)
           :base(name, lastName, id)
    {
      this.Rating = rating;
    }

    public float Rating { get; set; }
  }
}
