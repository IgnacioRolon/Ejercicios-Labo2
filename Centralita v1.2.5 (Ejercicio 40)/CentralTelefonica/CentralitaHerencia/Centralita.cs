using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
  public class Centralita
  {
    private List<Llamada> listaDeLlamadas;
    protected string razonSocial;
    public Centralita()
    {
      this.listaDeLlamadas = new List<Llamada>();
    }
    public Centralita(string nombreEmpresa)
      :this()
    {
      this.razonSocial = nombreEmpresa;
    }

    public float GananciasPorLocal
    {
      get
      {
        return CalcularGanancia(Llamada.TipoLlamada.Local);
      }
    }

    public float GananciasPorProvincial
    {
      get
      {
        return CalcularGanancia(Llamada.TipoLlamada.Provincial);
      }
    }

    public float GananciasPorTotal
    {
      get
      {
        return CalcularGanancia(Llamada.TipoLlamada.Todas);
      }
    }

    public List<Llamada> Llamadas
    {
      get
      {
        return this.listaDeLlamadas;
      }
    }

    private float CalcularGanancia(Llamada.TipoLlamada tipo)
    {
      float gananciaLocal = 0f;
      float gananciaProvincial = 0f;
      float gananciaTotal = 0f;
      foreach(Llamada item in listaDeLlamadas)
      {
        if (item is Local)
        {
          gananciaLocal += (item as Local).CostoLlamada;
        }
        else if (item is Provincial)
        {
          gananciaProvincial += (item as Provincial).CostoLlamada;
        }
      }
      gananciaTotal = gananciaLocal + gananciaProvincial;
      switch (tipo)
      {
        case Llamada.TipoLlamada.Local:
          return gananciaLocal;
        case Llamada.TipoLlamada.Provincial:
          return gananciaProvincial;
        case Llamada.TipoLlamada.Todas:
          return gananciaTotal;
      }
      return 0;
    }

    private string Mostrar()
    {
      StringBuilder str = new StringBuilder();
      str.AppendFormat("Razon Social: {0}, Ganancia Total: {1}, Ganancia Local: {2}, Ganancia Provincial: {3}\n", this.razonSocial, this.GananciasPorTotal, this.GananciasPorLocal, this.GananciasPorProvincial);
      foreach(Llamada item in this.listaDeLlamadas)
      {
        if(item is Local)
        {
          str.AppendLine((item as Local).ToString());
        }else if(item is Provincial)
        {
          str.AppendLine((item as Provincial).ToString());
        }
      }
      return str.ToString();
    }

    public void OrdenarLlamadas()
    {
      this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuración);
    }
    private void AgregarLlamada(Llamada nuevaLlamada)
    {
      this.Llamadas.Add(nuevaLlamada);
    }

    public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
    {
      if(c != nuevaLlamada)
      {
        c.AgregarLlamada(nuevaLlamada);
      }
      return c;
    }
    public static bool operator ==(Centralita c, Llamada llamada)
    {
      foreach(Llamada item in c.Llamadas)
      {
        if(item == llamada)
        {
          return true;
        }
      }
      return false;
    }
    public static bool operator !=(Centralita c, Llamada llamada)
    {
      return !(c == llamada);
    }

    public override string ToString()
    {
      return this.Mostrar();
    }
  }
}
