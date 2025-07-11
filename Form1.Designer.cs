namespace Claseservidor
{
    partial class frmInicioSeccion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnProbarBD = new Button();
            lblIDNombre = new Label();
            lblNombreUsuario = new Label();
            EmailUsuario = new Label();
            lblRolUsuario = new Label();
            lblContraseñaUsuario = new Label();
            txtNombreUsuario = new TextBox();
            txtContraseña = new TextBox();
            pictureBox1 = new PictureBox();
            cboRolUsuario = new ComboBox();
            btnInisiaSeccion = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnProbarBD
            // 
            btnProbarBD.Location = new Point(24, 515);
            btnProbarBD.Name = "btnProbarBD";
            btnProbarBD.Size = new Size(228, 34);
            btnProbarBD.TabIndex = 0;
            btnProbarBD.Text = "Probar Conexión a BD";
            btnProbarBD.UseVisualStyleBackColor = true;
            btnProbarBD.Click += btnProbarBD_Click;
            // 
            // lblIDNombre
            // 
            lblIDNombre.AutoSize = true;
            lblIDNombre.Location = new Point(24, 9);
            lblIDNombre.Name = "lblIDNombre";
            lblIDNombre.Size = new Size(0, 25);
            lblIDNombre.TabIndex = 1;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.BackColor = Color.FromArgb(192, 255, 192);
            lblNombreUsuario.Location = new Point(12, 246);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(174, 25);
            lblNombreUsuario.TabIndex = 2;
            lblNombreUsuario.Text = "Nombre Del Usuario";
            // 
            // EmailUsuario
            // 
            EmailUsuario.AutoSize = true;
            EmailUsuario.Location = new Point(24, 123);
            EmailUsuario.Name = "EmailUsuario";
            EmailUsuario.Size = new Size(0, 25);
            EmailUsuario.TabIndex = 3;
            // 
            // lblRolUsuario
            // 
            lblRolUsuario.AutoSize = true;
            lblRolUsuario.BackColor = Color.FromArgb(192, 255, 255);
            lblRolUsuario.Location = new Point(12, 380);
            lblRolUsuario.Name = "lblRolUsuario";
            lblRolUsuario.Size = new Size(102, 25);
            lblRolUsuario.TabIndex = 4;
            lblRolUsuario.Text = "Rol Usuario";
            // 
            // lblContraseñaUsuario
            // 
            lblContraseñaUsuario.AutoSize = true;
            lblContraseñaUsuario.BackColor = Color.FromArgb(255, 192, 255);
            lblContraseñaUsuario.Location = new Point(12, 309);
            lblContraseñaUsuario.Name = "lblContraseñaUsuario";
            lblContraseñaUsuario.Size = new Size(166, 25);
            lblContraseñaUsuario.TabIndex = 5;
            lblContraseñaUsuario.Text = "Contraseña Usuario";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(209, 243);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(182, 31);
            txtNombreUsuario.TabIndex = 7;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(209, 309);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(182, 31);
            txtContraseña.TabIndex = 9;
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.WhatsApp_Image_2025_07_10_at_11_49_39_AM;
            pictureBox1.Location = new Point(-2, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(463, 210);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // cboRolUsuario
            // 
            cboRolUsuario.FormattingEnabled = true;
            cboRolUsuario.Location = new Point(209, 380);
            cboRolUsuario.Name = "cboRolUsuario";
            cboRolUsuario.Size = new Size(182, 33);
            cboRolUsuario.TabIndex = 12;
            // 
            // btnInisiaSeccion
            // 
            btnInisiaSeccion.BackColor = Color.ForestGreen;
            btnInisiaSeccion.Image = Properties.Resources.imgIniciarSesion;
            btnInisiaSeccion.ImageAlign = ContentAlignment.TopCenter;
            btnInisiaSeccion.Location = new Point(344, 471);
            btnInisiaSeccion.Name = "btnInisiaSeccion";
            btnInisiaSeccion.Size = new Size(86, 78);
            btnInisiaSeccion.TabIndex = 13;
            btnInisiaSeccion.Text = "Inicio Sección";
            btnInisiaSeccion.TextAlign = ContentAlignment.BottomCenter;
            btnInisiaSeccion.UseVisualStyleBackColor = false;
            btnInisiaSeccion.Click += btnInisiaSeccion_Click;
            // 
            // frmInicioSeccion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 593);
            Controls.Add(btnInisiaSeccion);
            Controls.Add(cboRolUsuario);
            Controls.Add(pictureBox1);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombreUsuario);
            Controls.Add(lblContraseñaUsuario);
            Controls.Add(lblRolUsuario);
            Controls.Add(EmailUsuario);
            Controls.Add(lblNombreUsuario);
            Controls.Add(lblIDNombre);
            Controls.Add(btnProbarBD);
            Name = "frmInicioSeccion";
            Text = "Inicio de seccion Usuario";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnProbarBD;
        private Label lblIDNombre;
        private Label lblNombreUsuario;
        private Label EmailUsuario;
        private Label lblRolUsuario;
        private Label lblContraseñaUsuario;
        private TextBox txtNombreUsuario;
        private TextBox txtContraseña;
        private PictureBox pictureBox1;
        private ComboBox cboRolUsuario;
        private Button btnInisiaSeccion;
    }
}
