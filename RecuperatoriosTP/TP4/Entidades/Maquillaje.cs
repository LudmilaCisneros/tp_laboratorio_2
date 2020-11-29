using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public sealed class Maquillaje : Producto
    {

        #region Atributos

        private string subTipo;

        #endregion

        #region Propiedades
        public string SubTipo { get { return this.subTipo; } set { this.subTipo = value; } }

        #endregion

        #region Constructores

        public Maquillaje()
        {

        }
        public Maquillaje(string nombre, EColor color, float precio, int codigo, ETipo tipo, int stock)
            : base(nombre, color, precio, codigo, tipo, stock)
        {
            
        }
        public Maquillaje(string nombre, EColor color, float precio, int codigo, ETipo tipo, int stock, string subTipo)
            : base(nombre, color, precio, codigo, tipo, stock)
        {
            this.subTipo = subTipo;
        }
        #endregion


    }
}