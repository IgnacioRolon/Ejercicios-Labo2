using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Satelite:Astro
    {
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        public Satelite(int duraOrbita, int duraRotacion, string nombre)
        : base(duraOrbita, duraRotacion, nombre)
        {

        }
        public override string Orbitar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("Orbitar el satelite: {0}.", this.nombre);
            return str.ToString();
        }

        public override string ToString()
        {            
            return this.Mostrar();
        }
    }    
}
