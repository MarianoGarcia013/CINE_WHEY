using CineWheyBackend.Data;
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
    public partial class FuncionFormulario : Form
    {
        HelperSingleton HP;
        IDataApi DA;
        List<Funcion> funcionList;
        bool nuevo;
        Funcion funcion = new Funcion();
        public FuncionFormulario()
        {
            InitializeComponent();
            HP = new HelperSingleton();
            funcionList = new List<Funcion>();
            DA = new DataApi();
        }

        private void FuncionFormulario_Load(object sender, EventArgs e)
        {
            Habilitar(false);
            cargarCombo( cboPelicula,"Pelicula");
            cargarCombo(cboSala,"Salas");
        }

        public void cargarCombo(ComboBox combo, string nombreTabla)
        {
            DataTable tabla = HP.ConsultarDBCombo($"select * from {nombreTabla}");
            combo.DataSource = tabla;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void CargarLista()
        {
            funcionList.Clear();
            lstBoxFunciones.Items.Clear();

            DataTable tabla = HP.ConsultarDB("SELECT * FROM Funciones");
            foreach (DataRow fila in tabla.Rows)
            {
                Funcion func = new Funcion();
                func.pelicula = Convert.ToInt32(fila["pelicula"]);
                func.sala = Convert.ToInt32(fila["salas"]);
                func.precio = Convert.ToDouble(fila["precio"]);
                func.fecha = Convert.ToDateTime(fila["fecha"]);
                func.hora_inicio = (string)(fila["hora_inicio"]); // ?

                funcionList.Add(func);
                lstBoxFunciones.Items.Add(func);
            }
        }

        private void cargarCampos(int i)
        {
            cboPelicula.SelectedValue = funcionList[i].pelicula;
            cboSala.SelectedValue = funcionList[i].sala;
            txtPrecio.Text = funcionList[i].precio.ToString();
            dtpFecha.Value = funcionList[i].fecha;
            txtHoraInicio.Text = funcionList[i].hora_inicio.ToString();
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
            if (string.IsNullOrEmpty(txtHoraInicio.Text))// || !int.TryParse(txtHoraInicio.Text, out _))
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
            btnAgregarF.Enabled = v;
            btnCancelar.Enabled = v;
        }
        private void limpiar()
        {
            cboPelicula.SelectedIndex = -1;
            cboSala.SelectedIndex = -1;
            txtPrecio.Text = string.Empty;
            dtpFecha.Value = DateTime.Now;
            txtHoraInicio.Text = string.Empty;
        }

        private void btnAgregarF_Click(object sender, EventArgs e)
        {
            if (ValidarFuncion())
            {
                funcion.pelicula = (int)cboPelicula.SelectedValue;
                funcion.sala = (int)cboSala.SelectedValue;
                funcion.fecha = Convert.ToDateTime(dtpFecha.Value);
                funcion.precio = Convert.ToDouble(txtPrecio.Text);
                funcion.hora_inicio = txtHoraInicio.Text;
                if (DA.InsertarFunciones(funcion))
                    MessageBox.Show("La carga fue realizada con exito", "Control", MessageBoxButtons.OK);

            }
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            Habilitar(true);
            nuevo = true;
            cboPelicula.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Cancelar la carga de Funciones?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
                limpiar();
            nuevo = true;
            Habilitar(false);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
           MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            nuevo = false;
            lstBoxFunciones.Enabled = true;
            Habilitar(true);
        }

        private void lstBoxFunciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarCampos(lstBoxFunciones.SelectedIndex);
        }

        private void btnAgregarF_Click_1(object sender, EventArgs e)
        {
            if (ValidarFuncion())
            {
                funcion.pelicula = (int)cboPelicula.SelectedValue;
                funcion.sala = (int)cboSala.SelectedValue;
                funcion.fecha = Convert.ToDateTime(dtpFecha.Value);
                funcion.precio = Convert.ToDouble(txtPrecio.Text);
                funcion.hora_inicio = txtHoraInicio.Text;
                if (DA.InsertarFunciones(funcion))
                    MessageBox.Show("La carga fue realizada con exito", "Control", MessageBoxButtons.OK);

            }
        }
    }
}
