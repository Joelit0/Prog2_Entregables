using System;

namespace Person {
  public class Person
  {
    string nombre;
    string ci;

    public Person(string nombre, string ci)
    {
      this.nombre = nombre;
      this.ci = ci;
    }

    public void IntroduceYourself()
    {
      Console.WriteLine($"Nombre: {this.nombre}, CI: {this.ci}");
    }
    public void ValidCredentials()
    {
      if(IdUtils.IdIsValid(this.ci) && this.nombre.Trim() != "")
      {
          this.IntroduceYourself();
      } else {
          Console.WriteLine("Las credenciales son inválidas");
      }
    }
  }
}
