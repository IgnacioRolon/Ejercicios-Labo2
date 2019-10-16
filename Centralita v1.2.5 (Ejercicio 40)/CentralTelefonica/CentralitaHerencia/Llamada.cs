using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
  public abstract class Llamada
  {
    public enum TipoLlamada
    {
      Local,
      Provincial,
      Todas
    }
    protected float duracion;
    protected string nroDestino;
    protected string nroOrigen;

    public abstract float CostoLlamada
    {
      get;
    }

    public float Duracion
    {
      get
      {
        return this.duracion;
      }
    }

    public string NroDestino
    {
      get
      {
        return this.nroDestino;
      }
    }

    public string NroOrigen
    {
      get
      {
        return this.nroOrigen;
      }
    }

    public Llamada(float duracion, string nroDestino, string nroOrigen)
    {
      this.duracion = duracion;
      this.nroDestino = nroDestino;
      this.nroOrigen = nroOrigen;
    }

    protected virtual string Mostrar()
    {
      StringBuilder str = new StringBuilder();
      str.AppendFormat("Numero de Origen: {0}, Numero de Destino: {1}, Duración de Llamada: {2}", this.nroOrigen, this.nroDestino, this.duracion);
      return str.ToString();
    }

    public static int OrdenarPorDuración(Llamada llamada1, Llamada llamada2)
    {
      return llamada1.duracion.CompareTo(llamada2.duracion);
    }

    public static bool operator !=(Llamada l1, Llamada l2)
    {
      return !l1.Equals(l2);
    }

    public static bool operator ==(Llamada l1, Llamada l2)
    {
      if(l1.Equals(l2) && l1.NroDestino == l2.NroDestino && l1.NroOrigen == l2.NroOrigen)
      {
        return true;
      }
      return false;
    }
  }
}
