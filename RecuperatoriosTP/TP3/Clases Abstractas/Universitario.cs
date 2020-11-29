using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Abstractas
{
    public abstract class Universitario : Persona
    {
        #region Atributos

        private int legajo;

        #endregion

        #region Métodos

        /// <summary>
        /// Valida si son del mismo tipo
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool ret = false;
            
            if(this.GetType() == obj.GetType())
            {
                ret = true;
                return ret;
            }
            return ret;
        }
        /// <summary>
        /// Retorna el mostrar datos de Persona(base) concatenando legajo
        /// </summary>
        /// <returns></returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"{base.ToString()}LEGAJO NÚMERO: {this.legajo}\n\n");
            return sb.ToString();
        }

        protected abstract string ParticiparEnClase();

        #endregion

        #region Sobrecarga Operadores
        /// <summary>
        /// Comprueba si los dos universitarios son iguales
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns>true || false</returns>
        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            if (pg1.Dni == pg2.Dni && pg1.legajo == pg2.legajo && pg1.Equals(pg2))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Comprueba si los dos universitarios son distintos
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns>true || false</returns>
        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }

        #endregion

        #region Constructores
        public Universitario()
        {
        }

        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(nombre, apellido, dni, nacionalidad)
        {
            this.legajo = legajo;
        }
        #endregion
    }
}
