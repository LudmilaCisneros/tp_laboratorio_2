using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Entidades;

namespace Formularios
{
    public partial class FormLocalTiempoReal : Form
    {
        #region Atributos

        Hilo hiloFilaClientes = new Hilo(2000);
        Hilo hiloPedidosRealizados = new Hilo(4000, 6000);

        #endregion

        public FormLocalTiempoReal()
        {
            InitializeComponent();
            try
            {
                this.CargarPedidos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Button inicializador de threads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnComenzar_Click(object sender, EventArgs e)
        {
            hiloFilaClientes.EventoTiempo += Actualizar;
            hiloFilaClientes.Vivo = true;

            hiloPedidosRealizados.EventoTiempo += Atender;
            hiloPedidosRealizados.Vivo = true;
        }

        /// <summary>
        /// Metodo suscripto al evento del hiloFilaClientes
        /// </summary>
        private void Actualizar()
        {
            if (lbxEnQueue.InvokeRequired)
            {
                lbxEnQueue.BeginInvoke((MethodInvoker)delegate ()
                {
                    CargarPedidos();
                }
                );
            }
            else
            {
                CargarPedidos();
            }
        }
        /// <summary>
        /// Metodo encargado de actualizar
        /// </summary>
        private void CargarPedidos()
        {
            this.lbxEnQueue.Items.Clear();
            foreach (Cliente item in Showroom.filaClientes)
            {
                this.lbxEnQueue.Items.Add(item.MostrarVenta());
            }
        }

        /// <summary>
        /// Metodo suscripto al evento del hiloFilaClientes
        /// </summary>
        private void Atender()
        {
            if (lbxRealizados.InvokeRequired)
            {
                lbxRealizados.BeginInvoke((MethodInvoker)delegate ()
                {
                    AtendiendoClientes();
                }
                );
            }
            else
            {
                AtendiendoClientes();
            }
        }

        /// <summary>
        /// Toma el cliente de la fila y lo pasa a realizados en un tiempo random
        /// </summary>
        private void AtendiendoClientes()
        {
            if (Showroom.filaClientes.Count > 0 && Showroom.filaClientes.Count > 0)
            {
                Showroom.ventasRealizadas.Add(Showroom.filaClientes[0]);
                lbxRealizados.Items.Add(Showroom.filaClientes[0].MostrarVentaRealizada());
                Showroom.filaClientes.RemoveAt(0);
            }
            else
            {
                MessageBox.Show("Ya no quedan más clientes.","Aviso");
                hiloPedidosRealizados.Vivo = false;
            }

        }

        /// <summary>
        /// Al presionar el button te lleva al menu principal del programa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
        }


        /// <summary>
        /// Antes de cerrar el form, aborta los hilos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormLocalTiempoReal_FormClosing(object sender, FormClosingEventArgs e)
        {
            hiloFilaClientes.Vivo = false;
            hiloPedidosRealizados.Vivo = false;
        }
    }
}

