using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Ingrese un numero");
      string number = Console.ReadLine();
      int actualNumber = 0;
      double powNumber;
      do
      {
        if (int.TryParse(number, out actualNumber))
        {
          if(actualNumber < 0)
          {
            Console.WriteLine("ERROR. ¡Reingresar número!");
            number = Console.ReadLine();
          }
        }
      } while (actualNumber < 0);
      powNumber = Math.Pow(actualNumber, 2);
      Console.WriteLine("El cuadrado es {0}", powNumber);
      powNumber = Math.Pow(actualNumber, 3);
      Console.WriteLine("El cubo es {0}", powNumber);
      Console.ReadKey();
    }
  }
}
