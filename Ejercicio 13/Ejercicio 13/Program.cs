using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
  class Program
  {
    static void Main(string[] args)
    {
      //Conversor Decimal
      double doubleValue;
      Console.WriteLine("Ingrese un numero decimal.");
      string number = Console.ReadLine();
      if (double.TryParse(number, out double numberCurrent))
      {
        number = Conversor.DecimalBinario(numberCurrent);
        number = Convert.ToString(0, 2);
        Console.WriteLine("Numero decimal {0}", number);
      }
      //Conversor Binario
      Console.WriteLine("Ingrese un numero binario.");
      number = Console.ReadLine();
      doubleValue = Conversor.BinarioDecimal(number);
      Console.WriteLine("Numero decimal {0}", doubleValue);
      Console.ReadKey();
    }
  }
}
