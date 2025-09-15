namespace pryCastilloAgendaContacto
{
    partial class frmVerContactos
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
            btnAtras = new Button();
            btnSiguiente = new Button();
            lblDatos = new Label();
            SuspendLayout();
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(81, 257);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(180, 70);
            btnAtras.TabIndex = 0;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(279, 257);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(151, 70);
            btnSiguiente.TabIndex = 1;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // lblDatos
            // 
            lblDatos.Font = new Font("Segoe UI Symbol", 32F);
            lblDatos.Location = new Point(48, 53);
            lblDatos.Name = "lblDatos";
            lblDatos.Size = new Size(395, 135);
            lblDatos.TabIndex = 2;
            lblDatos.Text = "label1";
            // 
            // frmVerContactos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 396);
            Controls.Add(lblDatos);
            Controls.Add(btnSiguiente);
            Controls.Add(btnAtras);
            Name = "frmVerContactos";
            Text = "Ver Contactos";
            Load += frmVerContactos_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAtras;
        private Button btnSiguiente;
        private Label lblDatos;
    }
}