using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum Tipo
    {
        Rocoso,
        Gaseoso
    }

    public abstract class Astro
    {
        private int duractionOrbita;
        private int duracionRotacion;
        protected string nombre;

        public Astro(int duraOrbita, int duraRotacion, string nombre)
        {
            this.duractionOrbita = duraOrbita;
            this.duracionRotacion = duraRotacion;
            this.nombre = nombre;
        }

        protected string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("Nombre: {0} - Órbita: {1} - Rotación: {2}", this.nombre, this.duractionOrbita, this.duracionRotacion);
            return str.ToString();
        }
        public abstract string Orbitar();
        
        public virtual string Rotar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("Rotando. Tiempo estimado: {0}.", this.duracionRotacion);
            return str.ToString();
        }
        public static explicit operator string(Astro astroActual)
        {
            return astroActual.nombre;
        }
    }
}
