using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_26
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] vectorNumeros = new int[19];
      int[] vectorPositivo = new int[19];
      int[] vectorNegativo = new int[19];
      Random randomNumber = new Random();
      Console.WriteLine("Numeros Random: ");
      for(int i = 0; i < vectorNumeros.Length; i++)
      {
        vectorNumeros[i] = randomNumber.Next(-1000, 1000);
        Console.WriteLine("{0}", vectorNumeros[i]);
      }
      int j = 0;
      int x = 0;
      for (int i = 0; i < vectorNumeros.Length; i++)
      {
        if(vectorNumeros[i] >= 0)
        {
          vectorPositivo[j] = vectorNumeros[i];
          j++;
        }
        else
        {
          vectorNegativo[x] = vectorNumeros[i];
          x++;
        }
      }
      Array.Sort(vectorPositivo);
      Array.Reverse(vectorPositivo);
      Array.Sort(vectorNegativo);
      Console.WriteLine("Numeros Positivos: ");
      foreach(int numero in vectorPositivo)
      {
        if (numero != 0)
        {
          Console.WriteLine("{0}", numero);
        }
      }
      Console.WriteLine("Numeros Negativos: ");
      foreach (int numero in vectorNegativo)
      {
        if(numero != 0)
        {
          Console.WriteLine("{0}", numero);
        }        
      }
      Console.ReadKey();
    }
  }
}
