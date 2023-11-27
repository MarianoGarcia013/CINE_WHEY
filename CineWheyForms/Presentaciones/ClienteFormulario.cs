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
            DataTable tabla = HP.ConsultarDBCombo("select * from Clientes");
            clienteList.Clear();
            dgvCliente.Rows.Clear();
            foreach (DataRow fila in tabla.Rows)
            {
<<<<<<< HEAD
                int id_cliente = Convert.ToInt32(fila[0].ToString());
                string nombre = fila[1].ToString();
                string apellido = fila[2].ToString();
                string email = fila[3].ToString();
                string telefono = fila[4].ToString();
                DateTime fec_nac = Convert.ToDateTime(fila[5].ToString());
                string direccion = fila[6].ToString();
                int ciudad = Convert.ToInt32((fila[7].ToString()));

                clienteList.Add(new Cliente(id_cliente, nombre, apellido, email, telefono, fec_nac, direccion, ciudad));

                dgvCliente.Rows.Add(new object[] {nombre, apellido, email, fec_nac});
            }        
        }

        private void CargarCampos(int i)
        {
            txtCodigo.Text = clienteList[i].IdCliente.ToString();
            txtNombre.Text = clienteList[i].nombre.ToString();
            txtApellido.Text = clienteList[i].apellido.ToString();
            txtCodigo.Text = clienteList[i].email.ToString();
            dtpFechaNacim.Value = clienteList[i].fec_nac;
            txtDireccion.Text = clienteList[i].direccion.ToString();
            cboCIudad.SelectedValue = clienteList[i].ciudad;
=======
                dgvCliente.Rows.Add(new object[]
                {
                    fila[0].ToString(),
                    fila[1].ToString(),
                    fila[2].ToString(),
                    Convert.ToDateTime(fila[3].ToString())
                });
            }
>>>>>>> b9938ca (Vistas e imagenes)
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
<<<<<<< HEAD
      

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvCliente.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvCliente.SelectedRows[0];
                int rowIndex = selectedRow.Index;

                // Llama a tu método para cargar los campos basados en el índice de la fila seleccionada
                CargarCampos(rowIndex);
            }
=======

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
>>>>>>> b9938ca (Vistas e imagenes)
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD

=======
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
>>>>>>> b9938ca (Vistas e imagenes)
        }
    }
}
