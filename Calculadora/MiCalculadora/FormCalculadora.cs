using System;
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

        /// <summary>
        /// Carga la calculadora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// Realiza operaciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            string num1 = textNumero1.Text;
            string num2 = textNumero2.Text;
            string operador = cmbOperacion.Text;
            
            lblRessultado.Text = Operar(num1, num2, operador).ToString();

            num1 = string.IsNullOrWhiteSpace(num1) ? "0" : num1;
            num2 = string.IsNullOrWhiteSpace(num2) ? "0" : num2;
            operador = string.IsNullOrWhiteSpace(operador) ? "+" : operador;
            lstResultados.AppendText($"{num1} {operador} {num2} = {lblRessultado.Text}\n");

            SwitchearBotones(true);
        }

        /// <summary>
        /// Limpia la pantalla al tocar el botón
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// Cierra el programa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Convierte a binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            string decimalNum = lblRessultado.Text;
            lblRessultado.Text = Operando.DecimalBinario(decimalNum);

            SwitchearBotones(false);
        }

        /// <summary>
        /// Convierte a decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            string binariolNum = lblRessultado.Text;
            lblRessultado.Text = Operando.BinarioDecimal(binariolNum);

            SwitchearBotones(true);

        }

        /// <summary>
        /// Reinicia los parametros de la calculadora
        /// </summary>
        private void Limpiar()
        {
            this.textNumero1.Clear();
            this.textNumero2.Clear();
            this.lblRessultado.Text = String.Empty;
            this.cmbOperacion.SelectedIndex = 0;
            this.btnConvertirABinario.Enabled = false;
            this.btnConvertirADecimal.Enabled = false;
        }

        /// <summary>
        /// Llama a la operación
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            return Calculadora.Operar(new Operando(numero1), new Operando(numero2), operador[0]);
        }

        /// <summary>
        /// Previene que se cierre el programa pidiendo confirmacóon del usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea cerrar?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Activa y desactiva los botones de conversión
        /// </summary>
        /// <param name="status"></param>
        private void SwitchearBotones(bool status)
        {
            this.btnConvertirABinario.Enabled = status ? true  : false;
            this.btnConvertirADecimal.Enabled = status ? false : true ;
        }
    }
}
