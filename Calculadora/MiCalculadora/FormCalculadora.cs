using System;
using System.Drawing;
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
            this.ModoDia();
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

            string resultado = Operar(num1, num2, operador).ToString();

            lblResultado.Text 
                = (operador == "/" && resultado == double.MinValue.ToString())
                ? "No se puede dividir por 0" 
                : resultado;

            double numero;
            if (double.TryParse(num1, out numero) && double.TryParse(num2, out numero))
            {
                operador = string.IsNullOrWhiteSpace(operador) ? "+" : operador;
                lstResultados.AppendText($"{num1} {operador} {num2} = {resultado}\n");
            }

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
            string decimalNum = lblResultado.Text;
            lblResultado.Text = new Operando().DecimalBinario(decimalNum);

            SwitchearBotones(false);
        }

        /// <summary>
        /// Convierte a decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            string binariolNum = lblResultado.Text;
            lblResultado.Text = new Operando().BinarioDecimal(binariolNum);

            SwitchearBotones(true);

        }

        /// <summary>
        /// Reinicia los parametros de la calculadora
        /// </summary>
        private void Limpiar()
        {
            this.textNumero1.Clear();
            this.textNumero2.Clear();
            this.lblResultado.Text = String.Empty;
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
            this.btnConvertirABinario.Enabled = status;
            this.btnConvertirADecimal.Enabled = !status;
        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModoNoche()
        {
            archivoToolStripMenuItem.ForeColor = Color.White;
            lblResultado.ForeColor = Color.Snow;
            pictureBoxSol.Visible = true;
            pictureBoxLuna.Visible = false;
            Image fondo = Image.FromFile(@"..\..\..\..\img\noche.jpg");
            this.BackgroundImage = fondo;
            this.btnOperar.BackColor = Color.MidnightBlue;
            this.btnLimpiar.BackColor = Color.MidnightBlue;
            this.btnCerrar.BackColor = Color.MidnightBlue;
            this.btnConvertirABinario.BackColor = Color.MidnightBlue;
            this.btnConvertirADecimal.BackColor = Color.MidnightBlue;
        }

        private void ModoDia()
        {
            archivoToolStripMenuItem.ForeColor = Color.White;
            lblResultado.ForeColor = Color.Snow;
            pictureBoxSol.Visible = false;
            pictureBoxLuna.Visible = true;
            Image fondo = Image.FromFile(@"..\..\..\..\img\dia.jpg");
            this.BackgroundImage = fondo;
            this.btnOperar.BackColor = Color.YellowGreen;
            this.btnLimpiar.BackColor = Color.YellowGreen;
            this.btnCerrar.BackColor = Color.YellowGreen;
            this.btnConvertirABinario.BackColor = Color.YellowGreen;
            this.btnConvertirADecimal.BackColor = Color.YellowGreen;
        }

        private void pictureBoxLuna_Click(object sender, EventArgs e)
        {
            ModoNoche();
        }

        private void pictureBoxSol_Click(object sender, EventArgs e)
        {
            ModoDia();
        }
    }
}
