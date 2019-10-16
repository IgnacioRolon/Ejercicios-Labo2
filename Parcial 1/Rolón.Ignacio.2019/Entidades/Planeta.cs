using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Planeta:Astro
    {
        private int cantSatelites;
        private Tipo tipo;
        private List<Astro> satelites;
        public List<Astro> Satelites
        {
            get
            {
                return this.satelites;
            }
        }

        public Planeta(int duraOrbita, int duraRotacion, string nombre)
            :base(duraOrbita, duraRotacion, nombre)
        {
            this.satelites = new List<Astro>();
        }
        public Planeta(int duraOrbita, int duraRotacion, string nombre, int cantidadSatelites, Tipo tipo)
            :this(duraOrbita, duraRotacion, nombre)
        {
            this.cantSatelites = cantidadSatelites;
            this.tipo = tipo;
        }

        public static Planeta operator +(Planeta planeta, Astro astroActual)
        {
            if(astroActual is Satelite)
            {
                planeta.satelites.Add(astroActual);
                return planeta;
            }
            return planeta;
        }
        public static bool operator ==(Planeta planeta, Satelite satelite)
        {
            foreach(Satelite item in planeta.satelites)
            {
                if(item.Nombre == satelite.Nombre)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator != (Planeta planeta, Satelite satelite)
        {
            return !(planeta == satelite);
        }
        public static bool operator == (Planeta planeta, Planeta planeta2)
        {
            return planeta.nombre == planeta2.nombre;
        }
        public static bool operator != (Planeta planeta, Planeta planeta2)
        {
            return !(planeta == planeta2);
        }

        public override string Orbitar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("Orbitar el planeta: {0}.", this.nombre);
            return str.ToString();
        }
        public new string Rotar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("Rota el planeta: {0}.", this.nombre);
            return str.ToString();
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("{0} - Cantidad de Satelites: {1} - Tipo: {2}\n", this.Mostrar(), this.cantSatelites.ToString(), this.tipo.ToString());
            if(this.satelites.Count > 0)
            {
                str.AppendLine("Satelites: ");
                foreach (Satelite item in this.satelites)
                {
                    str.AppendLine(item.ToString());
                }
            }            
            return str.ToString();
        }
    }
}
