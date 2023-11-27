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
    public partial class ReservasFechasForm : Form
    {
        HelperSingleton HP;
        public ReservasFechasForm()
        {
            InitializeComponent();
            HP = new HelperSingleton();
        }

        private void ReservasFechasForm_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Now.AddDays(-7);
            dtpHasta.Value = DateTime.Now;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Parametros> lst = new List<Parametros>();
            lst.Add(new Parametros("@fecha_desde", dtpDesde.Value.ToString("yyyyMMdd")));
            lst.Add(new Parametros("@fecha_hasta", dtpHasta.Value.ToString("yyyyMMdd")));

            DataTable tabla = HP.Consultar("SP_ReservasPorFecha", lst);
            dataGridView1.Rows.Clear();
            foreach (DataRow fila in tabla.Rows)
            {
                dataGridView1.Rows.Add(new object[]
                {
                    fila[0].ToString(),
                    fila[1].ToString(),
                    fila[2].ToString(),
                    Convert.ToDateTime(fila[3].ToString()),
                    fila[4].ToString(),
                });
            }
            txtCanidadReservas.Text = Convert.ToString(CantidadDeReservas(dataGridView1));
        }

        private int CantidadDeReservas(DataGridView Datagrid)
        {
            int cantidad = 0;
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                cantidad++;
            }
            return cantidad;
        }

        private void btnNuevaBusqueda_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            btnBuscar.Focus();
            txtCanidadReservas.Text = string.Empty;
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
