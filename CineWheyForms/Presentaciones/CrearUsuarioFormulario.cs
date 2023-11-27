using CineWheyBackend.Models;
using CineWheyBackend.Negocio;
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

    public partial class CrearUsuarioFormulario : Form
    {
        DataApi DA;
        Usuario U;

        public CrearUsuarioFormulario()
        {
            InitializeComponent();
            DA = new DataApi();
            U = new Usuario();
            txtContras.UseSystemPasswordChar = true;
            txtRepeContra.UseSystemPasswordChar = true;

        }

        private void CrearUsuarioFormulario_Load(object sender, EventArgs e)
        {
            txtNombre.Focus();
        }
        public bool ValidarDatos()
        {
            bool valido = true;
            string contraseña = txtContras.Text;
            string contraseña2 = txtRepeContra.Text;

            if (txtUsuario.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar un nombre de usuario", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();
                valido = false;
            }
            if (txtContras.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar una contraseña válida", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContras.Focus();
                valido = false;
            }
            else
            {
                try
                {
                    Convert.ToInt32(txtContras.Text);
                }
                catch
                {
                    MessageBox.Show("La contraseña solo puede contener números", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtContras.Focus();
                    valido = false;
                }
            }
            if (txtRepeContra.Text == String.Empty)
            {
                MessageBox.Show("Debe repetir la contraseña", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContras.Focus();
                valido = false;
            }
            if (contraseña != contraseña2)
            {
                MessageBox.Show("Las contraseñas no coinciden", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContras.Focus();
                valido = false;
            }

            return valido;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                U.nombre_usuario = txtNombre.Text;
                U.contrasñea_usuario = Convert.ToInt32(txtContras.Text);

                if (DA.PostUsuario(U))
                {
                    MessageBox.Show($"Bienvenido {txtNombre.Text} !!, su usuario fue creado con exito", "Control", MessageBoxButtons.OK);
                }
            }

        }

        private void checkContra_CheckedChanged(object sender, EventArgs e)
        {
            txtContras.UseSystemPasswordChar = !checkContra.Checked;
            txtRepeContra.UseSystemPasswordChar = !checkContra.Checked;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Salir de la carga de Usuario?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro desea Cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
              MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)

                limpiar();
            txtNombre.Focus();

        }

        private void limpiar()
        {
            txtNombre.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            txtContras.Text = string.Empty;
            txtRepeContra.Text = string.Empty;

        }
    }
}
