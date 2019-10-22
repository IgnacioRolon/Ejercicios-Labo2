using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Ferreteria:Producto
  {
    private float peso;

    public float Peso
    {
      get
      {
        return peso;
      }
      set
      {
        peso = value;
      }
    }

    public Ferreteria(int idProducto, string descripcion, float peso)
      : base(idProducto, descripcion)
    {
      this.peso = peso;
    }

  }
}
