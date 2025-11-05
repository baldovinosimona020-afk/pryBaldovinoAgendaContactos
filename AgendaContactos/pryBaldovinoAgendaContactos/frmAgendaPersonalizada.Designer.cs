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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgendaPersonalizada));
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
            dgvContactos = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Teléfono = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Categoría = new DataGridViewTextBoxColumn();
            btnExportarvCard = new Button();
            btnExportarCVS = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvContactos).BeginInit();
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
            lblApellido.Location = new Point(401, 91);
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
            txtApellido.Location = new Point(491, 94);
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
            lblCorreo.Location = new Point(401, 175);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(66, 23);
            lblCorreo.TabIndex = 7;
            lblCorreo.Text = "Correo:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(491, 174);
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
            btnAgregar.Location = new Point(572, 317);
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
            btnEliminar.Location = new Point(294, 317);
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
            btnEditar.Location = new Point(435, 317);
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
            txtBuscar.Location = new Point(135, 461);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(206, 27);
            txtBuscar.TabIndex = 18;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.AppWorkspace;
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(572, 453);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(125, 35);
            btnBuscar.TabIndex = 19;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // dgvContactos
            // 
            dgvContactos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContactos.Columns.AddRange(new DataGridViewColumn[] { Nombre, Apellido, Teléfono, Correo, Categoría });
            dgvContactos.Location = new Point(30, 553);
            dgvContactos.Name = "dgvContactos";
            dgvContactos.RowHeadersWidth = 51;
            dgvContactos.Size = new Size(667, 127);
            dgvContactos.TabIndex = 20;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 6;
            Apellido.Name = "Apellido";
            Apellido.Width = 125;
            // 
            // Teléfono
            // 
            Teléfono.HeaderText = "Teléfono";
            Teléfono.MinimumWidth = 6;
            Teléfono.Name = "Teléfono";
            Teléfono.Width = 125;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.MinimumWidth = 6;
            Correo.Name = "Correo";
            Correo.Width = 125;
            // 
            // Categoría
            // 
            Categoría.HeaderText = "Categoría";
            Categoría.MinimumWidth = 6;
            Categoría.Name = "Categoría";
            Categoría.Width = 125;
            // 
            // btnExportarvCard
            // 
            btnExportarvCard.BackColor = SystemColors.AppWorkspace;
            btnExportarvCard.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportarvCard.Location = new Point(368, 714);
            btnExportarvCard.Name = "btnExportarvCard";
            btnExportarvCard.Size = new Size(214, 35);
            btnExportarvCard.TabIndex = 21;
            btnExportarvCard.Text = "Exportar vCard";
            btnExportarvCard.UseVisualStyleBackColor = false;
            // 
            // btnExportarCVS
            // 
            btnExportarCVS.BackColor = SystemColors.AppWorkspace;
            btnExportarCVS.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportarCVS.Location = new Point(109, 714);
            btnExportarCVS.Name = "btnExportarCVS";
            btnExportarCVS.Size = new Size(214, 35);
            btnExportarCVS.TabIndex = 22;
            btnExportarCVS.Text = "Exportar CVS";
            btnExportarCVS.UseVisualStyleBackColor = false;
            btnExportarCVS.Click += btnExportarCVS_Click;
            // 
            // frmAgendaPersonalizada
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 765);
            Controls.Add(btnExportarCVS);
            Controls.Add(btnExportarvCard);
            Controls.Add(dgvContactos);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmAgendaPersonalizada";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agenda de contactos personalizada";
            ((System.ComponentModel.ISupportInitialize)dgvContactos).EndInit();
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
        private DataGridView dgvContactos;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Teléfono;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Categoría;
        private Button btnExportarvCard;
        private Button btnExportarCVS;
    }
}