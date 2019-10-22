using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Alimenticio:Producto
  {
    private DateTime vencimiento;

    public DateTime Vencimiento
    {
      get
      {
        return this.vencimiento;
      }
      set
      {
        this.vencimiento = value;
      }
    }

    public Alimenticio(int idProducto, string descripcion, DateTime vencimiento)
      :base(idProducto, descripcion)
    {
      this.vencimiento = vencimiento;
    }

  }
}
