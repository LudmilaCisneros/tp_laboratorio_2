using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    
    public sealed class Cliente
    {
        #region Atributos

        private string nombre;
        public List<Producto> carritoCliente;
        private EFormaDePago formaDePago;

        #endregion

        #region Enumerado

        public enum EFormaDePago
        {
            efectivo,
            crédito,
            débito
        }
        #endregion

        #region Constructores
        public Cliente()
        {
            carritoCliente = new List<Producto>();          
        }


        public Cliente(List<Producto> carritoCliente) : this()
        {
            this.carritoCliente.AddRange(carritoCliente);
        }
        public Cliente(List<Producto> carritoCliente, string nombre) : this(carritoCliente)
        {
            this.nombre = nombre;
        }

        #endregion

        #region Propiedades

        /// <summary>
        /// Propiedad Nombre
        /// </summary>
        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }

        public EFormaDePago FormaDePago
        {
            get
            {
                return this.formaDePago;
            }
            set
            {
                this.formaDePago = value;
            }
        }
        #endregion

        #region Métodos

        /// <summary>
        /// Recibe el codigo del producto y lo quita del carrito
        /// </summary>
        /// <param name="codigoProducto"></param>
        public void EliminarProductoCarrito(int codigoProducto)
        {
            for (int i = 0; i < this.carritoCliente.Count; i++)
            {
                if (this.carritoCliente[i].Codigo == codigoProducto)
                {
                    this.carritoCliente.RemoveAt(i);
                }
            }
        }

        /// <summary>
        /// Devuelve el nombre a mostrar
        /// </summary>
        /// <returns></returns>
        public string MostrarVenta()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat($"::.☒ CLIENTE: {this.Nombre}");

            return sb.ToString();
        }

        /// <summary>
        /// Devuelve el nombre a mostrar
        /// </summary>
        /// <returns></returns>
        public string MostrarVentaRealizada()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat($"::.✔ CLIENTE: {this.Nombre}");

            return sb.ToString();
        }
        public static string ObtenerNombreCte(string itemSeleccionado)
        {
            return itemSeleccionado.Substring(13);
        }
        #endregion

    }
}
