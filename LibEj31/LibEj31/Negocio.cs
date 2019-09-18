using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibEj31
{
  public class Negocio
  {
    private PuestoAtencion caja;
    private Queue<Cliente> clientes;
    private string nombre;

    public Cliente Cliente
    {
      get
      {
        if (clientes.Count == 0)
        {
          return null;
        }
        return clientes.Dequeue();
      }

      set
      {
        bool buffer = this + value;
      }
    }

    private Negocio()
    {
      this.clientes = new Queue<Cliente>();
      this.caja = new PuestoAtencion(Puesto.Caja1);
    }
    public Negocio(string nombre)
      : this()
    {
      this.nombre = nombre;
    }

    public static bool operator ==(Negocio n, Cliente c)
    {
      foreach (Cliente item in n.clientes)
      {
        if (item == c)
        {
          return true;
        }
      }
      return false;
    }
    public static bool operator !=(Negocio n, Cliente c)
    {
      foreach (Cliente item in n.clientes)
      {
        if (item == c)
        {
          return false;
        }
      }
      return true;
    }
    public static bool operator ~(Negocio n)
    {
      if(n.Cliente != null)
      {
        if(n.caja.Atender(n.Cliente) == true)
        {
          return true;
        }        
      }
      return false;
    }
    public static bool operator +(Negocio n, Cliente c)
    {
      foreach (Cliente item in n.clientes)
      {
        if (item == c)
        {
          return false;
        }
      }
      n.clientes.Enqueue(c);
      return true;
    }
    public int ClientesPendientes
    {
      get
      {
        return this.clientes.Count;
      }
    }
  }
}
