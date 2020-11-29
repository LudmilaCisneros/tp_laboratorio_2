using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using Entidades;

namespace Formularios
{
    public partial class FormMenu : Form
    {
        SoundPlayer player;
        public FormMenu()
        {
            InitializeComponent();
            Showroom.ObtenerVentasXml();
            player = new SoundPlayer("./tick.wav");
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

        private void btnVerProductos_MouseMove(object sender, MouseEventArgs e)
        {
            player.Play();
        }

        private void btnLocalTiempoReal_MouseMove(object sender, MouseEventArgs e)
        {
            player.Play();
        }

        private void btnNuevaCompra_MouseMove(object sender, MouseEventArgs e)
        {
            player.Play();
        }
    }
}
