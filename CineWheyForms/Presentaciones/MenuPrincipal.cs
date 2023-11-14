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
            ResevasFormulario reserva = new ResevasFormulario();
            reserva.Show();
        }

        private void agregarFuncionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FuncionFormulario funcion = new FuncionFormulario();
            funcion.Show();
        }
    }
}
