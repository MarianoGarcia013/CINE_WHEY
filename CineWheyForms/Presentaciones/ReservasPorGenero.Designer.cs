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
            System.Windows.Forms.Button btnNuevaBusqueda;
            System.Windows.Forms.Button btnSalir;
            System.Windows.Forms.Button btnBuscar;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColCantidadR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDirector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotalRecaudado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRecaudado = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            btnNuevaBusqueda = new System.Windows.Forms.Button();
            btnSalir = new System.Windows.Forms.Button();
            btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevaBusqueda
            // 
            btnNuevaBusqueda.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnNuevaBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            btnNuevaBusqueda.ForeColor = System.Drawing.Color.White;
            btnNuevaBusqueda.Location = new System.Drawing.Point(86, 734);
            btnNuevaBusqueda.Name = "btnNuevaBusqueda";
            btnNuevaBusqueda.Size = new System.Drawing.Size(174, 49);
            btnNuevaBusqueda.TabIndex = 0;
            btnNuevaBusqueda.Text = "&Nueva busqueda";
            btnNuevaBusqueda.UseVisualStyleBackColor = false;
            btnNuevaBusqueda.Click += new System.EventHandler(this.btnNuevaBusqueda_Click);
            // 
            // btnSalir
            // 
            btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            btnSalir.ForeColor = System.Drawing.Color.White;
            btnSalir.Location = new System.Drawing.Point(1147, 734);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(144, 49);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "&Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            btnBuscar.ForeColor = System.Drawing.Color.White;
            btnBuscar.Location = new System.Drawing.Point(1051, 153);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(173, 61);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCantidadR,
            this.ColTitulo,
            this.ColDirector,
            this.ColGenero,
            this.ColTotalRecaudado});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.Location = new System.Drawing.Point(139, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1085, 409);
            this.dataGridView1.TabIndex = 2;
            // 
            // ColCantidadR
            // 
            this.ColCantidadR.HeaderText = "Cantidad de Reservas";
            this.ColCantidadR.MinimumWidth = 8;
            this.ColCantidadR.Name = "ColCantidadR";
            this.ColCantidadR.ReadOnly = true;
            this.ColCantidadR.Width = 180;
            // 
            // ColTitulo
            // 
            this.ColTitulo.HeaderText = "Pelicula";
            this.ColTitulo.MinimumWidth = 8;
            this.ColTitulo.Name = "ColTitulo";
            this.ColTitulo.ReadOnly = true;
            this.ColTitulo.Width = 250;
            // 
            // ColDirector
            // 
            this.ColDirector.HeaderText = "Director";
            this.ColDirector.MinimumWidth = 8;
            this.ColDirector.Name = "ColDirector";
            this.ColDirector.ReadOnly = true;
            this.ColDirector.Width = 230;
            // 
            // ColGenero
            // 
            this.ColGenero.HeaderText = "Genero";
            this.ColGenero.MinimumWidth = 8;
            this.ColGenero.Name = "ColGenero";
            this.ColGenero.ReadOnly = true;
            this.ColGenero.Width = 170;
            // 
            // ColTotalRecaudado
            // 
            this.ColTotalRecaudado.HeaderText = "Recaudado por Pelicula";
            this.ColTotalRecaudado.MinimumWidth = 8;
            this.ColTotalRecaudado.Name = "ColTotalRecaudado";
            this.ColTotalRecaudado.ReadOnly = true;
            this.ColTotalRecaudado.Width = 190;
            // 
            // cboGenero
            // 
            this.cboGenero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Location = new System.Drawing.Point(225, 168);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(278, 33);
            this.cboGenero.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(132, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "GÈNERO:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "RESERVAS POR GÈNERO";
            // 
            // lblRecaudado
            // 
            this.lblRecaudado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRecaudado.AutoSize = true;
            this.lblRecaudado.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRecaudado.ForeColor = System.Drawing.Color.White;
            this.lblRecaudado.Location = new System.Drawing.Point(708, 646);
            this.lblRecaudado.Name = "lblRecaudado";
            this.lblRecaudado.Size = new System.Drawing.Size(324, 32);
            this.lblRecaudado.TabIndex = 7;
            this.lblRecaudado.Text = "TOTAL RECAUDADO: $";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(1038, 647);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(184, 31);
            this.txtTotal.TabIndex = 8;
            // 
            // ReservasPorGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1354, 795);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblRecaudado);
            this.Controls.Add(this.label2);
            this.Controls.Add(btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboGenero);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(btnSalir);
            this.Controls.Add(btnNuevaBusqueda);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ReservasPorGenero";
            this.Text = "ReservasPorGenero";
            this.Load += new System.EventHandler(this.ReservasPorGenero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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