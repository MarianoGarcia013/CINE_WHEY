using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineWheyForms.Presentaciones
{
    public partial class FuncionFormulario : Form
    {
        public FuncionFormulario()
        {
            InitializeComponent();
        }

        private void FuncionFormulario_Load(object sender, EventArgs e)
        {

        }
        private bool ValidarFuncion()
        {
            bool Ok = true;

            if (cboPelicula.Text.Equals(string.Empty))
            {
                MessageBox.Show("Debe elegir una pelicula", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Ok = false;
            }
            if (cboSala.Text.Equals(string.Empty))
            {
                MessageBox.Show("Debe elegir una sala", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Ok = false;
            }
            if (string.IsNullOrEmpty(txtPrecio.Text) || !int.TryParse(txtPrecio.Text, out _))
            {
                MessageBox.Show("Debe cargar un precio valido", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Ok = false;
            }
            if (string.IsNullOrEmpty(txtHoraInicio.Text) || !int.TryParse(txtHoraInicio.Text, out _))
            {
                MessageBox.Show("Debe agregar una hora de inicio valida", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Ok = false;
            }

            return Ok;
        }

        private void Habilitar(bool v)
        {
            cboPelicula.Enabled = v;
            cboSala.Enabled = v;
            txtPrecio.Enabled = v;
            dtpFecha.Enabled = v;
            txtHoraInicio.Enabled = v;
            btnAgregarF.Enabled = !v;
            btnCancelar.Enabled = v;
        }
    }
}
