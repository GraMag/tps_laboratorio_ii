using Entidades;
using Entidades.clases;
using Entidades.excepciones;
using System;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class LoginForm : Form
    {
        Puzzleteca puzzleteca;

        public LoginForm(Puzzleteca puzzleteca)
        {
            InitializeComponent();
            this.puzzleteca = puzzleteca;
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = this.textBoxUser.Text;
                string password = this.textBoxPass.Text;
              //  Helpers.ValidarUsuario(puzzleteca, usuario, password);
                AdminForm adminForm = new AdminForm(puzzleteca);
                adminForm.ShowDialog();
                this.Close();
            } catch (NullReferenceException ae)
            {
                MessageBox.Show("Null", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand);
            } catch (LoginException le)
            {
                DialogResult dialogResult = MessageBox.Show(le.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand);
                if(dialogResult == DialogResult.Cancel)
                {
                    Volver();
                }
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Volver();
        }

        private void Volver()
        {
            MainForm mainForm = new MainForm(puzzleteca);
            mainForm.ShowDialog();
            this.Close();
        }
    }
}
