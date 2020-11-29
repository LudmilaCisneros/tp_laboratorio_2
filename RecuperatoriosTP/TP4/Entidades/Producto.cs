using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    [Serializable]
    [XmlInclude(typeof(Accesorios))]
    [XmlInclude(typeof(Maquillaje))]

    public abstract class Producto
    {
        #region Atributos

        protected string nombre;
        protected int codigo;
        protected float precio;
        protected EColor color;
        protected ETipo tipo;
        protected int stock;
        #endregion

        #region Enumerados

        public enum EColor
        {
            rosa,
            nude,
            verde,
            azul,
            violeta,
            negro,
            blanco
        }
        public enum ETipo
        {
            maquillaje, accesorios
        }
        #endregion

        #region Constructores

        public Producto()
        {

        }
        public Producto(string nombre, EColor color, float precio, int codigo, ETipo tipo, int stock)
        {
            this.nombre = nombre;
            this.color = color;
            this.precio = precio;
            this.tipo = tipo;
            this.codigo = codigo;
            this.stock = stock;
        }
        #endregion

        #region Propiedades

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                if (ValidarNombre(value))
                {
                    this.nombre = value;
                }
            }
        }
        public float Precio
        {
            get { return this.precio; }
            set
            {
                if (value > 0)
                {
                    this.precio = value;
                }
            }
        }
        public EColor Color { get { return this.color; } set { this.color = value; } }
        public int Stock { get { return this.stock; } set { this.stock = value; } }
        public ETipo Tipo { get { return this.tipo; } set { this.tipo = value; } }
        public int Codigo { get { return this.codigo; } set { this.codigo = value; } }

        #endregion


        #region Métodos

        /// <summary>
        /// Checkea si hay stock
        /// </summary>
        /// <param name="stock"></param>
        /// <returns>bool</returns>
        public static bool VerificarStock(int stock)
        {
            bool hayStock;

            if (stock <= 0)
            {
                hayStock = false;
            }
            else
            {
                hayStock = true;
            }
            return hayStock;
        }
        /// <summary>
        /// Valida que el nombre tenga mas o igual que 4 letras, tambien que no sea numero
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns>true si es nombre, false si no</returns>
        public bool ValidarNombre(string nombre)
        {
            int aux;

            if (nombre.Length >= 4 && !int.TryParse(nombre, out aux))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Genera toda la info de un producto hasta el momento
        /// </summary>
        /// <returns>string con la informacion</returns>
        public virtual string GenerarInfo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"CÓDIGO: {this.Codigo}");
            sb.AppendLine($"NOMBRE: {this.Nombre}");
            sb.AppendLine($"COLOR: {this.Color}");
            sb.AppendLine($"PRECIO: {this.Precio}");


            return sb.ToString();
        }
        #endregion
    }
}