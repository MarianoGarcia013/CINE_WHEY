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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void funcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarPeliculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PeliculaFormulario peli = new PeliculaFormulario();
            peli.Show();
        }

        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteFormulario cliente = new ClienteFormulario();
            cliente.Show();
        }

        private void nuevaReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReservaFormulario reserva = new ReservaFormulario();
            reserva.Show();
        }

        private void agregarFuncionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FuncionFormulario funcion = new FuncionFormulario();
            funcion.Show();
        }

        private void historialReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarPorFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReservasFechasForm fechas = new ReservasFechasForm();
            fechas.Show();
        }

        private void consultarPorGeneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReservasPorGenero genero = new ReservasPorGenero();
            genero.Show();
        }
    }
}
