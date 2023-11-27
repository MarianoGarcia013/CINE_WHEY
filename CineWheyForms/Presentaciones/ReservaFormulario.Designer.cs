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
            btnAGREGAR = new Button();
            btnSalir = new Button();
            btnCargar = new Button();
            nudCantidad = new NumericUpDown();
            dtpFecha = new DateTimePicker();
            cboFuncion = new ComboBox();
            dataGridView1 = new DataGridView();
            ColCliente = new DataGridViewTextBoxColumn();
            ColFuncion = new DataGridViewTextBoxColumn();
            ColFecha = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colAccion = new DataGridViewButtonColumn();
            cboCliente = new ComboBox();
            lblCantidad = new Label();
            lblFecha = new Label();
            lblFuncion = new Label();
            lblCliente = new Label();
            menuStrip1 = new MenuStrip();
            funcionesToolStripMenuItem = new ToolStripMenuItem();
            nuevaReservaToolStripMenuItem = new ToolStripMenuItem();
            eliminarReservaToolStripMenuItem = new ToolStripMenuItem();
            historialReservasToolStripMenuItem = new ToolStripMenuItem();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAGREGAR
            // 
            btnAGREGAR.Anchor = AnchorStyles.None;
            btnAGREGAR.BackColor = Color.FromArgb(64, 0, 0);
            btnAGREGAR.ForeColor = Color.White;
            btnAGREGAR.Location = new Point(706, 125);
            btnAGREGAR.Name = "btnAGREGAR";
            btnAGREGAR.Size = new Size(174, 35);
            btnAGREGAR.TabIndex = 4;
            btnAGREGAR.Text = "AGREGAR";
            btnAGREGAR.UseVisualStyleBackColor = false;
            btnAGREGAR.Click += btnAGREGAR_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.None;
            btnSalir.BackColor = Color.FromArgb(64, 0, 0);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(786, 409);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 35);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "&Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnCargar
            // 
            btnCargar.Anchor = AnchorStyles.None;
            btnCargar.BackColor = Color.FromArgb(64, 0, 0);
            btnCargar.ForeColor = Color.White;
            btnCargar.Location = new Point(677, 409);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(94, 35);
            btnCargar.TabIndex = 6;
            btnCargar.Text = "&Cargar";
            btnCargar.UseVisualStyleBackColor = false;
            btnCargar.Click += btnCargar_Click;
            // 
            // nudCantidad
            // 
            nudCantidad.Anchor = AnchorStyles.None;
            nudCantidad.Location = new Point(534, 129);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(166, 23);
            nudCantidad.TabIndex = 3;
            nudCantidad.ValueChanged += nudCantidad_ValueChanged;
            // 
            // dtpFecha
            // 
            dtpFecha.Anchor = AnchorStyles.None;
            dtpFecha.Location = new Point(536, 92);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(344, 23);
            dtpFecha.TabIndex = 2;
            dtpFecha.ValueChanged += dtpFecha_ValueChanged;
            // 
            // cboFuncion
            // 
            cboFuncion.Anchor = AnchorStyles.None;
            cboFuncion.FormattingEnabled = true;
            cboFuncion.Location = new Point(127, 128);
            cboFuncion.Name = "cboFuncion";
            cboFuncion.Size = new Size(285, 23);
            cboFuncion.TabIndex = 1;
            cboFuncion.SelectedIndexChanged += cboFuncion_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.ColumnHeadersHeight = 34;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColCliente, ColFuncion, ColFecha, colCantidad, colAccion });
            dataGridView1.Location = new Point(41, 165);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.Size = new Size(839, 238);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ColCliente
            // 
            ColCliente.HeaderText = "Cliente";
            ColCliente.MinimumWidth = 8;
            ColCliente.Name = "ColCliente";
            ColCliente.ReadOnly = true;
            ColCliente.Width = 200;
            // 
            // ColFuncion
            // 
            ColFuncion.HeaderText = "Funcion";
            ColFuncion.MinimumWidth = 8;
            ColFuncion.Name = "ColFuncion";
            ColFuncion.ReadOnly = true;
            ColFuncion.Width = 180;
            // 
            // ColFecha
            // 
            ColFecha.HeaderText = "Fecha";
            ColFecha.MinimumWidth = 8;
            ColFecha.Name = "ColFecha";
            ColFecha.ReadOnly = true;
            ColFecha.Width = 150;
            // 
            // colCantidad
            // 
            colCantidad.HeaderText = "Cantidad";
            colCantidad.MinimumWidth = 8;
            colCantidad.Name = "colCantidad";
            colCantidad.ReadOnly = true;
            colCantidad.Width = 150;
            // 
            // colAccion
            // 
            colAccion.HeaderText = "Accion";
            colAccion.MinimumWidth = 8;
            colAccion.Name = "colAccion";
            colAccion.ReadOnly = true;
            colAccion.Text = "Quitar";
            colAccion.UseColumnTextForButtonValue = true;
            colAccion.Width = 150;
            // 
            // cboCliente
            // 
            cboCliente.Anchor = AnchorStyles.None;
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(127, 96);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(285, 23);
            cboCliente.TabIndex = 0;
            cboCliente.SelectedIndexChanged += cboCliente_SelectedIndexChanged;
            // 
            // lblCantidad
            // 
            lblCantidad.Anchor = AnchorStyles.None;
            lblCantidad.AutoSize = true;
            lblCantidad.ForeColor = Color.White;
            lblCantidad.Location = new Point(453, 132);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(69, 15);
            lblCantidad.TabIndex = 16;
            lblCantidad.Text = "CANTIDAD:";
            lblCantidad.UseWaitCursor = true;
            lblCantidad.Click += lblCantidad_Click;
            // 
            // lblFecha
            // 
            lblFecha.Anchor = AnchorStyles.None;
            lblFecha.AutoSize = true;
            lblFecha.ForeColor = Color.White;
            lblFecha.Location = new Point(475, 97);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(47, 15);
            lblFecha.TabIndex = 14;
            lblFecha.Text = "FECHA:";
            lblFecha.Click += lblFecha_Click;
            // 
            // lblFuncion
            // 
            lblFuncion.Anchor = AnchorStyles.None;
            lblFuncion.AutoSize = true;
            lblFuncion.ForeColor = Color.White;
            lblFuncion.Location = new Point(45, 132);
            lblFuncion.Name = "lblFuncion";
            lblFuncion.Size = new Size(62, 15);
            lblFuncion.TabIndex = 12;
            lblFuncion.Text = "FUNCIÓN:";
            lblFuncion.Click += lblFuncion_Click;
            // 
            // lblCliente
            // 
            lblCliente.Anchor = AnchorStyles.None;
            lblCliente.AutoSize = true;
            lblCliente.ForeColor = Color.White;
            lblCliente.Location = new Point(52, 99);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(55, 15);
            lblCliente.TabIndex = 10;
            lblCliente.Text = "CLIENTE:";
            lblCliente.Click += lblCliente_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(64, 64, 64);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { funcionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(923, 24);
            menuStrip1.TabIndex = 20;
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
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(41, 46);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(228, 22);
            label9.TabIndex = 24;
            label9.Text = "REGISTRAR RESERVAS";
            label9.Click += label9_Click;
            // 
            // ReservaFormulario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(923, 469);
            Controls.Add(label9);
            Controls.Add(menuStrip1);
            Controls.Add(btnAGREGAR);
            Controls.Add(btnSalir);
            Controls.Add(btnCargar);
            Controls.Add(nudCantidad);
            Controls.Add(dtpFecha);
            Controls.Add(cboFuncion);
            Controls.Add(dataGridView1);
            Controls.Add(cboCliente);
            Controls.Add(lblCantidad);
            Controls.Add(lblFecha);
            Controls.Add(lblFuncion);
            Controls.Add(lblCliente);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2);
            Name = "ReservaFormulario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReservaFormulario";
            Load += ReservaFormulario_Load;
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Label label9;
        private DataGridViewTextBoxColumn ColCliente;
        private DataGridViewTextBoxColumn ColFuncion;
        private DataGridViewTextBoxColumn ColFecha;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewButtonColumn colAccion;
    }
}