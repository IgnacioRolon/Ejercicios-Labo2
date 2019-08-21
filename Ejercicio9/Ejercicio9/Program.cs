using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            string piramidValue = "";
            string number = Console.ReadLine();
            int actualNumber = 0;
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
            } while (actualNumber < 1);
            for(int i = 0;i<actualNumber;i++)
            {
                if(i == 0)
                {
                    piramidValue = "*";
                    Console.WriteLine(piramidValue);
                    piramidValue = "";
                }
                else
                {
                    for (int j = 0; j < i; j++)
                    {
                        piramidValue += "**";
                    }
                    Console.WriteLine(piramidValue);
                    piramidValue = "";
                }                
                
            }
            Console.ReadKey();  
        }
    }
}
