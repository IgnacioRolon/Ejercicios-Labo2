using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
  class Program
  {
    static void Main(string[] args)
    {
      int minNumber = 0, maxNumber = 0;
      float averageNumber = 0;      
      int i;
      for(i = 0; i < 5; i++)
      {
        Console.WriteLine("Ingrese un numero.");
        string number = Console.ReadLine();
        if (int.TryParse(number, out int numberCurrent))
        {
          averageNumber = averageNumber + numberCurrent;
          if(i == 0)
          {
            minNumber = numberCurrent;
            maxNumber = numberCurrent;
          }
          else
          {
            if (numberCurrent > maxNumber)
            {
              maxNumber = numberCurrent;
            }
            if (numberCurrent < minNumber)
            {
              minNumber = numberCurrent;
            }
          }
        }
      }
      averageNumber = averageNumber / i;
      Console.WriteLine("El promedio es de {0}, con un valor minimo de {1} y un valor maximo de {2}", averageNumber, minNumber, maxNumber);
      Console.ReadKey();
    }
  }
}
