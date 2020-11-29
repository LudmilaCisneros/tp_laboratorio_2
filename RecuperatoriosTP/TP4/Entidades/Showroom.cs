using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;

namespace Entidades
{
    public static class Showroom
    {
        #region Atributos

        public static List<Producto> listaStockProductos;
        public static List<Cliente> filaClientes;
        public static List<Cliente> ventasRealizadas;

        #endregion

        #region Constructor
        static Showroom()
        {
            listaStockProductos = new List<Producto>();
            filaClientes = new List<Cliente>();
            ventasRealizadas = new List<Cliente>();
        }

        #endregion

        #region Métodos
        public static int EncontrarIndexEnLista(int codigo)
        {
            int index = -1;

            for (int i = 0; i < listaStockProductos.Count; i++)
            {
                if (listaStockProductos[i].Codigo == codigo)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        /// <summary>
        /// Guarda el listado de ventas en archivo XML
        /// </summary>
        /// <param name="inv"></param>
        /// <returns>true si lo guardo, false caso contrario</returns>
        public static bool GuardarVentasXml(List<Cliente> ventas)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "Ventas.xml";
            Xml<List<Cliente>> auxXML = new Xml<List<Cliente>>();

            return auxXML.Guardar(path, ventas);
        }

        /// <summary>
        /// Lee el listado de ventas guardado en un archivo XML
        /// </summary>
        /// <returns>bool true si se pude deserializar, false si no<Venta></returns>
        public static bool ObtenerVentasXml()
        {
            List<Cliente> datos = new List<Cliente>();
            string path = AppDomain.CurrentDomain.BaseDirectory + "Ventas.xml";
            Xml<List<Cliente>> auxXML = new Xml<List<Cliente>>();

            auxXML.Leer(path, out datos);

            if (datos != null)
            {
                filaClientes = datos;
                return true;
            }
            return false;
        }
        public static int BuscarClientePorNombre(string nombre)
        {
            for (int i = 0; i < filaClientes.Count; i++)
            {
                if (filaClientes[i].Nombre == nombre)
                {
                    return i;
                }

            }
            return -1;
        }

        #endregion
    }
}
