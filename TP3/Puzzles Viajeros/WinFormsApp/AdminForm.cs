using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class AdminForm : Form
    {
        /// <summary>
        /// True: Usuarios - False: Puzzles
        /// </summary>
        bool botonActivo;
        Puzzleteca puzzleteca;

        public AdminForm(Puzzleteca puzzleteca)
        {
            InitializeComponent();
            this.puzzleteca = puzzleteca; 
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (botonActivo)
            {
                FormInscripcion inscripcion = new FormInscripcion(puzzleteca, true);
                inscripcion.ShowDialog();
            } else
            {
                panelAgregarPuzzle.Visible = true;
            }
        }

        private void buttonUsuarios_Click(object sender, EventArgs e)
        {
            try
            {
                botonActivo = true;
                panelGrilla.Visible = true; 
                dataGridView.DataSource = puzzleteca.Usuarios;
            }
            catch (NullReferenceException nre)
            {
            }
        }

        private void buttonPuzzles_Click(object sender, EventArgs e)
        {
            botonActivo = false;
            panelGrilla.Visible = true;
            dataGridView.DataSource = puzzleteca.Puzzles;
        }
    }
}
