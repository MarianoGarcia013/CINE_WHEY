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
    public partial class ReservaFormulario : Form
    {
        HelperSingleton HP;
        IDataApi DA;
        Reserva reserva = new Reserva();

        public ReservaFormulario()
        {
            InitializeComponent();
            HP = new HelperSingleton();
            DA = new DataApi();
        }

        private void ReservaFormulario_Load(object sender, EventArgs e)
        {
            cargarCombo(cboCliente, "Clientes");
            cargarComboF(cboFuncion, "Funciones");
        }
        public void cargarCombo(ComboBox combo, string nombreTabla)
        {
            DataTable tabla = HP.ConsultarDBCombo($"select * from {nombreTabla}");
            combo.DataSource = tabla;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.DisplayMember = tabla.Columns[2].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void cargarComboF(ComboBox combo, string nombreTabla)
        {
            DataTable tabla = new DataTable();
            tabla = HP.ConsultarDBCombo($"select * from {nombreTabla} ORDER BY 2");
            combo.DataSource = tabla;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.DisplayMember = tabla.Columns[0].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            DataRowView item = (DataRowView)cboFuncion.SelectedItem;
            int id_funcion = Convert.ToInt32(item.Row.ItemArray[0]);
            int pelicula = Convert.ToInt32(item.Row.ItemArray[1]);
            int sala = Convert.ToInt32(item.Row.ItemArray[2]);
            DateTime fecha = Convert.ToDateTime(item.Row.ItemArray[3]);
            double precio = Convert.ToDouble(item.Row.ItemArray[4]);
            string hora_inicio = Convert.ToString(item.Row.ItemArray[5]);

            Funcion funcion = new Funcion(id_funcion, pelicula, sala, precio, fecha, hora_inicio);



            int cliente = Convert.ToInt32(cboCliente.SelectedValue);
            DateTime fecha_reservada = Convert.ToDateTime(dtpFecha.Value);
            int cantidad = Convert.ToInt32(nudCantidad.Value);
            DetalleReserva detalleReserva = new DetalleReserva(funcion, cantidad);

            reserva.AddDtlleReserva(detalleReserva);

            dataGridView1.Rows.Add(new object[] { cliente, funcion.id_funcion, fecha_reservada, cantidad });

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 4)
            {
                reserva.RemoveDtlleReserva(dataGridView1.CurrentCell.RowIndex);
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            }
        }

        private void GrabarReserva()
        {
            reserva.fec_reserva = dtpFecha.Value;
            Cliente cliente = new Cliente();
            cliente.IdCliente = Convert.ToInt32(cboCliente.SelectedValue);
            //reserva.cliente.id_cliente = Convert.ToInt32(DA.GetClientePorId(id));
            reserva.cliente = cliente;


            if (DA.InsertarReserva(reserva))
            {
                MessageBox.Show("La Reserva fue cargada con exito", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("NO se pudo realizar la reseva", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            GrabarReserva();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                  MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cboFuncion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblCantidad_Click(object sender, EventArgs e)
        {

        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void lblFuncion_Click(object sender, EventArgs e)
        {

        }

        private void lblCliente_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
