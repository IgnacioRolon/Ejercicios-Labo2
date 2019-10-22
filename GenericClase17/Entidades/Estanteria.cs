using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Estanteria<T> where T : Producto
  {
    private int tamaño;
    private T[] productos;

    public T[] Productos
    {
      get
      {
        return productos;
      }
      set
      {
        productos = value;
      }
    }

    public int Tamaño
    {
      get
      {
        return this.tamaño;
      }
      set
      {
        this.tamaño = value;
      }
    }

    public Estanteria(int tamaño)
    {
      this.tamaño = tamaño;
      this.productos = new T[tamaño];
    }

    public static bool operator +(Estanteria<T> estanteria, T producto) 
    {
      foreach(T p in estanteria.productos)
      {
        if(p == producto)
        {
          return false;
        }
      }
      for(int i = 0;i<estanteria.tamaño;i++)
      {
        if(estanteria.productos[i] == null)
        {
          estanteria.productos[i] = producto;
          return true;
        }
      }
      return false;
    }

    public static bool operator-(Estanteria<T> estanteria, Producto producto)
    {
      for (int i = 0; i < estanteria.tamaño; i++)
      {
        if(estanteria.productos[i] == producto)
        {
          estanteria.productos[i] = null;
          return true;
        }
      }
      return false;
    }

    public override string ToString()
    {
      string str = "Estanteria - Tamaño: " + this.tamaño;
      return str;
    }
  }
}
