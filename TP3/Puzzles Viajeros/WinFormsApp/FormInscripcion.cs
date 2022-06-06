using Entidades;
using Entidades.clases;
using Entidades.enums;
using Entidades.excepciones;
using System;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class FormInscripcion : Form
    {
        Puzzleteca puzzleteca;
        public FormInscripcion(Puzzleteca puzzleteca, bool admin)
        {
            InitializeComponent();
            this.checkBoxEsAdmin.Visible = admin;
            this.puzzleteca = puzzleteca;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(puzzleteca);
            mainForm.ShowDialog();
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                Persona miembro = CargarPersona();
                puzzleteca.Usuarios.Add(miembro);
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            } 
            catch (NullReferenceException ne)
            {
                Console.WriteLine(ne.Message);
            }
            catch (EmailInvalidoException ee)
            {
                this.textBoxEMail.PlaceholderText = ee.Message;
            }
            catch (RepetirEmailException re)
            {
                this.textBoxEMailR.PlaceholderText = re.Message.ToString();
            }
            catch (DNIInvalidoException de)
            {
                this.textBoxDNI.PlaceholderText = de.Message.ToString();
            }
            catch(EdadInvalidaException ee)
            {
                this.labelMayordeEdad.Visible = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        public Persona CargarPersona()
        {
            Helpers.ValidarTexto(this.textBoxNombre.Text, out string nombre);
            Helpers.ValidarTexto(this.textBoxApellido.Text, out string apellido);
            string pass = this.textBoxPass.Text;
            string validar = this.textBoxPass2.Text;
            Helpers.ValidarContraseña(pass, validar);
            string mail = this.textBoxEMail.Text.ToLower();
            validar = this.textBoxEMailR.Text.ToLower();
            Helpers.ValidarEmail(mail, validar);
            string caracteristica = this.textBoxCaracteristica.Text;
            string telefono = this.textBoxTelefono.Text;
            if (int.TryParse(caracteristica, out int auxNum)
                && int.TryParse(telefono, out auxNum))
            {
                telefono = Helpers.FormatearTelefono(caracteristica, telefono);
            }
            if (int.TryParse(this.textBoxDNI.Text, out int dni) && this.textBoxDNI.Text.Length == 8) throw new DNIInvalidoException("ERROR: DNI invalido");
            Direccion direccion = CargarDireccion();
            DateTime fechaNac = dateTimePickerFechaNac.Value;
            Helpers.ValidarEdad(fechaNac);
            Persona persona = (this.checkBoxEsAdmin.Checked)
                                    ? new Admin(nombre, apellido, direccion, telefono, mail, fechaNac, dni, pass, true)
                                    : new Usuario(nombre, apellido, direccion, telefono, mail, fechaNac, dni, pass, false);
            return persona;
        }
        public Direccion CargarDireccion()
        {
            string calle = this.textBoxCalle.Text;
            string numeroStr = this.textBoxNumeroDir.Text;
            int.TryParse(numeroStr, out int numero);
            string piso = this.textBoxPiso.Text;
            string dpto = this.textBoxDpto.Text;
            string localidad = this.textBoxLocalidad.Text;
            int cp = int.Parse(this.textBoxPiso.Text);
            EProvincia provincia = (EProvincia)this.comboBoxProv.SelectedIndex;

            if(string.IsNullOrWhiteSpace(piso) || string.IsNullOrWhiteSpace(dpto))
            {
                return new Direccion(calle,numero, localidad, cp, provincia, piso, dpto);
            } else
            {
                return new Direccion(calle, numero, localidad, cp, provincia);
            }
        }
    }
}