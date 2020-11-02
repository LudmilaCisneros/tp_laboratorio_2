using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Clases_Abstractas
{
    public abstract class Persona
    {
        #region Atributos
        private string nombre;
        private string apellido;
        private ENacionalidad nacionalidad;
        private int dni;
        #endregion

        #region Propiedades
        public string Apellido
        {
            get
            {
                return this.apellido;
            }

            set
            {
                if (this.ValidarNombreApellido(value) != String.Empty)
                {
                    this.apellido = value;
                }
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                if (this.ValidarNombreApellido(value) != String.Empty)
                {
                    this.nombre = value;
                }
            }
        }

        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.ValidarDni(this.nacionalidad, value);
            }
        }
        public ENacionalidad Nacionalidad
        {
            get
            {
                return this.nacionalidad;
            }
            set
            {
                this.nacionalidad = value;
            }
        }

        public string StringToDNI
        {
            set
            {
                this.dni = this.ValidarDni(this.nacionalidad, value);
            }
        }

        #endregion

        #region Constructores
        public Persona()
        {

        }
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad):this(nombre, apellido,nacionalidad)
        {
            this.dni = dni;
        }
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }
        #endregion

        #region Métodos

        /// <summary>
        /// Sobrescribe el ToString
        /// </summary>
        /// <returns>los datos de una persona</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"APELLIDO Y NOMBRE: {this.Apellido}, {this.Nombre}");
            sb.AppendLine($"NACIONALIDAD: {this.Nacionalidad}");
            sb.AppendLine($"DNI: {this.Dni}");

            return sb.ToString();
        }
        /// <summary>
        /// Valida que el dato sea un DNI, sino lanza una exception
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns> dato </returns>
        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            switch (nacionalidad)
            {
                case ENacionalidad.Argentino:
                    if(dato < 1 || dato < 89999999)
                    {
                        throw new NacionalidadInvalidaException();
                    }
                    break;

                case ENacionalidad.Extranjero:
                    if ((dato < 90000000 || dato > 99999999))
                    {
                        throw new NacionalidadInvalidaException();
                    }
                    break;
            }
            return dato;
        }
            
        /// <summary>
        /// Si el datoStr es un dni válido lo retorna, sino retorna (-1)
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns></returns>
        private  int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int datoAux = -1;

            if (!int.TryParse(dato,out datoAux) && datoAux < 1 || datoAux > 99999999)
            {
                throw new DniInvalidoException();


            }
            return this.ValidarDni(nacionalidad, datoAux);
        }

    /// <summary>
    /// Valida que el string sea Nombre o Apellido
    /// </summary>
    /// <param name="dato"></param>
    /// <returns>str empty caso que no pase validaciones, sino el str </returns>
    private string ValidarNombreApellido(string dato)
        {
            int intAux;

            if(dato.Length < 4 || string.IsNullOrEmpty(dato) || int.TryParse(dato,out intAux))
            {
                return string.Empty;
            }
            return dato;
        }

        #endregion

        #region Enumerados
        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }
        #endregion
    }
}

