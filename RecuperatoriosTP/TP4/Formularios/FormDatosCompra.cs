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
    public partial class FormDatosCompra : Form
    {
        Cliente miCliente;
        public FormDatosCompra(Cliente miCliente)
        {
            InitializeComponent();
            this.miCliente = miCliente;
        }
        private void FormDatosCompra_Load(object sender, EventArgs e)
        {
            cmbBxFormaDePago.Items.Add(Cliente.EFormaDePago.crédito);
            cmbBxFormaDePago.Items.Add(Cliente.EFormaDePago.débito);
            cmbBxFormaDePago.Items.Add(Cliente.EFormaDePago.efectivo);
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            string nombre = txtBxNombre.Text.ToString();
            string apellido = txtBxApellido.Text.ToString();

            try
            {

                if (!string.IsNullOrWhiteSpace(nombre) && !string.IsNullOrWhiteSpace(apellido) && cmbBxFormaDePago.SelectedItem != null)
                {
                    miCliente.Nombre = nombre + " " + apellido;
                    miCliente.FormaDePago = (Cliente.EFormaDePago)Enum.Parse(typeof(Cliente.EFormaDePago), cmbBxFormaDePago.SelectedItem.ToString());
                    Showroom.filaClientes.Add(miCliente);
                    Showroom.GuardarVentasXml(Showroom.filaClientes);
                    MessageBox.Show("Compra exitosa", "Confirmación");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Complete todos los campos");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Seleccione un medio de pago", ex);
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDatosCompra_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
        }
    }
}
