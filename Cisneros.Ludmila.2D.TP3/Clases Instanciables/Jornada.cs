using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;

namespace Clases_Instanciables
{
    public class Jornada
    {
        #region Atributos

        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;

        #endregion

        #region Propiedades

        public List<Alumno> Alumnos 
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }
        public Universidad.EClases Clase
        {
            get
            {
                return this.clase;
            }
            set
            {
                this.clase = value;
            }
        }

        public Profesor Instructor
        {
            get
            {
                return this.instructor;
            }
            set
            {
                this.instructor = value;
            }
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Mostrar datos jornada
        /// </summary>
        /// <param</param>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CLASE DE: " + this.clase.ToString() );
            sb.AppendLine(this.instructor.ToString());

            foreach (Alumno item in this.alumnos)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
        /// <summary>
        /// Guarda en un archivo de txt los datos de la jornada
        /// </summary>
        /// <param name="jornada"></param>
        /// <returns></returns>
        public static bool Guardar(Jornada jornada)
        {
            Texto archivoTxt = new Texto();
            string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "Jornada");

            if (archivoTxt.Guardar(path, jornada.ToString()))
            {
                return true;
            }

            return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string Leer()
        {
            Texto archivoTxt = new Texto();
            string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "Jornada");
            archivoTxt.Leer(path, out string jornadaDatos);

            return jornadaDatos;
        }

        #endregion

        #region SobreCarga Operadores

        /// <summary>
        /// Una Jornada será igual a un Alumno si pertenece a la clase.
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator ==(Jornada j, Alumno a)
        {
            return j.alumnos.Contains(a);
        }

        /// <summary>
        ///Comprueba que un alumno no pertenezca a la clase
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }

        /// <summary>
        /// Agrega un alumno a la lista
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns>Devuelve un objeto de tipo Jornada con el Alumno cargado (si corresponde)</returns>
        public static Jornada operator +(Jornada j, Alumno a)
        {
            if (j != a)
            {
                j.alumnos.Add(a);
            }

            return j;
        }
        #endregion

        #region Constructores
        private Jornada()
        {
            this.alumnos = new List<Alumno>();
        }
        public Jornada(Universidad.EClases clase, Profesor instructor):this()
        {
            this.instructor = instructor;
            this.clase = clase;
        }
        #endregion
    }
}
