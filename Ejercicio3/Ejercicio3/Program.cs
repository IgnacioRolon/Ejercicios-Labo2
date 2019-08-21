using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
  class Program
  {
    static void Main(string[] args)
    {
      string number = Console.ReadLine();
      int actualNumber = 0;
      float floatValue;
      bool prFlag = false;
      do
      {
        if (int.TryParse(number, out actualNumber))
        {
          if (actualNumber < 0)
          {
            Console.WriteLine("ERROR. ¡Reingresar número!");
            number = Console.ReadLine();
          }
        }
      } while (actualNumber < 0);
      for(int j = actualNumber; j > 0; j--)
      {
        prFlag = false;
        for (int i = j; i > 0; i--)
        {
          if (j != i && i != 0 && i != 1)
          {
            floatValue = (float)j;
            if (floatValue % i == 0)
            {
              prFlag = true;
              break;
            }
          }
        }
        if (prFlag == false)
        {
          Console.WriteLine("Numero {0}", j);
        }
      }
      Console.ReadKey();
    }
  }
}
