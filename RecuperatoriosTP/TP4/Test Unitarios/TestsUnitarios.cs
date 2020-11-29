using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System.Collections.Generic;

namespace Test_Unitarios
{
    [TestClass]
    public class TestsUnitarios
    {
        /// <summary>
        /// Comprueba que el nombre sea correcto
        /// </summary>
        [TestMethod]
        public void Test_InstanciarCorrectamenteAcc()
        {
            Accesorios pulsera = new Accesorios("sarasa", Producto.EColor.violeta, 50, 1, Producto.ETipo.accesorios, 10, "plastico");

            Assert.AreEqual("sarasa", pulsera.Nombre);
        }

        /// <summary>
        /// Comprueba si hay stock del producto
        /// </summary>
        [DataRow(-1)]
        [DataRow(-5)]
        [DataRow(-10)]
        [TestMethod]
        public void Test_VerificarStock(int stock)
        {
            Assert.IsFalse(Producto.VerificarStock(stock));
        }

        /// <summary>
        /// checkea que se obtenga el nombre correcto
        /// </summary>
        [TestMethod]
        public void Test_ObtenerNombreCte()
        {
            string aux = "::. CLIENTE: Ludmila";

            Assert.AreEqual("Ludmila", Cliente.ObtenerNombreCte(aux));
        }


    }
}
