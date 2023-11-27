namespace CineWheyForms.Presentaciones
{
    partial class ReservasPorGenero
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
            Button btnNuevaBusqueda;
            Button btnSalir;
            Button btnBuscar;
            dataGridView1 = new DataGridView();
            ColCantidadR = new DataGridViewTextBoxColumn();
            ColTitulo = new DataGridViewTextBoxColumn();
            ColDirector = new DataGridViewTextBoxColumn();
            ColGenero = new DataGridViewTextBoxColumn();
            ColTotalRecaudado = new DataGridViewTextBoxColumn();
            cboGenero = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            lblRecaudado = new Label();
            txtTotal = new TextBox();
            btnNuevaBusqueda = new Button();
            btnSalir = new Button();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnNuevaBusqueda
            // 
            btnNuevaBusqueda.Anchor = AnchorStyles.None;
            btnNuevaBusqueda.BackColor = Color.FromArgb(64, 0, 0);
            btnNuevaBusqueda.ForeColor = Color.White;
            btnNuevaBusqueda.Location = new Point(95, 417);
            btnNuevaBusqueda.Margin = new Padding(2);
            btnNuevaBusqueda.Name = "btnNuevaBusqueda";
            btnNuevaBusqueda.Size = new Size(122, 36);
            btnNuevaBusqueda.TabIndex = 2;
            btnNuevaBusqueda.Text = "&Nueva busqueda";
            btnNuevaBusqueda.UseVisualStyleBackColor = false;
            btnNuevaBusqueda.Click += btnNuevaBusqueda_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.None;
            btnSalir.BackColor = Color.FromArgb(64, 0, 0);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(754, 426);
            btnSalir.Margin = new Padding(2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(101, 36);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "&Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.None;
            btnBuscar.BackColor = Color.FromArgb(64, 0, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(734, 85);
            btnBuscar.Margin = new Padding(2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(121, 37);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.BackgroundColor = Color.FromArgb(64, 64, 64);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColCantidadR, ColTitulo, ColDirector, ColGenero, ColTotalRecaudado });
            dataGridView1.GridColor = Color.FromArgb(64, 64, 64);
            dataGridView1.Location = new Point(95, 130);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(760, 245);
            dataGridView1.TabIndex = 2;
            // 
            // ColCantidadR
            // 
            ColCantidadR.HeaderText = "Cantidad de Reservas";
            ColCantidadR.MinimumWidth = 8;
            ColCantidadR.Name = "ColCantidadR";
            ColCantidadR.ReadOnly = true;
            ColCantidadR.Width = 180;
            // 
            // ColTitulo
            // 
            ColTitulo.HeaderText = "Pelicula";
            ColTitulo.MinimumWidth = 8;
            ColTitulo.Name = "ColTitulo";
            ColTitulo.ReadOnly = true;
            ColTitulo.Width = 250;
            // 
            // ColDirector
            // 
            ColDirector.HeaderText = "Director";
            ColDirector.MinimumWidth = 8;
            ColDirector.Name = "ColDirector";
            ColDirector.ReadOnly = true;
            ColDirector.Width = 230;
            // 
            // ColGenero
            // 
            ColGenero.HeaderText = "Genero";
            ColGenero.MinimumWidth = 8;
            ColGenero.Name = "ColGenero";
            ColGenero.ReadOnly = true;
            ColGenero.Width = 170;
            // 
            // ColTotalRecaudado
            // 
            ColTotalRecaudado.HeaderText = "Recaudado por Pelicula";
            ColTotalRecaudado.MinimumWidth = 8;
            ColTotalRecaudado.Name = "ColTotalRecaudado";
            ColTotalRecaudado.ReadOnly = true;
            ColTotalRecaudado.Width = 190;
            // 
            // cboGenero
            // 
            cboGenero.Anchor = AnchorStyles.None;
            cboGenero.BackColor = Color.White;
            cboGenero.ForeColor = Color.Black;
            cboGenero.FormattingEnabled = true;
            cboGenero.Location = new Point(149, 93);
            cboGenero.Margin = new Padding(2);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(196, 23);
            cboGenero.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(90, 96);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 4;
            label1.Text = "GÈNERO:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(32, 36);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(244, 22);
            label2.TabIndex = 6;
            label2.Text = "RESERVAS POR GÈNERO";
            // 
            // lblRecaudado
            // 
            lblRecaudado.Anchor = AnchorStyles.None;
            lblRecaudado.AutoSize = true;
            lblRecaudado.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblRecaudado.ForeColor = Color.White;
            lblRecaudado.Location = new Point(494, 386);
            lblRecaudado.Margin = new Padding(2, 0, 2, 0);
            lblRecaudado.Name = "lblRecaudado";
            lblRecaudado.Size = new Size(222, 22);
            lblRecaudado.TabIndex = 7;
            lblRecaudado.Text = "TOTAL RECAUDADO: $";
            // 
            // txtTotal
            // 
            txtTotal.Anchor = AnchorStyles.None;
            txtTotal.BackColor = Color.White;
            txtTotal.ForeColor = Color.Black;
            txtTotal.Location = new Point(720, 385);
            txtTotal.Margin = new Padding(2);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(135, 23);
            txtTotal.TabIndex = 4;
            // 
            // ReservasPorGenero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(944, 506);
            Controls.Add(txtTotal);
            Controls.Add(lblRecaudado);
            Controls.Add(label2);
            Controls.Add(btnBuscar);
            Controls.Add(label1);
            Controls.Add(cboGenero);
            Controls.Add(dataGridView1);
            Controls.Add(btnSalir);
            Controls.Add(btnNuevaBusqueda);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2);
            Name = "ReservasPorGenero";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReservasPorGenero";
            Load += ReservasPorGenero_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNuevaBusqueda;
        private Button btnSalir;
        private DataGridView dataGridView1;
        private ComboBox cboGenero;
        private Label label1;
        private Button btnBuscar;
        private Label label2;
        private DataGridViewTextBoxColumn ColCantidadR;
        private DataGridViewTextBoxColumn ColTitulo;
        private DataGridViewTextBoxColumn ColDirector;
        private DataGridViewTextBoxColumn ColGenero;
        private DataGridViewTextBoxColumn ColTotalRecaudado;
        private Label lblRecaudado;
        private TextBox txtTotal;
    }
}