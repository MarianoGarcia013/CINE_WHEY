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
            cargarCombo(cboCIudad);
        }

        public void cargarCombo(ComboBox combo)
        {
            DataTable tabla = HP.ConsultarDBCombo("select * from Ciudad");
            combo.DataSource = tabla;           
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.DisplayMember = tabla.Columns[2].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
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
                    MessageBox.Show("La carga fue realizada con exito", "Control", MessageBoxButtons.OK);
                dgvCliente.Rows.Add(new object[] { cliente.nombre, cliente.apellido, cliente.email });
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevo = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que quiere salir del programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
                this.Close(); 
        }
    }
}
