using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using Excepciones;


namespace Clases_Instanciables
{
    public class Universidad
    {
        #region Atributos

        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;

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
        public List<Profesor> Instructores
        {
            get
            {
                return this.profesores;
            }
            set
            {
                this.profesores = value;
            }
        }
        public List<Jornada> Jornadas
        {
            get
            {
                return this.jornada;
            }
            set
            {
                this.jornada = value;
            }
        }
        public Jornada this[int i]
        {
            get
            {
                return this.jornada[i];
            }
            set
            {
                this.jornada[i] = value;
            }
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Guarda archivo XML
        /// </summary>
        /// <param name="uni"></param>
        /// <returns></returns>
        public static bool Guardar(Universidad uni)
        {
            Xml<Universidad> archivoXmlUni = new Xml<Universidad>();
            string path = AppDomain.CurrentDomain.BaseDirectory + "Universidad.xml";

            if (archivoXmlUni.Guardar(path, uni))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Lee el archivo XML
        /// </summary>
        /// <returns></returns>
        public static Universidad Leer()
        {
            Universidad uni = new Universidad();
            Xml<Universidad> archivoXmlUni = new Xml<Universidad>();
            string path = AppDomain.CurrentDomain.BaseDirectory + "Universidad.xml";
            archivoXmlUni.Leer(path, out uni);

            return uni;
        }
        /// <summary>
        /// Muestra los datos de la Universidad
        /// </summary>
        /// <param name="uni"></param>
        /// <returns></returns>
        private string MostrarDatos(Universidad uni)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Jornada jornada in uni.jornada)
            {
                sb.AppendLine(jornada.ToString());
            }

            return sb.ToString();
        }
        /// <summary>
        /// Hace publico MostrarDatos()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return MostrarDatos(this);
        }
        #endregion

        #region Sobrecarga Operadores

        /// <summary>
        /// compara si no esta inscripto
        /// </summary>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="g"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }
        public static Profesor operator !=(Universidad u, EClases clase)
        {
            Profesor aux = null;
            foreach (Profesor item in u.Instructores)
            {
                if (item != clase)
                {
                    aux = item;
                    break;
                }
            }
            return aux;
        }
        public static Universidad operator +(Universidad g, EClases clase)
        {
            Profesor auxProfesor = (g == clase);
            Jornada auxJornada = new Jornada(clase, auxProfesor);

            foreach (Alumno alumno in g.Alumnos)
            {
                if (alumno == clase)
                {
                    auxJornada += alumno;
                }                  
            }

            if (!(auxJornada is null))
            {
                g.jornada.Add(auxJornada);
            }



            return g;
        }
        public static Universidad operator +(Universidad u, Alumno a)
        {
            if (u != a)
            {
                u.alumnos.Add(a);

            }
            else
            {
                throw new AlumnoRepetidoException("El alumno ya fue agregado");
            }

            return u;
        }
        public static Universidad operator +(Universidad u, Profesor i)
        {
            if (u != i)
            {

                u.profesores.Add(i);
            }

            return u;
        }
        /// <summary>
        /// Un Universidad será igual a un Alumno si el mismo está inscripto en él.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator ==(Universidad g, Alumno a)
        {
            foreach (Alumno item in g.alumnos)
            {
                if (item == a)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Un Universidad será igual a un Profesor si el mismo está dando clases en él.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static bool operator ==(Universidad g, Profesor i)
        {
            foreach (var item in g.jornada)
            {
                if (item.Instructor == i)
                {
                    return true;
                }
            }

            return false;
        }
        public static Profesor operator ==(Universidad u, EClases clase)
        {
            Profesor aux = null;

            foreach (Profesor item in u.Instructores)
            {
                if (item == clase)
                {
                    aux = item;
                    break;
                }
            }
            if (aux is null)
            {
                throw new SinProfesorException();
            }

            return aux;
        }

        #endregion

        #region Constructores
        public Universidad()
        {
            this.profesores = new List<Profesor>();
            this.alumnos = new List<Alumno>();
            this.jornada = new List<Jornada>();
        }
        #endregion

        #region Enumerados
        public enum EClases
        {
            Programacion,
            Laboratorio,
            Legislacion,
            SPD
        }
        #endregion

    }
}
