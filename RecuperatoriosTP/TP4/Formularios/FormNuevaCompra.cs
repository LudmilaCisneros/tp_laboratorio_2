using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using Entidades;
using Excepciones;


namespace Formularios
{
    public partial class FormNuevaCompra : Form
    {
        #region Atributos

        private Cliente miCliente;

        #endregion

        #region Constructor
        public FormNuevaCompra()
        {
            InitializeComponent();
            miCliente = new Cliente();
        }
        #endregion

        private void FormNuevaCompra_Load(object sender, EventArgs e)
        {
            try
            {
                if (Showroom.listaStockProductos.Count > 0)
                {
                    //guarda los datos de la bd en la lista de stock
                    dtgvStock.DataSource = null;
                    dtgvStock.DataSource = Showroom.listaStockProductos;
                }
                else
                {
                    DAO.ObtenerStockDeBD();
                    dtgvStock.DataSource = null;
                    dtgvStock.DataSource = Showroom.listaStockProductos;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgvStock_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvR = dtgvStock.CurrentRow;
            DataGridViewCellCollection coleccionCeldas = dgvR.Cells;

            //obtengo las cells de la row clickeada
            string nombre = coleccionCeldas[0].Value.ToString();
            float precio = float.Parse(coleccionCeldas[1].Value.ToString());
            string color = coleccionCeldas[2].Value.ToString();
            int stock = int.Parse(coleccionCeldas[3].Value.ToString());
            string tipo = coleccionCeldas[4].Value.ToString();
            int codigo = int.Parse(coleccionCeldas[5].Value.ToString());
            int i;

            int cantDelProducto;

            if (Producto.VerificarStock(stock))
            {
                if (int.TryParse(txtBoxCant.Text.ToString(), out cantDelProducto))
                {

                    i = Showroom.EncontrarIndexEnLista(codigo);
                    if (i != -1)
                    {
                        for (int j = 0; j < cantDelProducto; j++)
                        {
                            ShowroomExt.Restar1Stock(i);
                        }

                        switch (tipo)
                        {
                            case "accesorios":
                                miCliente.carritoCliente.Add(new Accesorios(nombre,
                                                                            (Producto.EColor)Enum.Parse(typeof(Producto.EColor), color),
                                                                            precio,
                                                                            codigo,
                                                                            (Producto.ETipo)Enum.Parse(typeof(Producto.ETipo), tipo),
                                                                            cantDelProducto));
                                                                            break;
                            case "maquillaje":
                                miCliente.carritoCliente.Add(new Maquillaje(nombre,
                                                                            (Producto.EColor)Enum.Parse(typeof(Producto.EColor), color),
                                                                            precio,
                                                                            codigo,
                                                                            (Producto.ETipo)Enum.Parse(typeof(Producto.ETipo), tipo),
                                                                            cantDelProducto));
                                                                            break;

                        }
                        ActualizarDtgv();
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese la cant del producto", "Error");
                }
            }
        }

        /// <summary>
        /// Actualiza los dtgv del formulario
        /// </summary>
        private void ActualizarDtgv()
        {
            dtgvStock.DataSource = null;
            dtgvStock.DataSource = Showroom.listaStockProductos;
            dtgvCarrito.DataSource = null;
            dtgvCarrito.DataSource = miCliente.carritoCliente;
        }

        /// <summary>
        /// Al presionar doble click en algún articulo del carrito lo eliminará
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtgvCarrito_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvR = dtgvCarrito.CurrentRow;
            DataGridViewCellCollection coleccionCeldas = dgvR.Cells;

            //obtengo las cells de la row clickeada
            int stock = int.Parse(coleccionCeldas[3].Value.ToString());
            int codigo = int.Parse(coleccionCeldas[5].Value.ToString());
            int index;

            index = Showroom.EncontrarIndexEnLista(codigo);
            for (int j = 0; j < stock; j++)
            {
                ShowroomExt.Aumentar1Stock(index);
            }
            miCliente.EliminarProductoCarrito(codigo);
            ActualizarDtgv();
        }

        /// <summary>
        /// Cancela la operación y volveremos al menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
        }

        /// <summary>
        /// Se Procederá a pedir los datos restantes para concretar la venta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRealizarPedido_Click(object sender, EventArgs e)
        {
            miCliente.CalcularTotalCarrito();
            FormDatosCompra formDatosCompra = new FormDatosCompra(miCliente);
            formDatosCompra.Show();
            this.Close();
        }

    }
}

