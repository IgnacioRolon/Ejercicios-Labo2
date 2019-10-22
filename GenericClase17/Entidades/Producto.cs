using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public abstract class Producto
  {
    private int id_prod;
    private string descripcion;

    public int IdProd
    {
      get
      {
        return this.id_prod;
      }
      set
      {
        this.id_prod = value;
      }
    }
    public string Descripcion
    {
      get
      {
        return this.descripcion;
      }
      set
      {
        this.descripcion = value;
      }
    }
    public Producto(int idProducto, string descripcion)
    {
      this.id_prod = idProducto;
      this.descripcion = descripcion;
    }
  }
}
