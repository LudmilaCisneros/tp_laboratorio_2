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
            double resultado = Operar(txtNumero1.Text.ToString(), txtNumero2.Text.ToString(), cmbOperador.SelectedItem.ToString());
            lblResultado.Text = resultado.ToString();
        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            Numero n1 = new Numero(double.Parse(numero1));
            Numero n2 = new Numero(double.Parse(numero2));

            return Calculadora.Operar(n1, n2, operador);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnConvertirAbinario_Click(object sender, EventArgs e)
        {
            Numero numero = new Numero();
            string numeroAux = lblResultado.Text;
            lblResultado.Text = numero.DecimalBinario(numeroAux);
        }

        private void btnConvetirADecimal_Click(object sender, EventArgs e)
        {
            Numero numero = new Numero();
            string numeroAux = lblResultado.Text;
            lblResultado.Text = numero.BinarioDecimal(numeroAux);
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
            if (!(MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                e.Cancel = true;
            }
        }
    }
}
