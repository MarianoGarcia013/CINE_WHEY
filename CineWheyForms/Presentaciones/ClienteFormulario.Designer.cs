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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            dtpFechaNacim = new DateTimePicker();
            label6 = new Label();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtDireccion = new TextBox();
            cboCIudad = new ComboBox();
            btnNuevo = new Button();
            btnCargar = new Button();
            btnSalir = new Button();
            BtnCancelar = new Button();
            dgvCliente = new DataGridView();
            ColNombre = new DataGridViewTextBoxColumn();
            ColApellido = new DataGridViewTextBoxColumn();
            ColCorreo = new DataGridViewTextBoxColumn();
            ColNacimiento = new DataGridViewTextBoxColumn();
            btnActualizar = new Button();
            label9 = new Label();
            menuStrip1 = new MenuStrip();
            funcionesToolStripMenuItem = new ToolStripMenuItem();
            nuevaReservaToolStripMenuItem = new ToolStripMenuItem();
            eliminarReservaToolStripMenuItem = new ToolStripMenuItem();
            historialReservasToolStripMenuItem = new ToolStripMenuItem();
            peliculaToolStripMenuItem = new ToolStripMenuItem();
            agregarPeliculaToolStripMenuItem = new ToolStripMenuItem();
            eliminarPeliculaToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            agregarClienteToolStripMenuItem = new ToolStripMenuItem();
            modificarClienteToolStripMenuItem = new ToolStripMenuItem();
            funcionesToolStripMenuItem1 = new ToolStripMenuItem();
            agregarFuncionToolStripMenuItem = new ToolStripMenuItem();
            eliminarFuncionToolStripMenuItem = new ToolStripMenuItem();
            verTodasLasFuncionesToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(96, 105);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "NOMBRE: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(113, 203);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 2;
            label3.Text = "E-Mail:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(92, 135);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 3;
            label4.Text = "APELLIDO:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(89, 169);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 4;
            label5.Text = "TELÉFONO:";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.White;
            txtNombre.ForeColor = Color.Black;
            txtNombre.Location = new Point(167, 105);
            txtNombre.Margin = new Padding(2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(238, 23);
            txtNombre.TabIndex = 0;
            txtNombre.TextChanged += textBox1_TextChanged;
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.White;
            txtApellido.ForeColor = Color.Black;
            txtApellido.Location = new Point(167, 133);
            txtApellido.Margin = new Padding(2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(238, 23);
            txtApellido.TabIndex = 1;
            txtApellido.TextChanged += txtApellido_TextChanged;
            // 
            // dtpFechaNacim
            // 
            dtpFechaNacim.Location = new Point(167, 239);
            dtpFechaNacim.Margin = new Padding(2);
            dtpFechaNacim.Name = "dtpFechaNacim";
            dtpFechaNacim.Size = new Size(238, 23);
            dtpFechaNacim.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(14, 240);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(139, 15);
            label6.TabIndex = 8;
            label6.Text = "FECHA DE NACIMIENTO:";
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.White;
            txtCorreo.ForeColor = Color.Black;
            txtCorreo.Location = new Point(167, 202);
            txtCorreo.Margin = new Padding(2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(238, 23);
            txtCorreo.TabIndex = 3;
            txtCorreo.TextChanged += txtCorreo_TextChanged;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.White;
            txtTelefono.ForeColor = Color.Black;
            txtTelefono.Location = new Point(167, 167);
            txtTelefono.Margin = new Padding(2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(239, 23);
            txtTelefono.TabIndex = 2;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(85, 282);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 11;
            label7.Text = "DIRECCIÓN:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(101, 321);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 12;
            label8.Text = "CIUDAD:";
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = Color.White;
            txtDireccion.ForeColor = Color.Black;
            txtDireccion.Location = new Point(167, 280);
            txtDireccion.Margin = new Padding(2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(238, 23);
            txtDireccion.TabIndex = 5;
            txtDireccion.TextChanged += txtDireccion_TextChanged;
            // 
            // cboCIudad
            // 
            cboCIudad.BackColor = Color.White;
            cboCIudad.ForeColor = Color.Black;
            cboCIudad.FormattingEnabled = true;
            cboCIudad.Location = new Point(167, 319);
            cboCIudad.Margin = new Padding(2);
            cboCIudad.Name = "cboCIudad";
            cboCIudad.Size = new Size(238, 23);
            cboCIudad.TabIndex = 6;
            cboCIudad.SelectedIndexChanged += cboCIudad_SelectedIndexChanged;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(64, 0, 0);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(435, 402);
            btnNuevo.Margin = new Padding(2);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(71, 35);
            btnNuevo.TabIndex = 7;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnCargar
            // 
            btnCargar.BackColor = Color.FromArgb(64, 0, 0);
            btnCargar.ForeColor = Color.White;
            btnCargar.Location = new Point(522, 402);
            btnCargar.Margin = new Padding(2);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(71, 35);
            btnCargar.TabIndex = 8;
            btnCargar.Text = "&Guardar";
            btnCargar.UseVisualStyleBackColor = false;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(64, 0, 0);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(1082, 402);
            btnSalir.Margin = new Padding(2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(71, 35);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.FromArgb(64, 0, 0);
            BtnCancelar.ForeColor = Color.White;
            BtnCancelar.Location = new Point(987, 402);
            BtnCancelar.Margin = new Padding(2);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(71, 35);
            BtnCancelar.TabIndex = 10;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // dgvCliente
            // 
            dgvCliente.AllowUserToAddRows = false;
            dgvCliente.AllowUserToDeleteRows = false;
            dgvCliente.BackgroundColor = Color.Gray;
            dgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCliente.Columns.AddRange(new DataGridViewColumn[] { ColNombre, ColApellido, ColCorreo, ColNacimiento });
            dgvCliente.Location = new Point(435, 61);
            dgvCliente.Margin = new Padding(2);
            dgvCliente.Name = "dgvCliente";
            dgvCliente.ReadOnly = true;
            dgvCliente.RowHeadersWidth = 62;
            dgvCliente.RowTemplate.Height = 33;
            dgvCliente.Size = new Size(716, 322);
            dgvCliente.TabIndex = 20;
            // 
            // ColNombre
            // 
            ColNombre.HeaderText = "Nombre";
            ColNombre.MinimumWidth = 8;
            ColNombre.Name = "ColNombre";
            ColNombre.ReadOnly = true;
            ColNombre.Width = 250;
            // 
            // ColApellido
            // 
            ColApellido.HeaderText = "Apellido";
            ColApellido.MinimumWidth = 8;
            ColApellido.Name = "ColApellido";
            ColApellido.ReadOnly = true;
            ColApellido.Width = 250;
            // 
            // ColCorreo
            // 
            ColCorreo.HeaderText = "Email";
            ColCorreo.MinimumWidth = 8;
            ColCorreo.Name = "ColCorreo";
            ColCorreo.ReadOnly = true;
            ColCorreo.Width = 270;
            // 
            // ColNacimiento
            // 
            ColNacimiento.HeaderText = "Fecha de Nacimiento";
            ColNacimiento.MinimumWidth = 8;
            ColNacimiento.Name = "ColNacimiento";
            ColNacimiento.ReadOnly = true;
            ColNacimiento.Resizable = DataGridViewTriState.True;
            ColNacimiento.SortMode = DataGridViewColumnSortMode.NotSortable;
            ColNacimiento.Width = 200;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(64, 0, 0);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(613, 402);
            btnActualizar.Margin = new Padding(2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(71, 35);
            btnActualizar.TabIndex = 9;
            btnActualizar.Text = "&Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(22, 47);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(184, 22);
            label9.TabIndex = 23;
            label9.Text = "CARGAR CLIENTE";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { funcionesToolStripMenuItem, peliculaToolStripMenuItem, clienteToolStripMenuItem, funcionesToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(1157, 24);
            menuStrip1.TabIndex = 24;
            menuStrip1.Text = "menuStrip1";
            // 
            // funcionesToolStripMenuItem
            // 
            funcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevaReservaToolStripMenuItem, eliminarReservaToolStripMenuItem, historialReservasToolStripMenuItem });
            funcionesToolStripMenuItem.Name = "funcionesToolStripMenuItem";
            funcionesToolStripMenuItem.Size = new Size(59, 22);
            funcionesToolStripMenuItem.Text = "Reserva";
            // 
            // nuevaReservaToolStripMenuItem
            // 
            nuevaReservaToolStripMenuItem.Name = "nuevaReservaToolStripMenuItem";
            nuevaReservaToolStripMenuItem.Size = new Size(166, 22);
            nuevaReservaToolStripMenuItem.Text = "Nueva Reserva";
            // 
            // eliminarReservaToolStripMenuItem
            // 
            eliminarReservaToolStripMenuItem.Name = "eliminarReservaToolStripMenuItem";
            eliminarReservaToolStripMenuItem.Size = new Size(166, 22);
            eliminarReservaToolStripMenuItem.Text = "Eliminar Reserva";
            // 
            // historialReservasToolStripMenuItem
            // 
            historialReservasToolStripMenuItem.Name = "historialReservasToolStripMenuItem";
            historialReservasToolStripMenuItem.Size = new Size(166, 22);
            historialReservasToolStripMenuItem.Text = "Historial Reservas";
            // 
            // peliculaToolStripMenuItem
            // 
            peliculaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarPeliculaToolStripMenuItem, eliminarPeliculaToolStripMenuItem });
            peliculaToolStripMenuItem.Name = "peliculaToolStripMenuItem";
            peliculaToolStripMenuItem.Size = new Size(60, 22);
            peliculaToolStripMenuItem.Text = "Pelicula";
            // 
            // agregarPeliculaToolStripMenuItem
            // 
            agregarPeliculaToolStripMenuItem.Name = "agregarPeliculaToolStripMenuItem";
            agregarPeliculaToolStripMenuItem.Size = new Size(161, 22);
            agregarPeliculaToolStripMenuItem.Text = "Agregar Pelicula";
            agregarPeliculaToolStripMenuItem.Click += agregarPeliculaToolStripMenuItem_Click;
            // 
            // eliminarPeliculaToolStripMenuItem
            // 
            eliminarPeliculaToolStripMenuItem.Name = "eliminarPeliculaToolStripMenuItem";
            eliminarPeliculaToolStripMenuItem.Size = new Size(161, 22);
            eliminarPeliculaToolStripMenuItem.Text = "Eliminar Pelicula";
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarClienteToolStripMenuItem, modificarClienteToolStripMenuItem });
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(56, 22);
            clienteToolStripMenuItem.Text = "Cliente";
            // 
            // agregarClienteToolStripMenuItem
            // 
            agregarClienteToolStripMenuItem.Name = "agregarClienteToolStripMenuItem";
            agregarClienteToolStripMenuItem.Size = new Size(165, 22);
            agregarClienteToolStripMenuItem.Text = "Agregar Cliente";
            // 
            // modificarClienteToolStripMenuItem
            // 
            modificarClienteToolStripMenuItem.Name = "modificarClienteToolStripMenuItem";
            modificarClienteToolStripMenuItem.Size = new Size(165, 22);
            modificarClienteToolStripMenuItem.Text = "Modificar Cliente";
            // 
            // funcionesToolStripMenuItem1
            // 
            funcionesToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { agregarFuncionToolStripMenuItem, eliminarFuncionToolStripMenuItem, verTodasLasFuncionesToolStripMenuItem });
            funcionesToolStripMenuItem1.Name = "funcionesToolStripMenuItem1";
            funcionesToolStripMenuItem1.Size = new Size(73, 22);
            funcionesToolStripMenuItem1.Text = "Funciones";
            // 
            // agregarFuncionToolStripMenuItem
            // 
            agregarFuncionToolStripMenuItem.Name = "agregarFuncionToolStripMenuItem";
            agregarFuncionToolStripMenuItem.Size = new Size(196, 22);
            agregarFuncionToolStripMenuItem.Text = "Agregar Funcion";
            // 
            // eliminarFuncionToolStripMenuItem
            // 
            eliminarFuncionToolStripMenuItem.Name = "eliminarFuncionToolStripMenuItem";
            eliminarFuncionToolStripMenuItem.Size = new Size(196, 22);
            eliminarFuncionToolStripMenuItem.Text = "Eliminar Funcion";
            // 
            // verTodasLasFuncionesToolStripMenuItem
            // 
            verTodasLasFuncionesToolStripMenuItem.Name = "verTodasLasFuncionesToolStripMenuItem";
            verTodasLasFuncionesToolStripMenuItem.Size = new Size(196, 22);
            verTodasLasFuncionesToolStripMenuItem.Text = "Ver todas las Funciones";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(440, 37);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 26;
            label1.Text = "TODOS LOS CLIENTES";
            // 
            // ClienteFormulario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1157, 449);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(label9);
            Controls.Add(btnActualizar);
            Controls.Add(dgvCliente);
            Controls.Add(BtnCancelar);
            Controls.Add(btnSalir);
            Controls.Add(btnCargar);
            Controls.Add(btnNuevo);
            Controls.Add(cboCIudad);
            Controls.Add(txtDireccion);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtTelefono);
            Controls.Add(txtCorreo);
            Controls.Add(label6);
            Controls.Add(dtpFechaNacim);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2);
            Name = "ClienteFormulario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClienteFormulario";
            Load += ClienteFormulario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCliente).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Label label1;
        private DataGridViewTextBoxColumn ColNombre;
        private DataGridViewTextBoxColumn ColApellido;
        private DataGridViewTextBoxColumn ColCorreo;
        private DataGridViewTextBoxColumn ColNacimiento;
    }
}