namespace CineWheyForms.Presentaciones
{
    partial class FuncionFormulario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.funcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaReservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarReservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peliculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarPeliculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarPeliculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFuncion = new System.Windows.Forms.Label();
            this.cboPelicula = new System.Windows.Forms.ComboBox();
            this.cboSala = new System.Windows.Forms.ComboBox();
            this.lblPelicula = new System.Windows.Forms.Label();
            this.lblSala = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora_Inicio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtHoraInicio = new System.Windows.Forms.TextBox();
            this.btnAgregarF = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionesToolStripMenuItem,
            this.peliculaToolStripMenuItem,
            this.clienteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(873, 33);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // funcionesToolStripMenuItem
            // 
            this.funcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaReservaToolStripMenuItem,
            this.eliminarReservaToolStripMenuItem,
            this.historialReservasToolStripMenuItem});
            this.funcionesToolStripMenuItem.Name = "funcionesToolStripMenuItem";
            this.funcionesToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.funcionesToolStripMenuItem.Text = "Reserva";
            // 
            // nuevaReservaToolStripMenuItem
            // 
            this.nuevaReservaToolStripMenuItem.Name = "nuevaReservaToolStripMenuItem";
            this.nuevaReservaToolStripMenuItem.Size = new System.Drawing.Size(252, 34);
            this.nuevaReservaToolStripMenuItem.Text = "Nueva Reserva";
            // 
            // eliminarReservaToolStripMenuItem
            // 
            this.eliminarReservaToolStripMenuItem.Name = "eliminarReservaToolStripMenuItem";
            this.eliminarReservaToolStripMenuItem.Size = new System.Drawing.Size(252, 34);
            this.eliminarReservaToolStripMenuItem.Text = "Eliminar Reserva";
            // 
            // historialReservasToolStripMenuItem
            // 
            this.historialReservasToolStripMenuItem.Name = "historialReservasToolStripMenuItem";
            this.historialReservasToolStripMenuItem.Size = new System.Drawing.Size(252, 34);
            this.historialReservasToolStripMenuItem.Text = "Historial Reservas";
            // 
            // peliculaToolStripMenuItem
            // 
            this.peliculaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarPeliculaToolStripMenuItem,
            this.eliminarPeliculaToolStripMenuItem});
            this.peliculaToolStripMenuItem.Name = "peliculaToolStripMenuItem";
            this.peliculaToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.peliculaToolStripMenuItem.Text = "Pelicula";
            // 
            // agregarPeliculaToolStripMenuItem
            // 
            this.agregarPeliculaToolStripMenuItem.Name = "agregarPeliculaToolStripMenuItem";
            this.agregarPeliculaToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.agregarPeliculaToolStripMenuItem.Text = "Agregar Pelicula";
            // 
            // eliminarPeliculaToolStripMenuItem
            // 
            this.eliminarPeliculaToolStripMenuItem.Name = "eliminarPeliculaToolStripMenuItem";
            this.eliminarPeliculaToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.eliminarPeliculaToolStripMenuItem.Text = "Eliminar Pelicula";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarClienteToolStripMenuItem,
            this.modificarClienteToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(81, 29);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // agregarClienteToolStripMenuItem
            // 
            this.agregarClienteToolStripMenuItem.Name = "agregarClienteToolStripMenuItem";
            this.agregarClienteToolStripMenuItem.Size = new System.Drawing.Size(247, 34);
            this.agregarClienteToolStripMenuItem.Text = "Agregar Cliente";
            // 
            // modificarClienteToolStripMenuItem
            // 
            this.modificarClienteToolStripMenuItem.Name = "modificarClienteToolStripMenuItem";
            this.modificarClienteToolStripMenuItem.Size = new System.Drawing.Size(247, 34);
            this.modificarClienteToolStripMenuItem.Text = "Modificar Cliente";
            // 
            // lblFuncion
            // 
            this.lblFuncion.AutoSize = true;
            this.lblFuncion.Location = new System.Drawing.Point(98, 107);
            this.lblFuncion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFuncion.Name = "lblFuncion";
            this.lblFuncion.Size = new System.Drawing.Size(93, 25);
            this.lblFuncion.TabIndex = 13;
            this.lblFuncion.Text = "FUNCION:";
            // 
            // cboPelicula
            // 
            this.cboPelicula.BackColor = System.Drawing.Color.White;
            this.cboPelicula.ForeColor = System.Drawing.Color.Black;
            this.cboPelicula.FormattingEnabled = true;
            this.cboPelicula.Location = new System.Drawing.Point(307, 152);
            this.cboPelicula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboPelicula.Name = "cboPelicula";
            this.cboPelicula.Size = new System.Drawing.Size(373, 33);
            this.cboPelicula.TabIndex = 14;
            // 
            // cboSala
            // 
            this.cboSala.BackColor = System.Drawing.Color.White;
            this.cboSala.ForeColor = System.Drawing.Color.Black;
            this.cboSala.FormattingEnabled = true;
            this.cboSala.Location = new System.Drawing.Point(307, 200);
            this.cboSala.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboSala.Name = "cboSala";
            this.cboSala.Size = new System.Drawing.Size(257, 33);
            this.cboSala.TabIndex = 15;
            // 
            // lblPelicula
            // 
            this.lblPelicula.AutoSize = true;
            this.lblPelicula.Location = new System.Drawing.Point(178, 157);
            this.lblPelicula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPelicula.Name = "lblPelicula";
            this.lblPelicula.Size = new System.Drawing.Size(92, 25);
            this.lblPelicula.TabIndex = 16;
            this.lblPelicula.Text = "PELICULA:";
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Location = new System.Drawing.Point(213, 205);
            this.lblSala.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(59, 25);
            this.lblSala.TabIndex = 17;
            this.lblSala.Text = "SALA:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(195, 267);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(76, 25);
            this.lblPrecio.TabIndex = 18;
            this.lblPrecio.Text = "PRECIO:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(200, 352);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(70, 25);
            this.lblFecha.TabIndex = 19;
            this.lblFecha.Text = "FECHA:";
            // 
            // lblHora_Inicio
            // 
            this.lblHora_Inicio.AutoSize = true;
            this.lblHora_Inicio.Location = new System.Drawing.Point(123, 402);
            this.lblHora_Inicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora_Inicio.Name = "lblHora_Inicio";
            this.lblHora_Inicio.Size = new System.Drawing.Size(156, 25);
            this.lblHora_Inicio.TabIndex = 20;
            this.lblHora_Inicio.Text = "HORA DE INICIO: ";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.White;
            this.txtPrecio.ForeColor = System.Drawing.Color.Black;
            this.txtPrecio.Location = new System.Drawing.Point(308, 262);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(141, 31);
            this.txtPrecio.TabIndex = 21;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(308, 342);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(331, 31);
            this.dtpFecha.TabIndex = 22;
            // 
            // txtHoraInicio
            // 
            this.txtHoraInicio.BackColor = System.Drawing.Color.White;
            this.txtHoraInicio.Location = new System.Drawing.Point(308, 397);
            this.txtHoraInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHoraInicio.Name = "txtHoraInicio";
            this.txtHoraInicio.Size = new System.Drawing.Size(204, 31);
            this.txtHoraInicio.TabIndex = 23;
            // 
            // btnAgregarF
            // 
            this.btnAgregarF.Location = new System.Drawing.Point(389, 479);
            this.btnAgregarF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarF.Name = "btnAgregarF";
            this.btnAgregarF.Size = new System.Drawing.Size(107, 38);
            this.btnAgregarF.TabIndex = 24;
            this.btnAgregarF.Text = "&Agregar";
            this.btnAgregarF.UseVisualStyleBackColor = true;
            this.btnAgregarF.Click += new System.EventHandler(this.btnAgregarF_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(573, 479);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 38);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 479);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 38);
            this.button1.TabIndex = 27;
            this.button1.Text = "&Nueva";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FuncionFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 582);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregarF);
            this.Controls.Add(this.txtHoraInicio);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblHora_Inicio);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblSala);
            this.Controls.Add(this.lblPelicula);
            this.Controls.Add(this.cboSala);
            this.Controls.Add(this.cboPelicula);
            this.Controls.Add(this.lblFuncion);
            this.Name = "FuncionFormulario";
            this.Text = "FuncionFormulario";
            this.Load += new System.EventHandler(this.FuncionFormulario_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem funcionesToolStripMenuItem;
        private ToolStripMenuItem nuevaReservaToolStripMenuItem;
        private ToolStripMenuItem eliminarReservaToolStripMenuItem;
        private ToolStripMenuItem historialReservasToolStripMenuItem;
        private ToolStripMenuItem peliculaToolStripMenuItem;
        private ToolStripMenuItem agregarPeliculaToolStripMenuItem;
        private ToolStripMenuItem eliminarPeliculaToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem agregarClienteToolStripMenuItem;
        private ToolStripMenuItem modificarClienteToolStripMenuItem;
        private Label lblFuncion;
        private ComboBox cboPelicula;
        private ComboBox cboSala;
        private Label lblPelicula;
        private Label lblSala;
        private Label lblPrecio;
        private Label lblFecha;
        private Label lblHora_Inicio;
        private TextBox txtPrecio;
        private DateTimePicker dtpFecha;
        private TextBox txtHoraInicio;
        private Button btnAgregarF;
        private Button btnCancelar;
        private Button button1;
    }
}