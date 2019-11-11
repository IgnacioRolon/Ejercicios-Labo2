using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_67
{
  public sealed class Temporizador
  {
    private Thread hilo;
    private int intervalo;

    public bool Activo
    {
      get
      {
        return hilo.IsAlive;
      }
      set
      {
        if(value == false)
        {
          if(hilo.IsAlive)
          {
            hilo.Abort();
          }
        }else
        {
          if(!hilo.IsAlive)
          {
            hilo.Start();
          }
        }
      }
    }


  }
}
