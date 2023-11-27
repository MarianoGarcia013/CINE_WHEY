using CineWheyBackend.Data;
using CineWheyBackend.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineWheyForms.Presentaciones
{
    public partial class ReservasPorGenero : Form
    {
        HelperSingleton HP;
        IDataApi DA;

        public ReservasPorGenero()
        {
            InitializeComponent();
            HP = new HelperSingleton();
        }

        private void ReservasPorGenero_Load(object sender, EventArgs e)
        {
            cargarCombo(cboGenero, "Generos");
            //decimal Total = CalcularSumaColumna(dataGridView1, "ColTotalRecaudado");
            //txtTotal.Text = Total.ToString();

        }
        public void cargarCombo(ComboBox combo, string nombreTabla)
        {
            DataTable tabla = HP.ConsultarDBCombo($"select * from {nombreTabla}");
            combo.DataSource = tabla;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Parametros> lst = new List<Parametros>();
            lst.Add(new Parametros("@genero", cboGenero.SelectedIndex + 1));

            DataTable tabla = HP.Consultar("SP_ReservasPorGenero", lst);
            dataGridView1.Rows.Clear();
            foreach (DataRow fila in tabla.Rows)
            {
                dataGridView1.Rows.Add(new object[]
                {
                    Convert.ToInt32(fila[0].ToString()),
                    fila[1].ToString(),
                    fila[2].ToString(),
                    fila[3].ToString(),
                    Convert.ToInt32(fila[4].ToString()),
                });
            }
            decimal Total = CalcularSumaColumna(dataGridView1, "ColTotalRecaudado");
            txtTotal.Text = Total.ToString();
        }

        private int CalcularSumaColumna(DataGridView datagrid, string column)
        {
            int suma = 0;

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {


                if (fila.Cells["ColTotalRecaudado"].Value != null && fila.Cells["ColTotalRecaudado"].Value != DBNull.Value)
                {

                    if (int.TryParse(fila.Cells["ColTotalRecaudado"].Value.ToString(), out int valorCelda))
                    {
                        suma += valorCelda;
                    }
                }
            }
            return suma;
        }

        private void btnNuevaBusqueda_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                  MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
                this.Close();
        }

    }
}
