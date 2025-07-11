namespace Claseservidor
{
    partial class frmFormularioUsuario
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
            lblBienvenidos = new Label();
            SuspendLayout();
            // 
            // lblBienvenidos
            // 
            lblBienvenidos.AutoSize = true;
            lblBienvenidos.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenidos.Location = new Point(31, 24);
            lblBienvenidos.Name = "lblBienvenidos";
            lblBienvenidos.Size = new Size(358, 30);
            lblBienvenidos.TabIndex = 0;
            lblBienvenidos.Text = "Bienvenidos a Gestion de Usuario";
            // 
            // frmFormularioUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblBienvenidos);
            Name = "frmFormularioUsuario";
            Text = "Formulario De Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenidos;
    }
}