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
    public partial class ResevasFormulario : Form
    {
        public ResevasFormulario()
        {
            InitializeComponent();
        }

        private void ResevasFormulario_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnCargaCliente_Click(object sender, EventArgs e)
        {
            ClienteFormulario clienteFormulario= new ClienteFormulario();
            clienteFormulario.ShowDialog();
        }
    }
}
