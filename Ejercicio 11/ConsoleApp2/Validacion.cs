using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Validacion
    {
        public static bool Validar(string valor, int min, int max)
        {
            if(int.TryParse(valor, out int numberCurrent))
            {
                if (numberCurrent >= min && numberCurrent <= max)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }                        
        }
    }
}
