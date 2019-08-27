using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
  public class Conversor
  {
    public static string DecimalBinario(double value)
    {
      string output = Convert.ToString(value);

      //string output = Convert.ToString(value, );
      //long longOutput = BitConverter.DoubleToInt64Bits(value);
      //string output = Convert.ToString(longOutput, 2);
      //return output;

    }
    public static double BinarioDecimal(string value)
    {
      long n = Convert.ToInt64(value, 2); // 将二进制字符串转成 Int64
      double x = BitConverter.Int64BitsToDouble(n); // 将 Int64 转成 double
      return x;
    }
  }
}
