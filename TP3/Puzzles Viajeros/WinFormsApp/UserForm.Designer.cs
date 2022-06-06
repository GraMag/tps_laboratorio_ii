
namespace WinFormsApp
{
    partial class UserForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelFiltrar = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonMod = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonHistorial = new System.Windows.Forms.Button();
            this.buttonInformar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(645, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 8;
            // 
            // labelFiltrar
            // 
            this.labelFiltrar.AutoSize = true;
            this.labelFiltrar.Location = new System.Drawing.Point(599, 48);
            this.labelFiltrar.Name = "labelFiltrar";
            this.labelFiltrar.Size = new System.Drawing.Size(40, 15);
            this.labelFiltrar.TabIndex = 7;
            this.labelFiltrar.Text = "Filtrar:";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(330, 45);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 6;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(330, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(436, 315);
            this.dataGridView1.TabIndex = 5;
            // 
            // buttonMod
            // 
            this.buttonMod.Location = new System.Drawing.Point(39, 196);
            this.buttonMod.Name = "buttonMod";
            this.buttonMod.Size = new System.Drawing.Size(259, 24);
            this.buttonMod.TabIndex = 11;
            this.buttonMod.Text = "Mis proximos puzzles";
            this.buttonMod.UseVisualStyleBackColor = true;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(39, 246);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(259, 24);
            this.buttonDel.TabIndex = 12;
            this.buttonDel.Text = "Reservar";
            this.buttonDel.UseVisualStyleBackColor = true;
            // 
            // buttonHistorial
            // 
            this.buttonHistorial.Location = new System.Drawing.Point(39, 146);
            this.buttonHistorial.Name = "buttonHistorial";
            this.buttonHistorial.Size = new System.Drawing.Size(259, 24);
            this.buttonHistorial.TabIndex = 10;
            this.buttonHistorial.Text = "Historial";
            this.buttonHistorial.UseVisualStyleBackColor = true;
            this.buttonHistorial.Click += new System.EventHandler(this.buttonHistorial_Click);
            // 
            // buttonInformar
            // 
            this.buttonInformar.Location = new System.Drawing.Point(39, 298);
            this.buttonInformar.Name = "buttonInformar";
            this.buttonInformar.Size = new System.Drawing.Size(259, 24);
            this.buttonInformar.TabIndex = 13;
            this.buttonInformar.Text = "Informar pase";
            this.buttonInformar.UseVisualStyleBackColor = true;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 401);
            this.Controls.Add(this.buttonInformar);
            this.Controls.Add(this.buttonMod);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonHistorial);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelFiltrar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserForm";
            this.Text = "UserForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelFiltrar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonMod;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonHistorial;
        private System.Windows.Forms.Button buttonInformar;
    }
}