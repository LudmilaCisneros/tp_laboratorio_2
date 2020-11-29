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
using Excepciones;

namespace Formularios
{
    public partial class FormVerProductos : Form
    {
        public FormVerProductos()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Close();
        }

        private void FormVerProductos_Load(object sender, EventArgs e)
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
    }
}
