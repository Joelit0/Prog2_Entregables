using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
  // En esta clase utilizamos el principio SRP debido a que estamos asignandole una sola responsabilidad
  // Esta clase tiene la responsabilidad de poder imprimir la receta en la consola

  public class ConsolePrinter
  {
    public static void PrintRecipe(ArrayList steps, Product finalProduct)
    {
      Console.WriteLine($"Receta de {finalProduct.Description}:");

      foreach (Step step in steps)
      {
          Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
              $"usando '{step.Equipment.Description}' durante {step.Time}");
      }
    }
  }
}
