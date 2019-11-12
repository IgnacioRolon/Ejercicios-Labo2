using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_67
{
    public sealed class Temporizador
    {
        public delegate void encargadoTiempo();
        public event encargadoTiempo eventoTiempo;

        private Thread hilo;
        private int intervalo;

        public Temporizador()
        {
            hilo = new Thread(this.Corriendo);
        }
        public bool Activo
        {
            get
            {
                return hilo.IsAlive;
            }
            set
            {
                if(value == false)
                {
                    if(hilo.IsAlive)
                    {
                        hilo.Abort();
                    }
                }else
                {
                    if(!hilo.IsAlive)
                    {
                        hilo.Start();
                    }
                }
            }
        }

        public int Intervalo
        {
            get
            {
                return this.intervalo;
            }
            set
            {
                this.intervalo = value;
            }
        }

        private void Corriendo()
        {
            while(this.Activo == true)
            {
                Thread.Sleep(intervalo);
                eventoTiempo.Invoke();
            }            
        }
    }
}
