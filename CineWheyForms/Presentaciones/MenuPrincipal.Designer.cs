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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.funcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaReservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarPorFechasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarPorGeneroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peliculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarPeliculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarFuncionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // funcionesToolStripMenuItem
            // 
            this.funcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaReservaToolStripMenuItem,
            this.historialReservasToolStripMenuItem});
            this.funcionesToolStripMenuItem.Name = "funcionesToolStripMenuItem";
            this.funcionesToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.funcionesToolStripMenuItem.Text = "Reserva";
            this.funcionesToolStripMenuItem.Click += new System.EventHandler(this.funcionesToolStripMenuItem_Click);
            // 
            // nuevaReservaToolStripMenuItem
            // 
            this.nuevaReservaToolStripMenuItem.Name = "nuevaReservaToolStripMenuItem";
            this.nuevaReservaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.nuevaReservaToolStripMenuItem.Text = "Nueva Reserva";
            this.nuevaReservaToolStripMenuItem.Click += new System.EventHandler(this.nuevaReservaToolStripMenuItem_Click);
            // 
            // historialReservasToolStripMenuItem
            // 
            this.historialReservasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarPorFechasToolStripMenuItem,
            this.consultarPorGeneroToolStripMenuItem});
            this.historialReservasToolStripMenuItem.Name = "historialReservasToolStripMenuItem";
            this.historialReservasToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.historialReservasToolStripMenuItem.Text = "Historial Reservas";
            this.historialReservasToolStripMenuItem.Click += new System.EventHandler(this.historialReservasToolStripMenuItem_Click);
            // 
            // consultarPorFechasToolStripMenuItem
            // 
            this.consultarPorFechasToolStripMenuItem.Name = "consultarPorFechasToolStripMenuItem";
            this.consultarPorFechasToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
            this.consultarPorFechasToolStripMenuItem.Text = "Consultar por Fechas";
            this.consultarPorFechasToolStripMenuItem.Click += new System.EventHandler(this.consultarPorFechasToolStripMenuItem_Click);
            // 
            // consultarPorGeneroToolStripMenuItem
            // 
            this.consultarPorGeneroToolStripMenuItem.Name = "consultarPorGeneroToolStripMenuItem";
            this.consultarPorGeneroToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
            this.consultarPorGeneroToolStripMenuItem.Text = "Consultar por Genero";
            this.consultarPorGeneroToolStripMenuItem.Click += new System.EventHandler(this.consultarPorGeneroToolStripMenuItem_Click);
            // 
            // peliculaToolStripMenuItem
            // 
            this.peliculaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarPeliculaToolStripMenuItem});
            this.peliculaToolStripMenuItem.Name = "peliculaToolStripMenuItem";
            this.peliculaToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.peliculaToolStripMenuItem.Text = "Pelicula";
            // 
            // agregarPeliculaToolStripMenuItem
            // 
            this.agregarPeliculaToolStripMenuItem.Name = "agregarPeliculaToolStripMenuItem";
            this.agregarPeliculaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.agregarPeliculaToolStripMenuItem.Text = "Cargar Pelicula";
            this.agregarPeliculaToolStripMenuItem.Click += new System.EventHandler(this.agregarPeliculaToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarClienteToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(81, 29);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // agregarClienteToolStripMenuItem
            // 
            this.agregarClienteToolStripMenuItem.Name = "agregarClienteToolStripMenuItem";
            this.agregarClienteToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.agregarClienteToolStripMenuItem.Text = "Cargar Cliente";
            this.agregarClienteToolStripMenuItem.Click += new System.EventHandler(this.agregarClienteToolStripMenuItem_Click);
            // 
            // funcionesToolStripMenuItem1
            // 
            this.funcionesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarFuncionToolStripMenuItem});
            this.funcionesToolStripMenuItem1.Name = "funcionesToolStripMenuItem1";
            this.funcionesToolStripMenuItem1.Size = new System.Drawing.Size(107, 29);
            this.funcionesToolStripMenuItem1.Text = "Funciones";
            // 
            // agregarFuncionToolStripMenuItem
            // 
            this.agregarFuncionToolStripMenuItem.Name = "agregarFuncionToolStripMenuItem";
            this.agregarFuncionToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.agregarFuncionToolStripMenuItem.Text = "Cargar Funcion";
            this.agregarFuncionToolStripMenuItem.Click += new System.EventHandler(this.agregarFuncionToolStripMenuItem_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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