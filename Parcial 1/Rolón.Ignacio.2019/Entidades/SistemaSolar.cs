using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaSolar
    {
        private List<Astro> planetas;
        public List<Astro> Planetas
        {
            get
            {
                return this.planetas;
            }
        }

        public SistemaSolar()
        {
            this.planetas = new List<Astro>();
        }

        public string MostrarInformacionAstros()
        {
            StringBuilder str = new StringBuilder();
            foreach (Astro item in this.planetas)
            {
                str.AppendLine(item.ToString());
            }
            return str.ToString();
        }
    }
}
