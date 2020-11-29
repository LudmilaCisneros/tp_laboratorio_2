using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ShowroomExt
    {
        #region Métodos

        /// <summary>
        /// Aumenta 1 el stock del local
        /// </summary>
        /// <param name="i"></param>
        public static void Aumentar1Stock(int i)
        {
            int stock = 0;
            stock = Showroom.listaStockProductos[i].Stock;
            Showroom.listaStockProductos[i].Stock = stock + 1;
        }

        /// <summary>
        /// Resta 1 al stock del local
        /// </summary>
        /// <param name="i"></param>
        public static void Restar1Stock(int i)
        {
            int stock;
            stock = Showroom.listaStockProductos[i].Stock;
            Showroom.listaStockProductos[i].Stock = stock-1;
        }
        #endregion
    }
}
