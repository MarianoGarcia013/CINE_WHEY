namespace CineWheyForms.Presentaciones
{
    partial class ReservasFechasForm
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
            dataGridView1 = new DataGridView();
            ColPelicula = new DataGridViewTextBoxColumn();
            ColDirector = new DataGridViewTextBoxColumn();
            ColGenero = new DataGridViewTextBoxColumn();
            ColReserva = new DataGridViewTextBoxColumn();
            ColCliente = new DataGridViewTextBoxColumn();
            btnBuscar = new Button();
            dtpHasta = new DateTimePicker();
            dtpDesde = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCanidadReservas = new TextBox();
            btnNuevaBusqueda = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColPelicula, ColDirector, ColGenero, ColReserva, ColCliente });
            dataGridView1.Location = new Point(44, 152);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(863, 215);
            dataGridView1.TabIndex = 0;
            // 
            // ColPelicula
            // 
            ColPelicula.HeaderText = "Pelicula";
            ColPelicula.MinimumWidth = 8;
            ColPelicula.Name = "ColPelicula";
            ColPelicula.ReadOnly = true;
            ColPelicula.Width = 200;
            // 
            // ColDirector
            // 
            ColDirector.HeaderText = "Director";
            ColDirector.MinimumWidth = 8;
            ColDirector.Name = "ColDirector";
            ColDirector.ReadOnly = true;
            ColDirector.Width = 150;
            // 
            // ColGenero
            // 
            ColGenero.HeaderText = "Genero";
            ColGenero.MinimumWidth = 8;
            ColGenero.Name = "ColGenero";
            ColGenero.ReadOnly = true;
            ColGenero.Width = 150;
            // 
            // ColReserva
            // 
            ColReserva.HeaderText = "Reserva";
            ColReserva.MinimumWidth = 8;
            ColReserva.Name = "ColReserva";
            ColReserva.ReadOnly = true;
            ColReserva.Width = 150;
            // 
            // ColCliente
            // 
            ColCliente.HeaderText = "Cliente";
            ColCliente.MinimumWidth = 8;
            ColCliente.Name = "ColCliente";
            ColCliente.ReadOnly = true;
            ColCliente.Width = 150;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.None;
            btnBuscar.BackColor = Color.FromArgb(64, 0, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(725, 85);
            btnBuscar.Margin = new Padding(2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(182, 55);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "&Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dtpHasta
            // 
            dtpHasta.Anchor = AnchorStyles.None;
            dtpHasta.Location = new Point(450, 115);
            dtpHasta.Margin = new Padding(2);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(271, 23);
            dtpHasta.TabIndex = 1;
            // 
            // dtpDesde
            // 
            dtpDesde.Anchor = AnchorStyles.None;
            dtpDesde.Location = new Point(450, 88);
            dtpDesde.Margin = new Padding(2);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(271, 23);
            dtpDesde.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(362, 91);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 6;
            label1.Text = "FECHA DESDE:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(359, 118);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 7;
            label2.Text = "FECHA HASTA:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(44, 41);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(251, 22);
            label3.TabIndex = 8;
            label3.Text = "HISTORIAL DE RESERVAS";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(554, 386);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(221, 19);
            label4.TabIndex = 9;
            label4.Text = "RESERVAS ENCONTRADAS:";
            // 
            // txtCanidadReservas
            // 
            txtCanidadReservas.BackColor = Color.White;
            txtCanidadReservas.ForeColor = Color.Black;
            txtCanidadReservas.Location = new Point(786, 384);
            txtCanidadReservas.Margin = new Padding(2);
            txtCanidadReservas.Name = "txtCanidadReservas";
            txtCanidadReservas.Size = new Size(123, 23);
            txtCanidadReservas.TabIndex = 10;
            // 
            // btnNuevaBusqueda
            // 
            btnNuevaBusqueda.Anchor = AnchorStyles.None;
            btnNuevaBusqueda.BackColor = Color.FromArgb(64, 0, 0);
            btnNuevaBusqueda.ForeColor = Color.White;
            btnNuevaBusqueda.Location = new Point(44, 417);
            btnNuevaBusqueda.Margin = new Padding(2);
            btnNuevaBusqueda.Name = "btnNuevaBusqueda";
            btnNuevaBusqueda.Size = new Size(138, 46);
            btnNuevaBusqueda.TabIndex = 3;
            btnNuevaBusqueda.Text = "&Nueva Búsqueda";
            btnNuevaBusqueda.UseVisualStyleBackColor = false;
            btnNuevaBusqueda.Click += btnNuevaBusqueda_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.None;
            btnSalir.BackColor = Color.FromArgb(64, 0, 0);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(788, 422);
            btnSalir.Margin = new Padding(2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(121, 41);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "&Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // ReservasFechasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(937, 498);
            Controls.Add(btnSalir);
            Controls.Add(btnNuevaBusqueda);
            Controls.Add(txtCanidadReservas);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpDesde);
            Controls.Add(dtpHasta);
            Controls.Add(btnBuscar);
            Controls.Add(dataGridView1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2);
            Name = "ReservasFechasForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReservasPorFechas";
            Load += ReservasFechasForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dtpDesde;
        private DateTimePicker dtpHasta;
        private Button btnBuscar;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridViewTextBoxColumn ColPelicula;
        private DataGridViewTextBoxColumn ColDirector;
        private DataGridViewTextBoxColumn ColGenero;
        private DataGridViewTextBoxColumn ColReserva;
        private DataGridViewTextBoxColumn ColCliente;
        private Label label4;
        private TextBox txtCanidadReservas;
        private Button btnNuevaBusqueda;
        private Button btnSalir;
    }
}