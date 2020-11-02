using Clases_Abstractas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Instanciables
{
    public sealed class Profesor : Universitario
    {
        #region Atributos

        private Queue<Universidad.EClases> clasesDelDia;
        private static Random random;

        #endregion

        #region Constructores
        static Profesor()
        {
            random = new Random();
        }
        public Profesor() : base()
        {
            
        }
        public Profesor(int id,string nombre,string apellido,string dni,ENacionalidad nacionalidad):base(id,nombre,apellido,dni,nacionalidad)
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
            this._randomClases();
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Selecciona 2 clases al azar al profesor
        /// </summary>
        private void _randomClases()
        {
            int materia = 0;

            while(materia < 2)
            {
                materia = random.Next(1, 4);
                switch(materia)
                {
                    case 1:
                        this.clasesDelDia.Enqueue(Universidad.EClases.Programacion);
                        break;

                    case 2:
                        this.clasesDelDia.Enqueue(Universidad.EClases.Laboratorio);
                        break;

                    case 3:
                        this.clasesDelDia.Enqueue(Universidad.EClases.SPD);
                        break;

                    case 4:
                        this.clasesDelDia.Enqueue(Universidad.EClases.Legislacion);
                        break;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>retornará la cadena "CLASES DEL DÍA" junto al nombre de la clases que da.</returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CLASES DEL DÍA: ");

            foreach (Universidad.EClases clases in clasesDelDia)
            {
                sb.AppendLine(clases.ToString());
            }
            
            return sb.ToString();
        }

        /// <summary>
        /// Muestra los datos del profesor
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine(this.ParticiparEnClase());

            return sb.ToString();
        }
        /// <summary>
        /// Hace público MostrarDatos()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        #endregion

        #region SobreCarga Operadores

        /// <summary>
        /// Un Profesor será igual a un EClase si da esa clase.
        /// </summary>
        /// <param name="i">Profesor</param>
        /// <param name="clases">Clase a comprobar</param>
        /// <returns></returns>
        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            if(i.clasesDelDia.Contains(clase))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Verifica si un profesor no da clases de la materia recibida por parametro
        /// </summary>
        /// <param name="i">Profesor</param>
        /// <param name="clases">Clase a comprobar</param>
        /// <returns></returns>
        public static bool operator !=(Profesor i, Universidad.EClases clases)
        {
            return !(i == clases);
        }

        #endregion
    }
}
