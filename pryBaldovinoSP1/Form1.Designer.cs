namespace pryBaldovinoSP1
{
    partial class frmSP1
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
            this.btnAceptar = new Button();
            btnCancelar = new Button();
            lblUsuario = new Label();
            lblContra = new Label();
            txtUsuario = new TextBox();
            txtContra = new TextBox();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new Point(269, 28);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += this.button1_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(269, 68);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += button2_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(26, 37);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(50, 15);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario ";
            lblUsuario.Click += this.lblUsuario_Click;
            // 
            // lblContra
            // 
            lblContra.AutoSize = true;
            lblContra.Location = new Point(26, 76);
            lblContra.Name = "lblContra";
            lblContra.Size = new Size(67, 15);
            lblContra.TabIndex = 3;
            lblContra.Text = "Contraseña";
            lblContra.Click += this.lblContra_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(128, 29);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 4;
            txtUsuario.TextChanged += this.txtUsuario_TextChanged;
            // 
            // txtContra
            // 
            txtContra.Location = new Point(128, 68);
            txtContra.Name = "txtContra";
            txtContra.Size = new Size(100, 23);
            txtContra.TabIndex = 5;
            txtContra.TextChanged += this.txtContra_TextChanged;
            // 
            // frmSP1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 139);
            Controls.Add(txtContra);
            Controls.Add(txtUsuario);
            Controls.Add(lblContra);
            Controls.Add(lblUsuario);
            Controls.Add(btnCancelar);
            Controls.Add(this.btnAceptar);
            Name = "frmSP1";
            Text = "LOGIN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnCancelar;
        private Label lblUsuario;
        private Label lblContra;
        private TextBox txtUsuario;
        private TextBox txtContra;
    }
}
