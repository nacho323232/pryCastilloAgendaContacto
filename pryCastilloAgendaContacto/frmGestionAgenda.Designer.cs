namespace pryCastilloAgendaContacto
{
    partial class frmGestionAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionAgenda));
            lblContacto = new Label();
            lblNumero = new Label();
            mtbNumero = new MaskedTextBox();
            txtContacto = new TextBox();
            lstResumen = new ListBox();
            btnAgendar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Font = new Font("Segoe UI", 12F);
            lblContacto.Location = new Point(17, 16);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(72, 21);
            lblContacto.TabIndex = 5;
            lblContacto.Text = "Contacto";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 12F);
            lblNumero.Location = new Point(21, 73);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(68, 21);
            lblNumero.TabIndex = 6;
            lblNumero.Text = "Numero";
            // 
            // mtbNumero
            // 
            mtbNumero.Enabled = false;
            mtbNumero.Font = new Font("Segoe UI", 12F);
            mtbNumero.Location = new Point(125, 73);
            mtbNumero.Mask = "(999)000-0000";
            mtbNumero.Name = "mtbNumero";
            mtbNumero.Size = new Size(134, 29);
            mtbNumero.TabIndex = 1;
            mtbNumero.TextChanged += mtbNumero_TextChanged;
            // 
            // txtContacto
            // 
            txtContacto.Font = new Font("Segoe UI", 12F);
            txtContacto.Location = new Point(125, 16);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(134, 29);
            txtContacto.TabIndex = 0;
            txtContacto.TextChanged += txtContacto_TextChanged;
            // 
            // lstResumen
            // 
            lstResumen.Font = new Font("Segoe UI", 12F);
            lstResumen.FormattingEnabled = true;
            lstResumen.ItemHeight = 21;
            lstResumen.Location = new Point(21, 203);
            lstResumen.Name = "lstResumen";
            lstResumen.Size = new Size(303, 109);
            lstResumen.TabIndex = 4;
            // 
            // btnAgendar
            // 
            btnAgendar.Enabled = false;
            btnAgendar.Font = new Font("Segoe UI", 12F);
            btnAgendar.Location = new Point(202, 134);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(83, 32);
            btnAgendar.TabIndex = 2;
            btnAgendar.Text = "Agendar";
            btnAgendar.UseVisualStyleBackColor = true;
            btnAgendar.Click += btnAgendar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(77, 134);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(91, 32);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmGestionAgenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(352, 374);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgendar);
            Controls.Add(lstResumen);
            Controls.Add(txtContacto);
            Controls.Add(mtbNumero);
            Controls.Add(lblNumero);
            Controls.Add(lblContacto);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmGestionAgenda";
            Text = "Inicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblContacto;
        private Label lblNumero;
        private MaskedTextBox mtbNumero;
        private TextBox txtContacto;
        private ListBox lstResumen;
        private Button btnAgendar;
        private Button btnCancelar;
    }
}