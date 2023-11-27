using CineWheyBackend.Models;
using CineWheyBackend.Negocio;
using CineWheyBackend.Data;
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
    public partial class ClienteFormulario : Form
    {
        HelperSingleton HP;
        IDataApi DA;
        List<Cliente> clienteList;
        bool nuevo;
        Cliente cliente = new Cliente();

        public ClienteFormulario()
        {
            InitializeComponent();
            HP = new HelperSingleton();
            clienteList = new List<Cliente>();
            DA = new DataApi();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClienteFormulario_Load(object sender, EventArgs e)
        {
            habilitar(false);
            cargarCombo(cboCIudad);
            cargarGrilla();
        }

        private void habilitar(bool v)
        {
            txtNombre.Enabled = v;
            txtApellido.Enabled = v;
            txtTelefono.Enabled = v;
            txtCorreo.Enabled = v;
            txtDireccion.Enabled = v;
            cboCIudad.Enabled = v;
            btnNuevo.Enabled = !v;
            btnCargar.Enabled = v;
            BtnCancelar.Enabled = v;
        }

        public void cargarCombo(ComboBox combo)
        {
            DataTable tabla = HP.ConsultarDBCombo("select * from Ciudad");
            combo.DataSource = tabla;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.DisplayMember = tabla.Columns[2].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void cargarGrilla()
        {
            DataTable tabla = HP.ConsultarDBCombo("select nombre, apellido, email, fec_nac from Clientes");
            dgvCliente.Rows.Clear();
            foreach (DataRow fila in tabla.Rows)
            {
                dgvCliente.Rows.Add(new object[]
                {
                    fila[0].ToString(),
                    fila[1].ToString(),
                    fila[2].ToString(),
                    Convert.ToDateTime(fila[3].ToString())
                });
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (nuevo)
            {
                cliente.nombre = txtNombre.Text;
                cliente.apellido = txtApellido.Text;
                cliente.email = txtCorreo.Text;
                cliente.telefono = txtTelefono.Text;
                cliente.fec_nac = Convert.ToDateTime(dtpFechaNacim.Value);
                cliente.direccion = txtDireccion.Text;
                cliente.ciudad = (int)cboCIudad.SelectedValue;

                if (DA.InsertarCliente(cliente))
                {
                    MessageBox.Show("La carga fue realizada con exito", "Control", MessageBoxButtons.OK);
                    dgvCliente.Rows.Add(new object[] { cliente.nombre, cliente.apellido, cliente.email });
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitar(true);
            txtNombre.Focus();
            nuevo = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Salir de la carga de clientes?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void agregarPeliculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PeliculaFormulario peli = new PeliculaFormulario();
            peli.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void cboCIudad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro Desea cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
                limpiar();
            habilitar(false);
        }

        private void limpiar()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            cboCIudad.SelectedIndex = -1;
        }
    }
}
