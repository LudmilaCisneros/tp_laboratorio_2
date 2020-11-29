using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Excepciones;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        public bool Leer(string pathArchivo, out string datos)
        {
            try
            {
                if (File.Exists(pathArchivo))
                {
                    using (StreamReader sr = new StreamReader(pathArchivo))
                    {
                        datos = sr.ReadToEnd();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ArchivosException(ex);
            }

            datos = default;
            return false;
        }
        public bool Guardar(string archivo, string datos)
        {
            bool pudoGuardar = false;

            try
            {
                if (archivo != null)
                {
                    using (StreamWriter sw = new StreamWriter(archivo))
                    {
                        sw.WriteLine(datos);
                        pudoGuardar = true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ArchivosException(ex);
            }

            return pudoGuardar;
        }
    }
}