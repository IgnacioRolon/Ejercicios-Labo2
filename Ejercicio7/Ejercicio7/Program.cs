using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fecha = new int[3];
            
            int actualNumber = 0;
            for(int i = 0; i < 3; i++)
            {
                switch(i)
                {
                    case 0:
                        Console.WriteLine("Ingrese el año");
                        break;
                    case 1:
                        Console.WriteLine("Ingrese el mes");
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el dia");
                        break;
                }
                string number = Console.ReadLine();
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
                fecha[i] = actualNumber;
            }
            var finalDate = new DateTime(fecha[0], fecha[1], fecha[2], 0, 0, 0);
            var currentDate = DateTime.Now;
            TimeSpan diff1 = currentDate.Subtract(finalDate);
            Console.WriteLine("La persona vivió {0} días.", diff1.Days);
            Console.ReadKey();
        }
    }
}
