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
    public partial class PeliculaFormulario : Form
    {
        HelperSingleton HP;
        IDataApi DA;
        List<Pelicula> PeliculaList;
        bool nuevo;
        Pelicula pelicula = new Pelicula();

        public PeliculaFormulario()
        {
            InitializeComponent();
            HP = new HelperSingleton();
            PeliculaList = new List<Pelicula>();
            DA = new DataApi();
        }

        private void PeliculaFormulario_Load(object sender, EventArgs e)
        {
            cargarLista();
            Habilitar(false);
            cargarCombo(cboIdioma, "idiomas");
            cargarCombo(cboGenero, "generos");


        }

        private void Habilitar(bool v)
        {
            txtTitulo.Enabled = v;
            txtDirector.Enabled = v;
            txtDuracion.Enabled = v;
            dtpFechaEstreno.Enabled = v;
            cboGenero.Enabled = v;
            cboIdioma.Enabled = v;
            btnNueva.Enabled = !v;
            btnAgregar.Enabled = v;
            btnCancelar.Enabled = v;

        }

        public void cargarCombo(ComboBox combo, string nombreTabla)
        {
            DataTable tabla = HP.ConsultarDBCombo($"select * from {nombreTabla}");
            combo.DataSource = tabla;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void cargarLista()
        {
            PeliculaList.Clear();
            lstBoxPelicula.Items.Clear();

            DataTable tabla = HP.ConsultarDB("Select * from Pelicula");
            foreach (DataRow fila in tabla.Rows)
            {
                Pelicula pelicula = new Pelicula();
                pelicula.id_pelicula = Convert.ToInt32(fila[0]);
                pelicula.titulo = fila[1].ToString();
                pelicula.fecha_estreno = Convert.ToDateTime(fila[2].ToString());
                pelicula.director = fila[3].ToString();
                pelicula.genero = Convert.ToInt32(fila[4].ToString());
                pelicula.idioma = Convert.ToInt32(fila[5].ToString());
                pelicula.duracion = Convert.ToInt32(fila[7].ToString());

                PeliculaList.Add(pelicula);
                lstBoxPelicula.Items.Add(pelicula);
            }
        }
        private void cargarCampos(int i)
        {

            txtCodigo.Text = PeliculaList[i].id_pelicula.ToString();
            txtTitulo.Text = PeliculaList[i].titulo.ToString();
            txtDirector.Text = PeliculaList[i].director.ToString();
            txtDuracion.Text = PeliculaList[i].duracion.ToString();
            dtpFechaEstreno.Text = PeliculaList[i].fecha_estreno.ToString();
            cboGenero.SelectedValue = PeliculaList[i].genero;
            cboIdioma.SelectedValue = PeliculaList[i].idioma;
            txtDuracion.Text = PeliculaList[i].duracion.ToString();
            //rbtSi.Checked = PeliculaList[i].apta_todo_publico == true; // ??
            // rbtNo.Checked = PeliculaList[i].apta_todo_publico == true; // ??                      


        }

        private bool ValidarPelicula()
        {
            bool Ok = true;
            if (txtTitulo.Text.Trim() == "") //el trim es por si mandamos un espacio vacio en la caja de texto no lo tome como algo escrito.
            {
                MessageBox.Show("Debe agregar un titulo", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Ok = false;
            }
            if (txtDirector.Text.Trim() == "")
            {
                MessageBox.Show("Debe agregar un Director", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Ok = false;
            }
            if (txtDuracion.Text.Trim() == "")
            {
                MessageBox.Show("Debe agregar una Duracion", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Ok = false;
            }
            if (cboGenero.Text.Equals(string.Empty))
            {
                MessageBox.Show("Debe seleccionar un Genero", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Ok = false;
            }
            if (cboIdioma.Text.Equals(string.Empty))
            {
                MessageBox.Show("Debe seleccionar un Idioma", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Ok = false;
            }

            return Ok;
        }


        private void limpiar()
        {
            txtTitulo.Text = string.Empty;
            txtDirector.Text = string.Empty;
            txtDuracion.Text = string.Empty;
            dtpFechaEstreno.Value = DateTime.Now;
            cboGenero.SelectedIndex = -1;
            cboIdioma.SelectedIndex = -1;
            rbtSi.Checked = false;
            rbtNo.Checked = false;
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
            lstBoxPelicula.Enabled = true;
            Habilitar(true);
        }

        private void lstBoxPelicula_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarCampos(lstBoxPelicula.SelectedIndex);
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (nuevo)
            {
                if (ValidarPelicula())
                {
                    pelicula.titulo = txtTitulo.Text;
                    pelicula.duracion = Convert.ToInt32(txtDuracion.Text);
                    pelicula.fecha_estreno = Convert.ToDateTime(dtpFechaEstreno.Value);
                    pelicula.director = txtDirector.Text;
                    pelicula.genero = (int)cboGenero.SelectedValue;
                    pelicula.idioma = (int)cboIdioma.SelectedValue;
                    if (rbtSi.Checked)
                        pelicula.apta_todo_publico = true;
                    else
                        pelicula.apta_todo_publico = false;
                }

                if (DA.InsertarPelicula(pelicula))
                    MessageBox.Show("La carga fue realizada con exito", "Control", MessageBoxButtons.OK);
                cargarLista();

            }
            else
            {
                pelicula.id_pelicula = Convert.ToInt32(txtCodigo.Text);
                pelicula.titulo = txtTitulo.Text;
                pelicula.duracion = Convert.ToInt32(txtDuracion.Text);
                pelicula.director = txtDirector.Text;
                //pelicula.fecha_estreno = Convert.ToDateTime(dtpFechaEstreno.Value);
                pelicula.genero = (int)cboGenero.SelectedValue;
                pelicula.idioma = (int)cboIdioma.SelectedValue;
                //if (rbtSi.Checked)
                //    pelicula.apta_todo_publico = true;
                //else
                //    pelicula.apta_todo_publico = false;
                if (DA.UpdatePelcicula(pelicula))
                {
                    MessageBox.Show("La Pelicula fue modificada con exito!", "CONTROL", MessageBoxButtons.OK);
                    cargarLista();
                }
                else
                {
                    MessageBox.Show("La Pelicula no pudo ser modificada", "CONTROL", MessageBoxButtons.OK);
                }

            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                      MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)

                limpiar();
            Habilitar(false);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }

        private void btnNueva_Click_1(object sender, EventArgs e)
        {
            Habilitar(true);
            nuevo = true;
            txtTitulo.Focus();
            limpiar();
        }
    }
}
