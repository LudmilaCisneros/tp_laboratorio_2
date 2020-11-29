using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Hilo
    {
        #region Atributos

        private Thread hilo;
        private int intervaloMin;
        private int intervaloMax;

        public delegate void encargadoTiempo();
        public event encargadoTiempo EventoTiempo; //el evento es del tipo del delegado

        #endregion

        #region Constructores

        public Hilo(int intervaloMin, int intervaloMax)
        {
            this.intervaloMin = intervaloMin;
            this.intervaloMax = intervaloMax;
        }
        public Hilo(int intervalo)
        {
            this.intervaloMin = intervalo;
            this.intervaloMax = intervalo;
        }

        #endregion

        #region Propiedades

        /// <summary>
        /// Propiedad Vivo: si se le pasa true activa el hilo y lo instancia, false para abortarlo
        /// </summary>
        public bool Vivo
        {
            get
            {
                if (this.hilo != null)
                {
                    return this.hilo.IsAlive;
                }
                return false;
            }
            set
            {
                if (value)//si se le pasa true lo activa
                {
                    if (this.hilo == null || !this.hilo.IsAlive)
                    {
                        this.hilo = new Thread(Corriendo);
                        this.hilo.Start();
                    }
                }
                else
                {
                    if (this.hilo != null && this.hilo.IsAlive)
                    {
                        this.hilo.Abort();
                    }
                }
            }
        }

        /// <summary>
        /// Propiedad setea el valor intervaloMin
        /// </summary>
        public int IntervaloMin
        {
            get { return this.intervaloMin; }
            set { this.intervaloMin = value; }
        }

        /// <summary>
        /// Propiedad setea el valor intervaloMax
        /// </summary>
        public int IntervaloMax
        {
            get { return this.intervaloMax; }
            set { this.intervaloMax = value; }
        }
        #endregion

        #region Métodos

        /// <summary>
        /// Metodo que ejecuta el evento EventoTiempo,dentro del evento estan los metodos "suscriptos"
        /// </summary>
        private void Corriendo()
        {
            while (true)
            {
                if (EventoTiempo != null)
                {
                    EventoTiempo.Invoke();
                }
                Random r = new Random();
                Thread.Sleep(r.Next(intervaloMin, IntervaloMax));

            }
        }
        #endregion

    }
}
