using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10
{
  public abstract class Persona
  {
    public string nombre { get; set; }
    public int cuil { get; set; }

    public Persona(string nombre, int cuil)
    {
      this.nombre = nombre;
      this.cuil = cuil;
    }

    public abstract string Mostrar();
  }
}
