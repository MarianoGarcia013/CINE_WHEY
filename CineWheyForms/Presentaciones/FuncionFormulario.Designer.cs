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
            menuStrip1 = new MenuStrip();
            btnNueva = new Button();
            btnSalir = new Button();
            lblFuncion = new Label();
            lstBoxFunciones = new ListBox();
            btnBorrar = new Button();
            btnActualizar = new Button();
            btnCancelar = new Button();
            btnAgregarF = new Button();
            txtHoraInicio = new TextBox();
            dtpFecha = new DateTimePicker();
            txtPrecio = new TextBox();
            lblHora_Inicio = new Label();
            lblFecha = new Label();
            lblPrecio = new Label();
            lblSala = new Label();
            lblPelicula = new Label();
            cboSala = new ComboBox();
            cboPelicula = new ComboBox();
            label1 = new Label();
            txtDescripcion = new TextBox();
            label2 = new Label();
            txtId = new TextBox();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(64, 64, 64);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(945, 24);
            menuStrip1.TabIndex = 26;
            menuStrip1.Text = "menuStrip1";
            // 
            // btnNueva
            // 
            btnNueva.Anchor = AnchorStyles.None;
            btnNueva.BackColor = Color.FromArgb(64, 0, 0);
            btnNueva.Location = new Point(373, 330);
            btnNueva.Name = "btnNueva";
            btnNueva.Size = new Size(75, 38);
            btnNueva.TabIndex = 7;
            btnNueva.Text = "&Nueva";
            btnNueva.UseVisualStyleBackColor = false;
            btnNueva.Click += btnNueva_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.None;
            btnSalir.BackColor = Color.FromArgb(64, 0, 0);
            btnSalir.Location = new Point(830, 331);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 38);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "&Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblFuncion
            // 
            lblFuncion.Anchor = AnchorStyles.None;
            lblFuncion.AutoSize = true;
            lblFuncion.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblFuncion.Location = new Point(43, 43);
            lblFuncion.Name = "lblFuncion";
            lblFuncion.Size = new Size(187, 22);
            lblFuncion.TabIndex = 60;
            lblFuncion.Text = "CARGAR FUNCIÓN";
            // 
            // lstBoxFunciones
            // 
            lstBoxFunciones.Anchor = AnchorStyles.None;
            lstBoxFunciones.BackColor = Color.FromArgb(224, 224, 224);
            lstBoxFunciones.FormattingEnabled = true;
            lstBoxFunciones.ItemHeight = 15;
            lstBoxFunciones.Location = new Point(457, 72);
            lstBoxFunciones.Name = "lstBoxFunciones";
            lstBoxFunciones.Size = new Size(447, 244);
            lstBoxFunciones.TabIndex = 13;
            lstBoxFunciones.SelectedIndexChanged += lstBoxFunciones_SelectedIndexChanged;
            // 
            // btnBorrar
            // 
            btnBorrar.Anchor = AnchorStyles.None;
            btnBorrar.BackColor = Color.FromArgb(64, 0, 0);
            btnBorrar.Location = new Point(616, 330);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 38);
            btnBorrar.TabIndex = 10;
            btnBorrar.Text = "&Borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.None;
            btnActualizar.BackColor = Color.FromArgb(64, 0, 0);
            btnActualizar.Location = new Point(535, 330);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 38);
            btnActualizar.TabIndex = 9;
            btnActualizar.Text = "&Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.BackColor = Color.FromArgb(64, 0, 0);
            btnCancelar.Location = new Point(748, 331);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 38);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAgregarF
            // 
            btnAgregarF.Anchor = AnchorStyles.None;
            btnAgregarF.BackColor = Color.FromArgb(64, 0, 0);
            btnAgregarF.Location = new Point(454, 330);
            btnAgregarF.Name = "btnAgregarF";
            btnAgregarF.Size = new Size(75, 38);
            btnAgregarF.TabIndex = 8;
            btnAgregarF.Text = "&Guardar";
            btnAgregarF.UseVisualStyleBackColor = false;
            btnAgregarF.Click += btnAgregarF_Click_1;
            // 
            // txtHoraInicio
            // 
            txtHoraInicio.Anchor = AnchorStyles.None;
            txtHoraInicio.BackColor = Color.White;
            txtHoraInicio.Location = new Point(168, 277);
            txtHoraInicio.Name = "txtHoraInicio";
            txtHoraInicio.Size = new Size(135, 23);
            txtHoraInicio.TabIndex = 6;
            // 
            // dtpFecha
            // 
            dtpFecha.Anchor = AnchorStyles.None;
            dtpFecha.Location = new Point(168, 209);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(260, 23);
            dtpFecha.TabIndex = 4;
            // 
            // txtPrecio
            // 
            txtPrecio.Anchor = AnchorStyles.None;
            txtPrecio.BackColor = Color.White;
            txtPrecio.ForeColor = Color.Black;
            txtPrecio.Location = new Point(168, 176);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(135, 23);
            txtPrecio.TabIndex = 3;
            // 
            // lblHora_Inicio
            // 
            lblHora_Inicio.Anchor = AnchorStyles.None;
            lblHora_Inicio.AutoSize = true;
            lblHora_Inicio.Location = new Point(43, 281);
            lblHora_Inicio.Name = "lblHora_Inicio";
            lblHora_Inicio.Size = new Size(101, 15);
            lblHora_Inicio.TabIndex = 56;
            lblHora_Inicio.Text = "HORA DE INICIO: ";
            // 
            // lblFecha
            // 
            lblFecha.Anchor = AnchorStyles.None;
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(93, 214);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(47, 15);
            lblFecha.TabIndex = 55;
            lblFecha.Text = "FECHA:";
            // 
            // lblPrecio
            // 
            lblPrecio.Anchor = AnchorStyles.None;
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(90, 181);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(50, 15);
            lblPrecio.TabIndex = 53;
            lblPrecio.Text = "PRECIO:";
            // 
            // lblSala
            // 
            lblSala.Anchor = AnchorStyles.None;
            lblSala.AutoSize = true;
            lblSala.Location = new Point(102, 149);
            lblSala.Name = "lblSala";
            lblSala.Size = new Size(38, 15);
            lblSala.TabIndex = 51;
            lblSala.Text = "SALA:";
            // 
            // lblPelicula
            // 
            lblPelicula.Anchor = AnchorStyles.None;
            lblPelicula.AutoSize = true;
            lblPelicula.Location = new Point(78, 117);
            lblPelicula.Name = "lblPelicula";
            lblPelicula.Size = new Size(62, 15);
            lblPelicula.TabIndex = 49;
            lblPelicula.Text = "PELICULA:";
            // 
            // cboSala
            // 
            cboSala.Anchor = AnchorStyles.None;
            cboSala.BackColor = Color.White;
            cboSala.ForeColor = Color.Black;
            cboSala.FormattingEnabled = true;
            cboSala.Location = new Point(168, 145);
            cboSala.Name = "cboSala";
            cboSala.Size = new Size(198, 23);
            cboSala.TabIndex = 2;
            // 
            // cboPelicula
            // 
            cboPelicula.Anchor = AnchorStyles.None;
            cboPelicula.BackColor = Color.White;
            cboPelicula.ForeColor = Color.Black;
            cboPelicula.FormattingEnabled = true;
            cboPelicula.Location = new Point(168, 114);
            cboPelicula.Name = "cboPelicula";
            cboPelicula.Size = new Size(262, 23);
            cboPelicula.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(57, 249);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 63;
            label1.Text = "DESCRIPCIÓN:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Anchor = AnchorStyles.None;
            txtDescripcion.BackColor = Color.White;
            txtDescripcion.Location = new Point(168, 244);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(260, 23);
            txtDescripcion.TabIndex = 5;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(87, 88);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 65;
            label2.Text = "CODIGO:";
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.None;
            txtId.BackColor = Color.White;
            txtId.ForeColor = Color.Black;
            txtId.Location = new Point(168, 84);
            txtId.Name = "txtId";
            txtId.Size = new Size(128, 23);
            txtId.TabIndex = 0;
            // 
            // FuncionFormulario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(945, 399);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(txtDescripcion);
            Controls.Add(label1);
            Controls.Add(btnNueva);
            Controls.Add(btnSalir);
            Controls.Add(lblFuncion);
            Controls.Add(lstBoxFunciones);
            Controls.Add(btnBorrar);
            Controls.Add(btnActualizar);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregarF);
            Controls.Add(txtHoraInicio);
            Controls.Add(dtpFecha);
            Controls.Add(txtPrecio);
            Controls.Add(lblHora_Inicio);
            Controls.Add(lblFecha);
            Controls.Add(lblPrecio);
            Controls.Add(lblSala);
            Controls.Add(lblPelicula);
            Controls.Add(cboSala);
            Controls.Add(cboPelicula);
            Controls.Add(menuStrip1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2);
            Name = "FuncionFormulario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CargarFuncion";
            Load += FuncionFormulario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private Button btnNueva;
        private Button btnSalir;
        private Label lblFuncion;
        private ListBox lstBoxFunciones;
        private Button btnBorrar;
        private Button btnActualizar;
        private Button btnCancelar;
        private Button btnAgregarF;
        private TextBox txtHoraInicio;
        private DateTimePicker dtpFecha;
        private TextBox txtPrecio;
        private Label lblHora_Inicio;
        private Label lblFecha;
        private Label lblPrecio;
        private Label lblSala;
        private Label lblPelicula;
        private ComboBox cboSala;
        private ComboBox cboPelicula;
        private Label label1;
        private TextBox txtDescripcion;
        private Label label2;
        private TextBox txtId;
    }
}