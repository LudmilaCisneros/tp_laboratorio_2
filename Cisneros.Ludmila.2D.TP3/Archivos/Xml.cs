using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;


namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        /// <summary>
        /// Implementación del método de la interface IArchivos
        /// que serializa datos en formato XML.
        /// Caso contrario, lanzará la excepción: ArchivosException().
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Guardar(string archivo, T datos)
        {
            try
            {
                using (XmlTextWriter xTW = new XmlTextWriter(archivo, Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    ser.Serialize(xTW, datos);
                    return true;
                }
                
            }
            catch (Exception ex)
            {
                throw new ArchivosException(ex);
            }
            
        }

        /// <summary>
        /// Implementación del método de la interface IArchivos
        /// que deserializa datos en formato XML.
        /// Caso contrario, lanzará la excepción: ArchivosException().
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Leer(string archivo, out T datos)
        {
            try
            {
                using (XmlTextReader reader = new XmlTextReader(archivo))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    datos = (T)ser.Deserialize(reader);
                    return true;
                }
                
            }
            catch (Exception ex)
            {
                throw new ArchivosException(ex);
            }
            
        }
    }
}
