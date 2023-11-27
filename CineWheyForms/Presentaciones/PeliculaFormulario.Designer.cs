namespace CineWheyForms.Presentaciones
{
    partial class PeliculaFormulario
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
            peliculaToolStripMenuItem = new ToolStripMenuItem();
            agregarPeliculaToolStripMenuItem = new ToolStripMenuItem();
            peliculasDiponiblesToolStripMenuItem = new ToolStripMenuItem();
            btnAgregar = new Button();
            lstBoxPelicula = new ListBox();
            btnActualizar = new Button();
            btnSalir = new Button();
            btnBorrar = new Button();
            dtpFechaEstreno = new DateTimePicker();
            btnCancelar = new Button();
            cboIdioma = new ComboBox();
            cboGenero = new ComboBox();
            rbtNo = new RadioButton();
            rbtSi = new RadioButton();
            txtDuracion = new TextBox();
            txtDirector = new TextBox();
            txtTitulo = new TextBox();
            lblAptoTodoPublico = new Label();
            lblIdioma = new Label();
            lblGenero = new Label();
            lblDirector = new Label();
            lblFechaEstreno = new Label();
            lblDuracion = new Label();
            lblTitulo = new Label();
            label6 = new Label();
            btnNueva = new Button();
            label1 = new Label();
            txtCodigo = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(64, 64, 64);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { peliculaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(962, 24);
            menuStrip1.TabIndex = 70;
            menuStrip1.Text = "menuStrip1";
            // 
            // peliculaToolStripMenuItem
            // 
            peliculaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarPeliculaToolStripMenuItem, peliculasDiponiblesToolStripMenuItem });
            peliculaToolStripMenuItem.Name = "peliculaToolStripMenuItem";
            peliculaToolStripMenuItem.Size = new Size(60, 22);
            peliculaToolStripMenuItem.Text = "Pelicula";
            // 
            // agregarPeliculaToolStripMenuItem
            // 
            agregarPeliculaToolStripMenuItem.Name = "agregarPeliculaToolStripMenuItem";
            agregarPeliculaToolStripMenuItem.Size = new Size(179, 22);
            agregarPeliculaToolStripMenuItem.Text = "Agregar Pelicula";
            // 
            // peliculasDiponiblesToolStripMenuItem
            // 
            peliculasDiponiblesToolStripMenuItem.Name = "peliculasDiponiblesToolStripMenuItem";
            peliculasDiponiblesToolStripMenuItem.Size = new Size(179, 22);
            peliculasDiponiblesToolStripMenuItem.Text = "Peliculas Diponibles";
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.None;
            btnAgregar.BackColor = Color.FromArgb(64, 0, 0);
            btnAgregar.Location = new Point(529, 364);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 38);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "&Guardar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // lstBoxPelicula
            // 
            lstBoxPelicula.Anchor = AnchorStyles.None;
            lstBoxPelicula.FormattingEnabled = true;
            lstBoxPelicula.ItemHeight = 15;
            lstBoxPelicula.Location = new Point(451, 66);
            lstBoxPelicula.Name = "lstBoxPelicula";
            lstBoxPelicula.Size = new Size(498, 289);
            lstBoxPelicula.TabIndex = 15;
            lstBoxPelicula.SelectedIndexChanged += lstBoxPelicula_SelectedIndexChanged;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.None;
            btnActualizar.BackColor = Color.FromArgb(64, 0, 0);
            btnActualizar.Location = new Point(624, 364);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 38);
            btnActualizar.TabIndex = 11;
            btnActualizar.Text = "&Actualizar";
            btnActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.None;
            btnSalir.BackColor = Color.FromArgb(64, 0, 0);
            btnSalir.Location = new Point(875, 364);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 38);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "&Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Anchor = AnchorStyles.None;
            btnBorrar.BackColor = Color.FromArgb(64, 0, 0);
            btnBorrar.Location = new Point(702, 364);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 38);
            btnBorrar.TabIndex = 12;
            btnBorrar.Text = "&Borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // dtpFechaEstreno
            // 
            dtpFechaEstreno.Anchor = AnchorStyles.None;
            dtpFechaEstreno.Location = new Point(191, 225);
            dtpFechaEstreno.Name = "dtpFechaEstreno";
            dtpFechaEstreno.Size = new Size(232, 23);
            dtpFechaEstreno.TabIndex = 4;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.BackColor = Color.FromArgb(64, 0, 0);
            btnCancelar.Location = new Point(796, 364);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 38);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // cboIdioma
            // 
            cboIdioma.Anchor = AnchorStyles.None;
            cboIdioma.BackColor = Color.White;
            cboIdioma.FormattingEnabled = true;
            cboIdioma.Location = new Point(193, 293);
            cboIdioma.Name = "cboIdioma";
            cboIdioma.Size = new Size(137, 23);
            cboIdioma.TabIndex = 6;
            // 
            // cboGenero
            // 
            cboGenero.Anchor = AnchorStyles.None;
            cboGenero.BackColor = Color.White;
            cboGenero.FormattingEnabled = true;
            cboGenero.Location = new Point(191, 260);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(152, 23);
            cboGenero.TabIndex = 5;
            // 
            // rbtNo
            // 
            rbtNo.Anchor = AnchorStyles.None;
            rbtNo.AutoSize = true;
            rbtNo.BackColor = Color.FromArgb(64, 0, 0);
            rbtNo.Location = new Point(265, 331);
            rbtNo.Name = "rbtNo";
            rbtNo.Size = new Size(43, 19);
            rbtNo.TabIndex = 8;
            rbtNo.TabStop = true;
            rbtNo.Text = "NO";
            rbtNo.UseVisualStyleBackColor = false;
            // 
            // rbtSi
            // 
            rbtSi.Anchor = AnchorStyles.None;
            rbtSi.AutoSize = true;
            rbtSi.BackColor = Color.FromArgb(64, 0, 0);
            rbtSi.Location = new Point(210, 331);
            rbtSi.Name = "rbtSi";
            rbtSi.Size = new Size(34, 19);
            rbtSi.TabIndex = 7;
            rbtSi.TabStop = true;
            rbtSi.Text = "SI";
            rbtSi.UseVisualStyleBackColor = false;
            // 
            // txtDuracion
            // 
            txtDuracion.Anchor = AnchorStyles.None;
            txtDuracion.BackColor = Color.White;
            txtDuracion.ForeColor = Color.Black;
            txtDuracion.Location = new Point(192, 190);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(100, 23);
            txtDuracion.TabIndex = 3;
            // 
            // txtDirector
            // 
            txtDirector.Anchor = AnchorStyles.None;
            txtDirector.BackColor = Color.White;
            txtDirector.ForeColor = Color.Black;
            txtDirector.Location = new Point(192, 159);
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new Size(232, 23);
            txtDirector.TabIndex = 2;
            // 
            // txtTitulo
            // 
            txtTitulo.Anchor = AnchorStyles.None;
            txtTitulo.BackColor = Color.White;
            txtTitulo.ForeColor = Color.Black;
            txtTitulo.Location = new Point(192, 130);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(232, 23);
            txtTitulo.TabIndex = 1;
            // 
            // lblAptoTodoPublico
            // 
            lblAptoTodoPublico.Anchor = AnchorStyles.None;
            lblAptoTodoPublico.AutoSize = true;
            lblAptoTodoPublico.Location = new Point(147, 332);
            lblAptoTodoPublico.Name = "lblAptoTodoPublico";
            lblAptoTodoPublico.Size = new Size(31, 15);
            lblAptoTodoPublico.TabIndex = 111;
            lblAptoTodoPublico.Text = "ATP:";
            // 
            // lblIdioma
            // 
            lblIdioma.Anchor = AnchorStyles.None;
            lblIdioma.AutoSize = true;
            lblIdioma.Location = new Point(125, 296);
            lblIdioma.Name = "lblIdioma";
            lblIdioma.Size = new Size(52, 15);
            lblIdioma.TabIndex = 110;
            lblIdioma.Text = "IDIOMA:";
            // 
            // lblGenero
            // 
            lblGenero.Anchor = AnchorStyles.None;
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(123, 263);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(55, 15);
            lblGenero.TabIndex = 109;
            lblGenero.Text = "GÉNERO:";
            // 
            // lblDirector
            // 
            lblDirector.Anchor = AnchorStyles.None;
            lblDirector.AutoSize = true;
            lblDirector.Location = new Point(115, 163);
            lblDirector.Name = "lblDirector";
            lblDirector.Size = new Size(64, 15);
            lblDirector.TabIndex = 108;
            lblDirector.Text = "DIRECTOR:";
            // 
            // lblFechaEstreno
            // 
            lblFechaEstreno.Anchor = AnchorStyles.None;
            lblFechaEstreno.AutoSize = true;
            lblFechaEstreno.Location = new Point(61, 228);
            lblFechaEstreno.Name = "lblFechaEstreno";
            lblFechaEstreno.Size = new Size(117, 15);
            lblFechaEstreno.TabIndex = 107;
            lblFechaEstreno.Text = "FECHA DE ESTRENO:";
            // 
            // lblDuracion
            // 
            lblDuracion.Anchor = AnchorStyles.None;
            lblDuracion.AutoSize = true;
            lblDuracion.Location = new Point(109, 194);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new Size(70, 15);
            lblDuracion.TabIndex = 106;
            lblDuracion.Text = "DURACIÓN:";
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(129, 133);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(50, 15);
            lblTitulo.TabIndex = 105;
            lblTitulo.Text = "TÍTULO:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(61, 50);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(205, 22);
            label6.TabIndex = 94;
            label6.Text = "CARGAR PELICULAS";
            // 
            // btnNueva
            // 
            btnNueva.Anchor = AnchorStyles.None;
            btnNueva.BackColor = Color.FromArgb(64, 0, 0);
            btnNueva.Location = new Point(449, 364);
            btnNueva.Name = "btnNueva";
            btnNueva.Size = new Size(75, 38);
            btnNueva.TabIndex = 9;
            btnNueva.Text = "&Nueva";
            btnNueva.UseVisualStyleBackColor = false;
            btnNueva.Click += btnNueva_Click_1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(124, 104);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 118;
            label1.Text = "CÓDIGO:";
            // 
            // txtCodigo
            // 
            txtCodigo.Anchor = AnchorStyles.None;
            txtCodigo.BackColor = Color.White;
            txtCodigo.Location = new Point(192, 101);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 0;
            // 
            // PeliculaFormulario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(962, 446);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            Controls.Add(btnNueva);
            Controls.Add(btnAgregar);
            Controls.Add(lstBoxPelicula);
            Controls.Add(btnActualizar);
            Controls.Add(btnSalir);
            Controls.Add(btnBorrar);
            Controls.Add(dtpFechaEstreno);
            Controls.Add(btnCancelar);
            Controls.Add(cboIdioma);
            Controls.Add(cboGenero);
            Controls.Add(rbtNo);
            Controls.Add(rbtSi);
            Controls.Add(txtDuracion);
            Controls.Add(txtDirector);
            Controls.Add(txtTitulo);
            Controls.Add(lblAptoTodoPublico);
            Controls.Add(lblIdioma);
            Controls.Add(lblGenero);
            Controls.Add(lblDirector);
            Controls.Add(lblFechaEstreno);
            Controls.Add(lblDuracion);
            Controls.Add(lblTitulo);
            Controls.Add(label6);
            Controls.Add(menuStrip1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2);
            Name = "PeliculaFormulario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PeliculaFormulario";
            Load += PeliculaFormulario_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem peliculaToolStripMenuItem;
        private ToolStripMenuItem agregarPeliculaToolStripMenuItem;
        private ToolStripMenuItem peliculasDiponiblesToolStripMenuItem;
        private Button btnAgregar;
        private ListBox lstBoxPelicula;
        private Button btnActualizar;
        private Button btnSalir;
        private Button btnBorrar;
        private DateTimePicker dtpFechaEstreno;
        private Button btnCancelar;
        private ComboBox cboIdioma;
        private ComboBox cboGenero;
        private RadioButton rbtNo;
        private RadioButton rbtSi;
        private TextBox txtDuracion;
        private TextBox txtDirector;
        private TextBox txtTitulo;
        private Label lblAptoTodoPublico;
        private Label lblIdioma;
        private Label lblGenero;
        private Label lblDirector;
        private Label lblFechaEstreno;
        private Label lblDuracion;
        private Label lblTitulo;
        private Label label6;
        private Button btnNueva;
        private Label label1;
        private TextBox txtCodigo;
    }
}