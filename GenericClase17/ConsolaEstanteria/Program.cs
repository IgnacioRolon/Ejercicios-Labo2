using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace ConsolaEstanteria
{
  class Program
  {
    static void Main(string[] args)
    {
      bool flag;
      Estanteria<Producto> estanteria1 = new Estanteria<Producto>(5);
      Estanteria<Alimenticio> estanteria2 = new Estanteria<Alimenticio>(5);
      Estanteria<Ferreteria> estanteria3 = new Estanteria<Ferreteria>(5);

      Alimenticio alimenticioGenerico = new Alimenticio(1, "Alimento Generico", new DateTime(2019, 10, 21));
      Ferreteria ferreteriaGenerico = new Ferreteria(2, "Herramienta Generica", 25.5f);
      flag = estanteria2 + alimenticioGenerico;
      flag = estanteria3 + ferreteriaGenerico;

      Console.WriteLine(estanteria2.Productos[0].Descripcion);
      Console.WriteLine(estanteria3.Productos[0].Descripcion);
      Console.ReadKey();
    }
  }
}
