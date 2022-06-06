
namespace WinFormsApp
{
    partial class FormInscripcion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelCalle = new System.Windows.Forms.Label();
            this.labelNumero = new System.Windows.Forms.Label();
            this.labelPiso = new System.Windows.Forms.Label();
            this.labelDpto = new System.Windows.Forms.Label();
            this.labelCP = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxCalle = new System.Windows.Forms.TextBox();
            this.textBoxNumeroDir = new System.Windows.Forms.TextBox();
            this.textBoxPiso = new System.Windows.Forms.TextBox();
            this.textBoxDpto = new System.Windows.Forms.TextBox();
            this.textBoxCP = new System.Windows.Forms.TextBox();
            this.labelFechaNac = new System.Windows.Forms.Label();
            this.labelProvincia = new System.Windows.Forms.Label();
            this.comboBoxProv = new System.Windows.Forms.ComboBox();
            this.dateTimePickerFechaNac = new System.Windows.Forms.DateTimePicker();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.textBoxCaracteristica = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.labelEMail = new System.Windows.Forms.Label();
            this.textBoxEMail = new System.Windows.Forms.TextBox();
            this.textBoxEMailR = new System.Windows.Forms.TextBox();
            this.labelEmailR = new System.Windows.Forms.Label();
            this.labelLocalidad = new System.Windows.Forms.Label();
            this.textBoxLocalidad = new System.Windows.Forms.TextBox();
            this.labelDNI = new System.Windows.Forms.Label();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.checkBoxEsAdmin = new System.Windows.Forms.CheckBox();
            this.labelMayordeEdad = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxPass2 = new System.Windows.Forms.TextBox();
            this.labelPass2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(62, 40);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(84, 15);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre:          ";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(62, 74);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(84, 15);
            this.labelApellido.TabIndex = 1;
            this.labelApellido.Text = "Apellido:          ";
            // 
            // labelCalle
            // 
            this.labelCalle.AutoSize = true;
            this.labelCalle.Location = new System.Drawing.Point(62, 245);
            this.labelCalle.Name = "labelCalle";
            this.labelCalle.Size = new System.Drawing.Size(84, 15);
            this.labelCalle.TabIndex = 2;
            this.labelCalle.Text = "Calle:                ";
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(62, 279);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(84, 15);
            this.labelNumero.TabIndex = 3;
            this.labelNumero.Text = "Número:          ";
            // 
            // labelPiso
            // 
            this.labelPiso.AutoSize = true;
            this.labelPiso.Location = new System.Drawing.Point(247, 279);
            this.labelPiso.Name = "labelPiso";
            this.labelPiso.Size = new System.Drawing.Size(32, 15);
            this.labelPiso.TabIndex = 4;
            this.labelPiso.Text = "Piso:";
            // 
            // labelDpto
            // 
            this.labelDpto.AutoSize = true;
            this.labelDpto.Location = new System.Drawing.Point(367, 279);
            this.labelDpto.Name = "labelDpto";
            this.labelDpto.Size = new System.Drawing.Size(86, 15);
            this.labelDpto.TabIndex = 5;
            this.labelDpto.Text = "Departamento:";
            // 
            // labelCP
            // 
            this.labelCP.AutoSize = true;
            this.labelCP.Location = new System.Drawing.Point(367, 314);
            this.labelCP.Name = "labelCP";
            this.labelCP.Size = new System.Drawing.Size(84, 15);
            this.labelCP.TabIndex = 6;
            this.labelCP.Text = "Codigo postal:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(164, 37);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(216, 23);
            this.textBoxNombre.TabIndex = 7;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(164, 71);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(216, 23);
            this.textBoxApellido.TabIndex = 8;
            // 
            // textBoxCalle
            // 
            this.textBoxCalle.Location = new System.Drawing.Point(164, 242);
            this.textBoxCalle.Name = "textBoxCalle";
            this.textBoxCalle.Size = new System.Drawing.Size(370, 23);
            this.textBoxCalle.TabIndex = 9;
            // 
            // textBoxNumeroDir
            // 
            this.textBoxNumeroDir.Location = new System.Drawing.Point(164, 276);
            this.textBoxNumeroDir.Name = "textBoxNumeroDir";
            this.textBoxNumeroDir.Size = new System.Drawing.Size(67, 23);
            this.textBoxNumeroDir.TabIndex = 10;
            // 
            // textBoxPiso
            // 
            this.textBoxPiso.Location = new System.Drawing.Point(297, 276);
            this.textBoxPiso.Name = "textBoxPiso";
            this.textBoxPiso.Size = new System.Drawing.Size(52, 23);
            this.textBoxPiso.TabIndex = 11;
            // 
            // textBoxDpto
            // 
            this.textBoxDpto.Location = new System.Drawing.Point(470, 276);
            this.textBoxDpto.Name = "textBoxDpto";
            this.textBoxDpto.Size = new System.Drawing.Size(64, 23);
            this.textBoxDpto.TabIndex = 12;
            // 
            // textBoxCP
            // 
            this.textBoxCP.Location = new System.Drawing.Point(470, 310);
            this.textBoxCP.Name = "textBoxCP";
            this.textBoxCP.Size = new System.Drawing.Size(64, 23);
            this.textBoxCP.TabIndex = 13;
            // 
            // labelFechaNac
            // 
            this.labelFechaNac.AutoSize = true;
            this.labelFechaNac.Location = new System.Drawing.Point(414, 182);
            this.labelFechaNac.Name = "labelFechaNac";
            this.labelFechaNac.Size = new System.Drawing.Size(120, 15);
            this.labelFechaNac.TabIndex = 14;
            this.labelFechaNac.Text = "Fecha de nacimiento:";
            // 
            // labelProvincia
            // 
            this.labelProvincia.AutoSize = true;
            this.labelProvincia.Location = new System.Drawing.Point(62, 348);
            this.labelProvincia.Name = "labelProvincia";
            this.labelProvincia.Size = new System.Drawing.Size(86, 15);
            this.labelProvincia.TabIndex = 15;
            this.labelProvincia.Text = "Provincia:         ";
            // 
            // comboBoxProv
            // 
            this.comboBoxProv.FormattingEnabled = true;
            this.comboBoxProv.Location = new System.Drawing.Point(164, 345);
            this.comboBoxProv.Name = "comboBoxProv";
            this.comboBoxProv.Size = new System.Drawing.Size(287, 23);
            this.comboBoxProv.TabIndex = 16;
            // 
            // dateTimePickerFechaNac
            // 
            this.dateTimePickerFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaNac.Location = new System.Drawing.Point(414, 208);
            this.dateTimePickerFechaNac.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerFechaNac.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerFechaNac.Name = "dateTimePickerFechaNac";
            this.dateTimePickerFechaNac.Size = new System.Drawing.Size(120, 23);
            this.dateTimePickerFechaNac.TabIndex = 17;
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(62, 108);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(82, 15);
            this.labelTelefono.TabIndex = 18;
            this.labelTelefono.Text = "Teléfono:         ";
            // 
            // textBoxCaracteristica
            // 
            this.textBoxCaracteristica.Location = new System.Drawing.Point(164, 105);
            this.textBoxCaracteristica.Name = "textBoxCaracteristica";
            this.textBoxCaracteristica.Size = new System.Drawing.Size(41, 23);
            this.textBoxCaracteristica.TabIndex = 19;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(211, 105);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(169, 23);
            this.textBoxTelefono.TabIndex = 20;
            // 
            // labelEMail
            // 
            this.labelEMail.AutoSize = true;
            this.labelEMail.Location = new System.Drawing.Point(62, 143);
            this.labelEMail.Name = "labelEMail";
            this.labelEMail.Size = new System.Drawing.Size(83, 15);
            this.labelEMail.TabIndex = 21;
            this.labelEMail.Text = "E-mail:             ";
            // 
            // textBoxEMail
            // 
            this.textBoxEMail.Location = new System.Drawing.Point(164, 140);
            this.textBoxEMail.Name = "textBoxEMail";
            this.textBoxEMail.Size = new System.Drawing.Size(216, 23);
            this.textBoxEMail.TabIndex = 22;
            // 
            // textBoxEMailR
            // 
            this.textBoxEMailR.Location = new System.Drawing.Point(164, 174);
            this.textBoxEMailR.Name = "textBoxEMailR";
            this.textBoxEMailR.Size = new System.Drawing.Size(216, 23);
            this.textBoxEMailR.TabIndex = 23;
            // 
            // labelEmailR
            // 
            this.labelEmailR.AutoSize = true;
            this.labelEmailR.Location = new System.Drawing.Point(62, 177);
            this.labelEmailR.Name = "labelEmailR";
            this.labelEmailR.Size = new System.Drawing.Size(84, 15);
            this.labelEmailR.TabIndex = 24;
            this.labelEmailR.Text = "Repetir E-mail:";
            // 
            // labelLocalidad
            // 
            this.labelLocalidad.AutoSize = true;
            this.labelLocalidad.Location = new System.Drawing.Point(62, 314);
            this.labelLocalidad.Name = "labelLocalidad";
            this.labelLocalidad.Size = new System.Drawing.Size(85, 15);
            this.labelLocalidad.TabIndex = 25;
            this.labelLocalidad.Text = "Localidad:        ";
            // 
            // textBoxLocalidad
            // 
            this.textBoxLocalidad.Location = new System.Drawing.Point(164, 311);
            this.textBoxLocalidad.Name = "textBoxLocalidad";
            this.textBoxLocalidad.Size = new System.Drawing.Size(185, 23);
            this.textBoxLocalidad.TabIndex = 26;
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.Location = new System.Drawing.Point(62, 211);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(84, 15);
            this.labelDNI.TabIndex = 27;
            this.labelDNI.Text = "DNI:                  ";
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(164, 208);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(216, 23);
            this.textBoxDNI.TabIndex = 28;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.IndianRed;
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmar.Location = new System.Drawing.Point(611, 290);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(86, 54);
            this.btnConfirmar.TabIndex = 29;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Orange;
            this.btnVolver.ForeColor = System.Drawing.Color.DimGray;
            this.btnVolver.Location = new System.Drawing.Point(690, 1);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(87, 25);
            this.btnVolver.TabIndex = 30;
            this.btnVolver.Text = "<- Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // checkBoxEsAdmin
            // 
            this.checkBoxEsAdmin.AutoSize = true;
            this.checkBoxEsAdmin.Location = new System.Drawing.Point(472, 347);
            this.checkBoxEsAdmin.Name = "checkBoxEsAdmin";
            this.checkBoxEsAdmin.Size = new System.Drawing.Size(62, 19);
            this.checkBoxEsAdmin.TabIndex = 32;
            this.checkBoxEsAdmin.Text = "Admin";
            this.checkBoxEsAdmin.UseVisualStyleBackColor = true;
            this.checkBoxEsAdmin.Visible = false;
            // 
            // labelMayordeEdad
            // 
            this.labelMayordeEdad.AutoSize = true;
            this.labelMayordeEdad.ForeColor = System.Drawing.Color.Red;
            this.labelMayordeEdad.Location = new System.Drawing.Point(540, 211);
            this.labelMayordeEdad.Name = "labelMayordeEdad";
            this.labelMayordeEdad.Size = new System.Drawing.Size(190, 15);
            this.labelMayordeEdad.TabIndex = 33;
            this.labelMayordeEdad.Text = "ERROR: Debe ser mayor de 18 años";
            this.labelMayordeEdad.Visible = false;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(414, 45);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(70, 15);
            this.labelPass.TabIndex = 34;
            this.labelPass.Text = "Contraseña:";
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(414, 71);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(120, 23);
            this.textBoxPass.TabIndex = 35;
            // 
            // textBoxPass2
            // 
            this.textBoxPass2.Location = new System.Drawing.Point(414, 140);
            this.textBoxPass2.Name = "textBoxPass2";
            this.textBoxPass2.PasswordChar = '*';
            this.textBoxPass2.Size = new System.Drawing.Size(120, 23);
            this.textBoxPass2.TabIndex = 37;
            // 
            // labelPass2
            // 
            this.labelPass2.AutoSize = true;
            this.labelPass2.Location = new System.Drawing.Point(414, 114);
            this.labelPass2.Name = "labelPass2";
            this.labelPass2.Size = new System.Drawing.Size(110, 15);
            this.labelPass2.TabIndex = 36;
            this.labelPass2.Text = "Repetir Contraseña:";
            // 
            // FormInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinFormsApp.Properties.Resources.Check_in;
            this.ClientSize = new System.Drawing.Size(778, 401);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxPass2);
            this.Controls.Add(this.labelPass2);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelMayordeEdad);
            this.Controls.Add(this.checkBoxEsAdmin);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.textBoxDNI);
            this.Controls.Add(this.labelDNI);
            this.Controls.Add(this.textBoxLocalidad);
            this.Controls.Add(this.labelLocalidad);
            this.Controls.Add(this.labelEmailR);
            this.Controls.Add(this.textBoxEMailR);
            this.Controls.Add(this.textBoxEMail);
            this.Controls.Add(this.labelEMail);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.textBoxCaracteristica);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.dateTimePickerFechaNac);
            this.Controls.Add(this.comboBoxProv);
            this.Controls.Add(this.labelProvincia);
            this.Controls.Add(this.labelFechaNac);
            this.Controls.Add(this.textBoxCP);
            this.Controls.Add(this.textBoxDpto);
            this.Controls.Add(this.textBoxPiso);
            this.Controls.Add(this.textBoxNumeroDir);
            this.Controls.Add(this.textBoxCalle);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelCP);
            this.Controls.Add(this.labelDpto);
            this.Controls.Add(this.labelPiso);
            this.Controls.Add(this.labelNumero);
            this.Controls.Add(this.labelCalle);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInscripcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "On Boarding";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelCalle;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.Label labelPiso;
        private System.Windows.Forms.Label labelDpto;
        private System.Windows.Forms.Label labelCP;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxCalle;
        private System.Windows.Forms.TextBox textBoxNumeroDir;
        private System.Windows.Forms.TextBox textBoxPiso;
        private System.Windows.Forms.TextBox textBoxDpto;
        private System.Windows.Forms.TextBox textBoxCP;
        private System.Windows.Forms.Label labelFechaNac;
        private System.Windows.Forms.Label labelProvincia;
        private System.Windows.Forms.ComboBox comboBoxProv;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaNac;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.TextBox textBoxCaracteristica;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label labelEMail;
        private System.Windows.Forms.TextBox textBoxEMail;
        private System.Windows.Forms.TextBox textBoxEMailR;
        private System.Windows.Forms.Label labelEmailR;
        private System.Windows.Forms.Label labelLocalidad;
        private System.Windows.Forms.TextBox textBoxLocalidad;
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.CheckBox checkBoxEsAdmin;
        private System.Windows.Forms.Label labelMayordeEdad;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxPass2;
        private System.Windows.Forms.Label labelPass2;
    }
}