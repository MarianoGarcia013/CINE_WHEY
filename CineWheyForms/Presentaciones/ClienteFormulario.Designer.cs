namespace CineWheyForms.Presentaciones
{
    partial class ClienteFormulario
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.dtpFechaNacim = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.cboCIudad = new System.Windows.Forms.ComboBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
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
            this.funcionesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarFuncionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarFuncionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTodasLasFuncionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Correo Electronico";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(517, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(517, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefono";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(191, 126);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(290, 31);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(605, 123);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(268, 31);
            this.txtApellido.TabIndex = 6;
            // 
            // dtpFechaNacim
            // 
            this.dtpFechaNacim.Location = new System.Drawing.Point(191, 315);
            this.dtpFechaNacim.Name = "dtpFechaNacim";
            this.dtpFechaNacim.Size = new System.Drawing.Size(290, 31);
            this.dtpFechaNacim.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fecha de nacimiento";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(191, 210);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(290, 31);
            this.txtCorreo.TabIndex = 9;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(605, 219);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(268, 31);
            this.txtTelefono.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 404);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Direccion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(99, 479);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Ciudad";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(181, 398);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(300, 31);
            this.txtDireccion.TabIndex = 13;
            // 
            // cboCIudad
            // 
            this.cboCIudad.FormattingEnabled = true;
            this.cboCIudad.Location = new System.Drawing.Point(181, 476);
            this.cboCIudad.Name = "cboCIudad";
            this.cboCIudad.Size = new System.Drawing.Size(300, 33);
            this.cboCIudad.TabIndex = 14;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(39, 679);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(101, 58);
            this.btnNuevo.TabIndex = 16;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(163, 679);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(101, 58);
            this.btnCargar.TabIndex = 17;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1146, 679);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(101, 58);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(1011, 679);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(101, 58);
            this.BtnCancelar.TabIndex = 19;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNombre,
            this.ColApellido,
            this.ColCorreo,
            this.ColAcciones});
            this.dgvCliente.Location = new System.Drawing.Point(517, 278);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.RowHeadersWidth = 62;
            this.dgvCliente.RowTemplate.Height = 33;
            this.dgvCliente.Size = new System.Drawing.Size(730, 359);
            this.dgvCliente.TabIndex = 20;
            // 
            // ColNombre
            // 
            this.ColNombre.HeaderText = "Nombre";
            this.ColNombre.MinimumWidth = 8;
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            this.ColNombre.Width = 200;
            // 
            // ColApellido
            // 
            this.ColApellido.HeaderText = "Apellido";
            this.ColApellido.MinimumWidth = 8;
            this.ColApellido.Name = "ColApellido";
            this.ColApellido.ReadOnly = true;
            this.ColApellido.Width = 200;
            // 
            // ColCorreo
            // 
            this.ColCorreo.HeaderText = "Email";
            this.ColCorreo.MinimumWidth = 8;
            this.ColCorreo.Name = "ColCorreo";
            this.ColCorreo.ReadOnly = true;
            this.ColCorreo.Width = 150;
            // 
            // ColAcciones
            // 
            this.ColAcciones.HeaderText = "Accion";
            this.ColAcciones.MinimumWidth = 8;
            this.ColAcciones.Name = "ColAcciones";
            this.ColAcciones.Width = 150;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(293, 679);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(101, 58);
            this.btnActualizar.TabIndex = 21;
            this.btnActualizar.Text = "&Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(28, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(268, 32);
            this.label9.TabIndex = 23;
            this.label9.Text = "CARGAR CLIENTE";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionesToolStripMenuItem,
            this.peliculaToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.funcionesToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1276, 33);
            this.menuStrip1.TabIndex = 24;
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
            this.agregarPeliculaToolStripMenuItem.Click += new System.EventHandler(this.agregarPeliculaToolStripMenuItem_Click);
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
            // funcionesToolStripMenuItem1
            // 
            this.funcionesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarFuncionToolStripMenuItem,
            this.eliminarFuncionToolStripMenuItem,
            this.verTodasLasFuncionesToolStripMenuItem});
            this.funcionesToolStripMenuItem1.Name = "funcionesToolStripMenuItem1";
            this.funcionesToolStripMenuItem1.Size = new System.Drawing.Size(107, 29);
            this.funcionesToolStripMenuItem1.Text = "Funciones";
            // 
            // agregarFuncionToolStripMenuItem
            // 
            this.agregarFuncionToolStripMenuItem.Name = "agregarFuncionToolStripMenuItem";
            this.agregarFuncionToolStripMenuItem.Size = new System.Drawing.Size(299, 34);
            this.agregarFuncionToolStripMenuItem.Text = "Agregar Funcion";
            // 
            // eliminarFuncionToolStripMenuItem
            // 
            this.eliminarFuncionToolStripMenuItem.Name = "eliminarFuncionToolStripMenuItem";
            this.eliminarFuncionToolStripMenuItem.Size = new System.Drawing.Size(299, 34);
            this.eliminarFuncionToolStripMenuItem.Text = "Eliminar Funcion";
            // 
            // verTodasLasFuncionesToolStripMenuItem
            // 
            this.verTodasLasFuncionesToolStripMenuItem.Name = "verTodasLasFuncionesToolStripMenuItem";
            this.verTodasLasFuncionesToolStripMenuItem.Size = new System.Drawing.Size(299, 34);
            this.verTodasLasFuncionesToolStripMenuItem.Text = "Ver todas las Funciones";
            // 
            // ClienteFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 763);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.cboCIudad);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpFechaNacim);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ClienteFormulario";
            this.Text = "ClienteFormulario";
            this.Load += new System.EventHandler(this.ClienteFormulario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private DateTimePicker dtpFechaNacim;
        private Label label6;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private Label label7;
        private Label label8;
        private TextBox txtDireccion;
        private ComboBox cboCIudad;
        private Button btnNuevo;
        private Button btnCargar;
        private Button btnSalir;
        private Button BtnCancelar;
        private DataGridView dgvCliente;
        private DataGridViewTextBoxColumn ColNombre;
        private DataGridViewTextBoxColumn ColApellido;
        private DataGridViewTextBoxColumn ColCorreo;
        private DataGridViewButtonColumn ColAcciones;
        private Button btnActualizar;
        private Label label9;
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
        private ToolStripMenuItem funcionesToolStripMenuItem1;
        private ToolStripMenuItem agregarFuncionToolStripMenuItem;
        private ToolStripMenuItem eliminarFuncionToolStripMenuItem;
        private ToolStripMenuItem verTodasLasFuncionesToolStripMenuItem;
    }
}