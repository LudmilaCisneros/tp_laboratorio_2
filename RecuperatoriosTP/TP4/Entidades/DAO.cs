using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Archivos;

namespace Entidades
{
    public static class DAO
    {
        #region Atributos

        static SqlConnection conexion;

        #endregion

        #region Constructor
        static DAO()
        {
            conexion = new SqlConnection(ObtenerConnectionString());
        }
        #endregion

        #region Métodos

        /// <summary>
        /// Obtiene la connectionString del archivo "ConnectionString.txt"
        /// </summary>
        /// <returns></returns>
        public static string ObtenerConnectionString()
        {
            Texto auxTxt = new Texto();
            string path = AppDomain.CurrentDomain.BaseDirectory + "ConnectionString.txt";
            string datos;
            auxTxt.Leer(path, out datos);

            return datos;
        }

        /// <summary>
        /// Lanza una query (SELECT) a la base de datos, y guarda la tabla de stock en la lista de stock
        /// </summary>
        /// <returns></returns>
        public static List<Producto> ObtenerStockDeBD()
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT * FROM Stock";
                conexion.Open();//conecta al server
                SqlDataReader dato = comando.ExecuteReader();//devuelve el resultado de la query

                while (dato.Read())
                {
                    switch (dato["Tipo"].ToString())
                    {
                        //Accesorios
                        case "accesorios":
                            Showroom.listaStockProductos.Add(new Accesorios(dato["Nombre"].ToString(),
                            (Producto.EColor)Enum.Parse(typeof(Producto.EColor), dato["Color"].ToString()),
                            float.Parse(dato["Precio"].ToString()),
                            int.Parse(dato["Código"].ToString()),
                            (Producto.ETipo)Enum.Parse(typeof(Producto.ETipo), dato["Tipo"].ToString()),
                            int.Parse(dato["Stock"].ToString()),
                            dato["Subtipo"].ToString()));
                            break;


                        case "maquillaje":
                            Showroom.listaStockProductos.Add(new Maquillaje(dato["Nombre"].ToString(),
                            (Producto.EColor)Enum.Parse(typeof(Producto.EColor), dato["Color"].ToString()),
                            float.Parse(dato["Precio"].ToString()),
                            int.Parse(dato["Código"].ToString()),
                            (Producto.ETipo)Enum.Parse(typeof(Producto.ETipo), dato["Tipo"].ToString()),
                            int.Parse(dato["Stock"].ToString()),
                            dato["Subtipo"].ToString()));
                            break;
                    }
                }
                conexion.Close();
            }
            catch (Exception ex)
            {
                throw new ErrorBDException("Error en la base de datos",ex);
            }

            return Showroom.listaStockProductos;
        }

        #endregion

    }
}
