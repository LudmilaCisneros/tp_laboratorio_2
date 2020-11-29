using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Threading.Tasks;
using Excepciones;

namespace Archivos
{

    public class Xml<T> : IArchivo<T>
    {
        /// <summary>
        /// Serializa datos en formato XML.
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Guardar(string archivo, T datos)
        {
            if (archivo != null)
            {
                try
                {
                    using (XmlTextWriter xTW = new XmlTextWriter(archivo, Encoding.UTF8))
                    {
                        XmlSerializer xs = new XmlSerializer(typeof(T));

                        xs.Serialize(xTW, datos);
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    throw new ArchivosException(ex);
                }
            }

            return false;

        }


        /// <summary>
        /// Deserializa datos en formato XML.
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Leer(string archivo, out T datos)
        {
            if (File.Exists(archivo))
            {
                try
                {
                    using (XmlTextReader xmlR = new XmlTextReader(archivo))
                    {
                        XmlSerializer xs = new XmlSerializer(typeof(T));
                        datos = (T)xs.Deserialize(xmlR);
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    throw new ArchivosException(ex);
                }
            }

            datos = default;
            return false;

        }

    }
}