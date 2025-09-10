namespace pryBaldovinoAgendaContactos
{
    partial class frmAgendaPersonalizada
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
            lblDatos = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new MaskedTextBox();
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            lblCategoria = new Label();
            cboCategoria = new ComboBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            lblBuscar = new Label();
            cboBuscar = new ComboBox();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            SuspendLayout();
            // 
            // lblDatos
            // 
            lblDatos.AutoSize = true;
            lblDatos.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatos.Location = new Point(30, 32);
            lblDatos.Name = "lblDatos";
            lblDatos.Size = new Size(171, 25);
            lblDatos.TabIndex = 0;
            lblDatos.Text = "Datos del Contacto";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(30, 99);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(77, 23);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellido.Location = new Point(450, 92);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(76, 23);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(135, 95);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(206, 27);
            txtNombre.TabIndex = 3;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(549, 91);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(206, 27);
            txtApellido.TabIndex = 4;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelefono.Location = new Point(30, 171);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(78, 23);
            lblTelefono.TabIndex = 5;
            lblTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(135, 171);
            txtTelefono.Mask = "(999)000-0000";
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(206, 27);
            txtTelefono.TabIndex = 6;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCorreo.Location = new Point(450, 171);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(66, 23);
            lblCorreo.TabIndex = 7;
            lblCorreo.Text = "Correo:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(549, 171);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(206, 27);
            txtCorreo.TabIndex = 8;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(30, 249);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(88, 23);
            lblCategoria.TabIndex = 9;
            lblCategoria.Text = "Categoría:";
            // 
            // cboCategoria
            // 
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Items.AddRange(new object[] { "Familia", "Trabajo", "Amigos" });
            cboCategoria.Location = new Point(135, 249);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(206, 28);
            cboCategoria.TabIndex = 10;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.AppWorkspace;
            btnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(630, 318);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(125, 35);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.AppWorkspace;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.Location = new Point(304, 317);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(125, 36);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = SystemColors.AppWorkspace;
            btnEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(468, 317);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(125, 36);
            btnEditar.TabIndex = 15;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBuscar.Location = new Point(30, 409);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(64, 23);
            lblBuscar.TabIndex = 16;
            lblBuscar.Text = "Buscar:";
            // 
            // cboBuscar
            // 
            cboBuscar.FormattingEnabled = true;
            cboBuscar.Items.AddRange(new object[] { "Nombre", "Teléfono", "Correo electrónico" });
            cboBuscar.Location = new Point(135, 408);
            cboBuscar.Name = "cboBuscar";
            cboBuscar.Size = new Size(206, 28);
            cboBuscar.TabIndex = 17;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(387, 409);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(206, 27);
            txtBuscar.TabIndex = 18;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.AppWorkspace;
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(630, 404);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(125, 35);
            btnBuscar.TabIndex = 19;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // frmAgendaPersonalizada
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 618);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(cboBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(cboCategoria);
            Controls.Add(lblCategoria);
            Controls.Add(txtCorreo);
            Controls.Add(lblCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblDatos);
            Name = "frmAgendaPersonalizada";
            Text = "Agenda de contactos personalizada";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDatos;
        private Label lblNombre;
        private Label lblApellido;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label lblTelefono;
        private MaskedTextBox txtTelefono;
        private Label lblCorreo;
        private TextBox txtCorreo;
        private Label lblCategoria;
        private ComboBox cboCategoria;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnEditar;
        private Label lblBuscar;
        private ComboBox cboBuscar;
        private TextBox txtBuscar;
        private Button btnBuscar;
    }
}