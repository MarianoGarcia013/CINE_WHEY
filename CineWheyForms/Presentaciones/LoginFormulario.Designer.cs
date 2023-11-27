namespace CineWheyForms.Presentaciones
{
    partial class LoginFormulario
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
            label1 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            btnIngresar = new Button();
            btnSalir = new Button();
            label3 = new Label();
            checkContra = new CheckBox();
            btnNuevo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(153, 135);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(134, 169);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.None;
            txtUsuario.BackColor = Color.White;
            txtUsuario.ForeColor = Color.Black;
            txtUsuario.Location = new Point(232, 130);
            txtUsuario.Margin = new Padding(2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(165, 23);
            txtUsuario.TabIndex = 2;
            // 
            // txtContraseña
            // 
            txtContraseña.Anchor = AnchorStyles.None;
            txtContraseña.BackColor = Color.White;
            txtContraseña.ForeColor = Color.Black;
            txtContraseña.Location = new Point(232, 164);
            txtContraseña.Margin = new Padding(2);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(165, 23);
            txtContraseña.TabIndex = 3;
            // 
            // btnIngresar
            // 
            btnIngresar.Anchor = AnchorStyles.None;
            btnIngresar.BackColor = Color.FromArgb(64, 64, 64);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(266, 236);
            btnIngresar.Margin = new Padding(2);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(91, 26);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.None;
            btnSalir.BackColor = Color.FromArgb(64, 64, 64);
            btnSalir.Location = new Point(474, 332);
            btnSalir.Margin = new Padding(2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(91, 26);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(288, 74);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 6;
            label3.Text = "Login:";
            label3.Click += label3_Click;
            // 
            // checkContra
            // 
            checkContra.Anchor = AnchorStyles.None;
            checkContra.AutoSize = true;
            checkContra.Location = new Point(244, 203);
            checkContra.Margin = new Padding(2);
            checkContra.Name = "checkContra";
            checkContra.Size = new Size(130, 19);
            checkContra.TabIndex = 7;
            checkContra.Text = "Mostrar Contraseña";
            checkContra.UseVisualStyleBackColor = true;
            checkContra.CheckedChanged += checkContra_CheckedChanged;
            // 
            // btnNuevo
            // 
            btnNuevo.Anchor = AnchorStyles.None;
            btnNuevo.BackColor = Color.FromArgb(64, 64, 64);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(65, 332);
            btnNuevo.Margin = new Padding(2);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(91, 26);
            btnNuevo.TabIndex = 8;
            btnNuevo.Text = "&Crear Usuario";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // LoginFormulario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 0);
            ClientSize = new Size(627, 389);
            Controls.Add(label3);
            Controls.Add(btnNuevo);
            Controls.Add(label1);
            Controls.Add(btnIngresar);
            Controls.Add(checkContra);
            Controls.Add(txtContraseña);
            Controls.Add(label2);
            Controls.Add(btnSalir);
            Controls.Add(txtUsuario);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2);
            Name = "LoginFormulario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginFormulario";
            WindowState = FormWindowState.Maximized;
            Load += LoginFormulario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button btnIngresar;
        private Button btnSalir;
        private Label label3;
        private CheckBox checkContra;
        private Button btnNuevo;
    }
}