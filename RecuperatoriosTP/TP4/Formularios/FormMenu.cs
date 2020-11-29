using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Formularios
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            Showroom.ObtenerVentasXml();
        }

        private void btnNuevaCompra_Click(object sender, EventArgs e)
        {
            FormNuevaCompra formNuevaCompra = new FormNuevaCompra();
            formNuevaCompra.Show();
            this.Hide();
        }

        private void btnVerProductos_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormVerProductos formVerProductos = new FormVerProductos();
            formVerProductos.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void btnLocalTiempoReal_Click(object sender, EventArgs e)
        {
            FormLocalTiempoReal formLocalTiempoReal = new FormLocalTiempoReal();
            formLocalTiempoReal.Show();
            this.Hide();
        }
    }
}
