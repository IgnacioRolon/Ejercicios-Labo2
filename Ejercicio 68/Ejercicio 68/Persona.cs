using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_68
{
  public delegate void DelegadoString(string msg);

  public class Persona
  {
    private string apellido;
    private string nombre;
    public event DelegadoString EventoString;

    public string Nombre
    {
      get
      {        
        return nombre;
      }
      set
      {
        this.EventoString.Invoke("Nombre cambiado");
        nombre = value;
      }
    }

    public string Apellido
    {
      get
      {
        return apellido;
      }
      set
      {
        this.EventoString.Invoke("Apellido cambiado");
        apellido = value;
      }
    }

    public Persona()
    {
      this.apellido = "";
      this.nombre = "";      
    }

    public string Mostrar()
    {
      return this.Nombre + " " + this.Apellido;
    }
  }
}
