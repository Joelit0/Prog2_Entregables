namespace PII_Herencia
{
  public class User
  {
    public string Name;
    public string LastName;
    public string Id;

    protected User(string name, string lastName, string id)
    {
      this.Name = name;
      this.LastName = lastName;
      this.Id = id;
    }

    public string Name { get; set; }
    public string LastName { get; set; }
    public string Id { get; set; }
  }
}
