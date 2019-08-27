using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int minNumber = 0, maxNumber = 0;
            float averageNumber = 0;
            int i;
            string number;
            bool flag;
            for (i = 0; i < 10; i++)
            {
                do
                {
                    Console.WriteLine("Ingrese un numero.");
                    number = Console.ReadLine();
                    flag = Validacion.Validar(number, -100, 100);
                    if(flag == false)
                    {
                        Console.WriteLine("Numero invalido, ingrese otro numero.");
                    }
                } while (flag == false);
                int numberCurrent = int.Parse(number);
                averageNumber = averageNumber + numberCurrent;
                if (i == 0)
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
            averageNumber = averageNumber / i;
            Console.WriteLine("El promedio es de {0}, con un valor minimo de {1} y un valor maximo de {2}", averageNumber, minNumber, maxNumber);
            Console.ReadKey();
        }
    }
}
