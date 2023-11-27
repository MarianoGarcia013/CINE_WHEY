namespace CineWheyForms.Presentaciones
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            menuStrip1 = new MenuStrip();
            funcionesToolStripMenuItem = new ToolStripMenuItem();
            nuevaReservaToolStripMenuItem = new ToolStripMenuItem();
            historialReservasToolStripMenuItem = new ToolStripMenuItem();
            consultarPorFechasToolStripMenuItem = new ToolStripMenuItem();
            consultarPorGeneroToolStripMenuItem = new ToolStripMenuItem();
            peliculaToolStripMenuItem = new ToolStripMenuItem();
            agregarPeliculaToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            agregarClienteToolStripMenuItem = new ToolStripMenuItem();
            funcionesToolStripMenuItem1 = new ToolStripMenuItem();
            agregarFuncionToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(64, 0, 0);
            menuStrip1.BackgroundImage = (Image)resources.GetObject("menuStrip1.BackgroundImage");
            menuStrip1.Font = new Font("Lucida Sans", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { funcionesToolStripMenuItem, peliculaToolStripMenuItem, clienteToolStripMenuItem, funcionesToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(759, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // funcionesToolStripMenuItem
            // 
            funcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevaReservaToolStripMenuItem, historialReservasToolStripMenuItem });
            funcionesToolStripMenuItem.Name = "funcionesToolStripMenuItem";
            funcionesToolStripMenuItem.Size = new Size(80, 22);
            funcionesToolStripMenuItem.Text = "Reservas";
            funcionesToolStripMenuItem.Click += funcionesToolStripMenuItem_Click;
            // 
            // nuevaReservaToolStripMenuItem
            // 
            nuevaReservaToolStripMenuItem.Name = "nuevaReservaToolStripMenuItem";
            nuevaReservaToolStripMenuItem.Size = new Size(198, 22);
            nuevaReservaToolStripMenuItem.Text = "Nueva Reserva";
            nuevaReservaToolStripMenuItem.Click += nuevaReservaToolStripMenuItem_Click;
            // 
            // historialReservasToolStripMenuItem
            // 
            historialReservasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consultarPorFechasToolStripMenuItem, consultarPorGeneroToolStripMenuItem });
            historialReservasToolStripMenuItem.Name = "historialReservasToolStripMenuItem";
            historialReservasToolStripMenuItem.Size = new Size(198, 22);
            historialReservasToolStripMenuItem.Text = "Historial Reservas";
            historialReservasToolStripMenuItem.Click += historialReservasToolStripMenuItem_Click;
            // 
            // consultarPorFechasToolStripMenuItem
            // 
            consultarPorFechasToolStripMenuItem.Name = "consultarPorFechasToolStripMenuItem";
            consultarPorFechasToolStripMenuItem.Size = new Size(221, 22);
            consultarPorFechasToolStripMenuItem.Text = "Consultar por Fechas";
            consultarPorFechasToolStripMenuItem.Click += consultarPorFechasToolStripMenuItem_Click;
            // 
            // consultarPorGeneroToolStripMenuItem
            // 
            consultarPorGeneroToolStripMenuItem.Name = "consultarPorGeneroToolStripMenuItem";
            consultarPorGeneroToolStripMenuItem.Size = new Size(221, 22);
            consultarPorGeneroToolStripMenuItem.Text = "Consultar por Genero";
            consultarPorGeneroToolStripMenuItem.Click += consultarPorGeneroToolStripMenuItem_Click;
            // 
            // peliculaToolStripMenuItem
            // 
            peliculaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarPeliculaToolStripMenuItem });
            peliculaToolStripMenuItem.Name = "peliculaToolStripMenuItem";
            peliculaToolStripMenuItem.Size = new Size(77, 22);
            peliculaToolStripMenuItem.Text = "Peliculas";
            // 
            // agregarPeliculaToolStripMenuItem
            // 
            agregarPeliculaToolStripMenuItem.Name = "agregarPeliculaToolStripMenuItem";
            agregarPeliculaToolStripMenuItem.Size = new Size(175, 22);
            agregarPeliculaToolStripMenuItem.Text = "Cargar Pelicula";
            agregarPeliculaToolStripMenuItem.Click += agregarPeliculaToolStripMenuItem_Click;
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarClienteToolStripMenuItem });
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(74, 22);
            clienteToolStripMenuItem.Text = "Clientes";
            // 
            // agregarClienteToolStripMenuItem
            // 
            agregarClienteToolStripMenuItem.Name = "agregarClienteToolStripMenuItem";
            agregarClienteToolStripMenuItem.Size = new Size(172, 22);
            agregarClienteToolStripMenuItem.Text = "Cargar Cliente";
            agregarClienteToolStripMenuItem.Click += agregarClienteToolStripMenuItem_Click;
            // 
            // funcionesToolStripMenuItem1
            // 
            funcionesToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { agregarFuncionToolStripMenuItem });
            funcionesToolStripMenuItem1.Name = "funcionesToolStripMenuItem1";
            funcionesToolStripMenuItem1.Size = new Size(86, 22);
            funcionesToolStripMenuItem1.Text = "Funciones";
            // 
            // agregarFuncionToolStripMenuItem
            // 
            agregarFuncionToolStripMenuItem.Name = "agregarFuncionToolStripMenuItem";
            agregarFuncionToolStripMenuItem.Size = new Size(176, 22);
            agregarFuncionToolStripMenuItem.Text = "Cargar Funcion";
            agregarFuncionToolStripMenuItem.Click += agregarFuncionToolStripMenuItem_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(759, 419);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem funcionesToolStripMenuItem;
        private ToolStripMenuItem nuevaReservaToolStripMenuItem;
        private ToolStripMenuItem peliculaToolStripMenuItem;
        private ToolStripMenuItem agregarPeliculaToolStripMenuItem;
        private ToolStripMenuItem historialReservasToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem agregarClienteToolStripMenuItem;
        private ToolStripMenuItem funcionesToolStripMenuItem1;
        private ToolStripMenuItem agregarFuncionToolStripMenuItem;
        private ToolStripMenuItem consultarPorFechasToolStripMenuItem;
        private ToolStripMenuItem consultarPorGeneroToolStripMenuItem;
    }
}