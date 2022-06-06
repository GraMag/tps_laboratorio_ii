using Entidades;
using System;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class MainForm : Form
    {
        Puzzleteca puzzleteca = Puzzleteca.Singleton;

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(Puzzleteca puzzleteca)
        {
            InitializeComponent();
            this.puzzleteca = puzzleteca;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.panelInicio.Visible = false;
            LoginForm loginForm = new LoginForm(puzzleteca);
            loginForm.ShowDialog();
            this.Close();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            FormInscripcion formInscripcion = new FormInscripcion(puzzleteca, false);
            formInscripcion.ShowDialog();
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Esta seguro que desea salir", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Cancel) { e.Cancel = true; }
        }
        
    }
}
