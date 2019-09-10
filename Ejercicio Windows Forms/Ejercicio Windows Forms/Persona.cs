using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Windows_Forms
{
  public class Persona
  {
    private string nombre;
    private string apellido;
    private int dni;

    public Persona(string nombre, string apellido, int dni)
    {
      this.nombre = nombre;
      this.apellido = apellido;
      this.dni = dni;
    }

    public string MostrarPersona()
    {
      return this.nombre + " " + this.apellido + " " + this.dni.ToString();
    }
  }
}
