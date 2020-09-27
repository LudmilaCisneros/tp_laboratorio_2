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

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            Numero numero1 = new Numero(txtNumero1.Text);
            Numero numero2 = new Numero(txtNumero2.Text);
            string operador = cmbOperador.Text;
            string resultadoStr = Calculadora.Operar(numero1, numero2, operador).ToString();
            lblResultado.Text = resultadoStr;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnConvertirAbinario_Click(object sender, EventArgs e)
        {
            string numeroAux = lblResultado.Text;
            lblResultado.Text = Numero.DecimalBinario(numeroAux);
        }

        private void btnConvetirADecimal_Click(object sender, EventArgs e)
        {
            string numeroAux = lblResultado.Text;
            lblResultado.Text = Numero.BinarioDecimal(numeroAux);
        }

        private void Limpiar()
        {
            lblResultado.Text = "0";
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            cmbOperador.Text = "";
        }
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro de querer salir?","Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            /*Cancelar el evento formclosing con canceleventhandler
            else
            {
                this.Closing += new CancelEventHandler();
            }*/
        }
    }
}
