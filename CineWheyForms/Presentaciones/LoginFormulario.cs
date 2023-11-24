using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CineWheyBackend.Models;
using CineWheyBackend.Data;
using System.Data.SqlClient;
using System.Drawing.Text;

namespace CineWheyForms.Presentaciones
{
    public partial class LoginFormulario : Form
    {
        public LoginFormulario()
        {
            InitializeComponent();

            checkContra.CheckedChanged+= checkContra_CheckedChanged;
            txtContraseña.UseSystemPasswordChar = true;

        }


        public bool ValidarDatos()
        {
            bool valido = true;
            if (txtUsuario.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar un nombre de usuario", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();
                valido = false;
            }
            if (txtContraseña.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar una contraseña válida", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseña.Focus();
                valido = false;
            }
            else
            {
                try
                {
                    Convert.ToInt32(txtContraseña.Text);
                }
                catch
                {
                    MessageBox.Show("La contraseña solo puede contener números", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtContraseña.Focus();
                    valido = false;
                }
            }

            return valido;
        }      

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                string usuario = txtUsuario.Text;
                string contraseña = txtContraseña.Text;

                if(HelperSingleton.getInstance().ValidarCredenciales(usuario, contraseña))
                {
                    MessageBox.Show("Inicio de sesión exitoso.");
                    MenuPrincipal menu = new MenuPrincipal();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas. Intenta nuevamente.");
                    txtUsuario.Focus();
                }
            }

        }

        private void LoginFormulario_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro desea abandoar la aplicación?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
       

        private void checkContra_CheckedChanged(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = !checkContra.Checked;
        }
    }
}

