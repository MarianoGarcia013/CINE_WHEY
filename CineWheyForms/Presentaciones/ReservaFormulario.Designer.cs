namespace CineWheyForms.Presentaciones
{
    partial class ReservaFormulario
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
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cboFuncion = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFuncion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblFuncion = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
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
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAGREGAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAGREGAR.ForeColor = System.Drawing.Color.White;
            this.btnAGREGAR.Location = new System.Drawing.Point(966, 202);
            this.btnAGREGAR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(249, 47);
            this.btnAGREGAR.TabIndex = 15;
            this.btnAGREGAR.Text = "AGREGAR";
            this.btnAGREGAR.UseVisualStyleBackColor = false;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(1121, 680);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(108, 42);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCargar.ForeColor = System.Drawing.Color.White;
            this.btnCargar.Location = new System.Drawing.Point(966, 680);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(108, 42);
            this.btnCargar.TabIndex = 18;
            this.btnCargar.Text = "&Cargar";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // nudCantidad
            // 
            this.nudCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudCantidad.Location = new System.Drawing.Point(721, 211);
            this.nudCantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(237, 31);
            this.nudCantidad.TabIndex = 13;
            this.nudCantidad.ValueChanged += new System.EventHandler(this.nudCantidad_ValueChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFecha.Location = new System.Drawing.Point(723, 161);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(489, 31);
            this.dtpFecha.TabIndex = 11;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // cboFuncion
            // 
            this.cboFuncion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboFuncion.FormattingEnabled = true;
            this.cboFuncion.Location = new System.Drawing.Point(155, 207);
            this.cboFuncion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboFuncion.Name = "cboFuncion";
            this.cboFuncion.Size = new System.Drawing.Size(406, 33);
            this.cboFuncion.TabIndex = 9;
            this.cboFuncion.SelectedIndexChanged += new System.EventHandler(this.cboFuncion_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeight = 34;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCliente,
            this.ColFuncion,
            this.ColFecha,
            this.colCantidad,
            this.colAccion});
            this.dataGridView1.Location = new System.Drawing.Point(31, 259);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(1198, 397);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColCliente
            // 
            this.ColCliente.HeaderText = "Cliente";
            this.ColCliente.MinimumWidth = 8;
            this.ColCliente.Name = "ColCliente";
            this.ColCliente.ReadOnly = true;
            this.ColCliente.Width = 200;
            // 
            // ColFuncion
            // 
            this.ColFuncion.HeaderText = "Funcion";
            this.ColFuncion.MinimumWidth = 8;
            this.ColFuncion.Name = "ColFuncion";
            this.ColFuncion.ReadOnly = true;
            this.ColFuncion.Width = 180;
            // 
            // ColFecha
            // 
            this.ColFecha.HeaderText = "Fecha";
            this.ColFecha.MinimumWidth = 8;
            this.ColFecha.Name = "ColFecha";
            this.ColFecha.ReadOnly = true;
            this.ColFecha.Width = 150;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.MinimumWidth = 8;
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            this.colCantidad.Width = 150;
            // 
            // colAccion
            // 
            this.colAccion.HeaderText = "Accion";
            this.colAccion.MinimumWidth = 8;
            this.colAccion.Name = "colAccion";
            this.colAccion.ReadOnly = true;
            this.colAccion.Text = "Quitar";
            this.colAccion.UseColumnTextForButtonValue = true;
            this.colAccion.Width = 150;
            // 
            // cboCliente
            // 
            this.cboCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(155, 159);
            this.cboCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(406, 33);
            this.cboCliente.TabIndex = 8;
            this.cboCliente.SelectedIndexChanged += new System.EventHandler(this.cboCliente_SelectedIndexChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.ForeColor = System.Drawing.Color.White;
            this.lblCantidad.Location = new System.Drawing.Point(602, 212);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(104, 25);
            this.lblCantidad.TabIndex = 16;
            this.lblCantidad.Text = "CANTIDAD:";
            this.lblCantidad.UseWaitCursor = true;
            this.lblCantidad.Click += new System.EventHandler(this.lblCantidad_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFecha.AutoSize = true;
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(635, 161);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(70, 25);
            this.lblFecha.TabIndex = 14;
            this.lblFecha.Text = "FECHA:";
            this.lblFecha.Click += new System.EventHandler(this.lblFecha_Click);
            // 
            // lblFuncion
            // 
            this.lblFuncion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFuncion.AutoSize = true;
            this.lblFuncion.ForeColor = System.Drawing.Color.White;
            this.lblFuncion.Location = new System.Drawing.Point(31, 210);
            this.lblFuncion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFuncion.Name = "lblFuncion";
            this.lblFuncion.Size = new System.Drawing.Size(93, 25);
            this.lblFuncion.TabIndex = 12;
            this.lblFuncion.Text = "FUNCIÓN:";
            this.lblFuncion.Click += new System.EventHandler(this.lblFuncion_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCliente.AutoSize = true;
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(44, 161);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(80, 25);
            this.lblCliente.TabIndex = 10;
            this.lblCliente.Text = "CLIENTE:";
            this.lblCliente.Click += new System.EventHandler(this.lblCliente_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionesToolStripMenuItem,
            this.peliculaToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.funcionesToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 33);
            this.menuStrip1.TabIndex = 20;
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
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(31, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(331, 32);
            this.label9.TabIndex = 24;
            this.label9.Text = "REGISTRAR RESERVAS";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // ReservaFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1264, 752);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnAGREGAR);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cboFuncion);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblFuncion);
            this.Controls.Add(this.lblCliente);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ReservaFormulario";
            this.Text = "ReservaFormulario";
            this.Load += new System.EventHandler(this.ReservaFormulario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAGREGAR;
        private Button btnSalir;
        private Button btnCargar;
        private NumericUpDown nudCantidad;
        private DateTimePicker dtpFecha;
        private ComboBox cboFuncion;
        private DataGridView dataGridView1;
        private ComboBox cboCliente;
        private Label lblCantidad;
        private Label lblFecha;
        private Label lblFuncion;
        private Label lblCliente;
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
        private Label label9;
        private DataGridViewTextBoxColumn ColCliente;
        private DataGridViewTextBoxColumn ColFuncion;
        private DataGridViewTextBoxColumn ColFecha;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewButtonColumn colAccion;
    }
}