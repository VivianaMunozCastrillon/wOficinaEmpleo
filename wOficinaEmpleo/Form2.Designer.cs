namespace wOficinaEmpleo
{
    partial class frmModuloEmpleado
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.txtApellidoEmpleado = new System.Windows.Forms.TextBox();
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.lblApellidoEmpleado = new System.Windows.Forms.Label();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.datFechaDeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblNivelDeEstudio = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFechaDeNacimiento = new System.Windows.Forms.Label();
            this.cboNivelDeEstudios = new System.Windows.Forms.ComboBox();
            this.lblNumeroDocumento = new System.Windows.Forms.Label();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.dtgEmpleado = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.lblTituloAcademico = new System.Windows.Forms.Label();
            this.txtTituloAcademico = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(722, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Location = new System.Drawing.Point(170, 146);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(133, 20);
            this.txtNombreEmpleado.TabIndex = 1;
            this.txtNombreEmpleado.TextChanged += new System.EventHandler(this.txtNombreEmpleado_TextChanged);
            // 
            // txtApellidoEmpleado
            // 
            this.txtApellidoEmpleado.Location = new System.Drawing.Point(465, 146);
            this.txtApellidoEmpleado.Name = "txtApellidoEmpleado";
            this.txtApellidoEmpleado.Size = new System.Drawing.Size(133, 20);
            this.txtApellidoEmpleado.TabIndex = 2;
            this.txtApellidoEmpleado.TextChanged += new System.EventHandler(this.txtApellidoEmpleado_TextChanged);
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.AutoSize = true;
            this.lblNombreEmpleado.Location = new System.Drawing.Point(57, 153);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(94, 13);
            this.lblNombreEmpleado.TabIndex = 6;
            this.lblNombreEmpleado.Text = "Nombre Empleado";
            // 
            // lblApellidoEmpleado
            // 
            this.lblApellidoEmpleado.AutoSize = true;
            this.lblApellidoEmpleado.Location = new System.Drawing.Point(345, 149);
            this.lblApellidoEmpleado.Name = "lblApellidoEmpleado";
            this.lblApellidoEmpleado.Size = new System.Drawing.Size(94, 13);
            this.lblApellidoEmpleado.TabIndex = 7;
            this.lblApellidoEmpleado.Text = "Apellido Empleado";
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Location = new System.Drawing.Point(67, 105);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(86, 13);
            this.lblTipoDocumento.TabIndex = 8;
            this.lblTipoDocumento.Text = "Tipo Documento";
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.Items.AddRange(new object[] {
            "Pasaporte",
            "Cedula",
            "Permiso de trabajo"});
            this.cboTipoDocumento.Location = new System.Drawing.Point(170, 101);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(133, 21);
            this.cboTipoDocumento.TabIndex = 9;
            this.cboTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.cboTipoDocumento_SelectedIndexChanged);
            // 
            // datFechaDeNacimiento
            // 
            this.datFechaDeNacimiento.Location = new System.Drawing.Point(170, 188);
            this.datFechaDeNacimiento.Name = "datFechaDeNacimiento";
            this.datFechaDeNacimiento.Size = new System.Drawing.Size(133, 20);
            this.datFechaDeNacimiento.TabIndex = 10;
            // 
            // lblNivelDeEstudio
            // 
            this.lblNivelDeEstudio.AutoSize = true;
            this.lblNivelDeEstudio.Location = new System.Drawing.Point(345, 188);
            this.lblNivelDeEstudio.Name = "lblNivelDeEstudio";
            this.lblNivelDeEstudio.Size = new System.Drawing.Size(88, 13);
            this.lblNivelDeEstudio.TabIndex = 11;
            this.lblNivelDeEstudio.Text = "Nivel de estudios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(282, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "MÓDULO EMPLEADO";
            // 
            // lblFechaDeNacimiento
            // 
            this.lblFechaDeNacimiento.AutoSize = true;
            this.lblFechaDeNacimiento.Location = new System.Drawing.Point(45, 194);
            this.lblFechaDeNacimiento.Name = "lblFechaDeNacimiento";
            this.lblFechaDeNacimiento.Size = new System.Drawing.Size(108, 13);
            this.lblFechaDeNacimiento.TabIndex = 13;
            this.lblFechaDeNacimiento.Text = "Fecha de Nacimiento";
            // 
            // cboNivelDeEstudios
            // 
            this.cboNivelDeEstudios.FormattingEnabled = true;
            this.cboNivelDeEstudios.Items.AddRange(new object[] {
            "Pregrado",
            "Posgrado"});
            this.cboNivelDeEstudios.Location = new System.Drawing.Point(465, 185);
            this.cboNivelDeEstudios.Name = "cboNivelDeEstudios";
            this.cboNivelDeEstudios.Size = new System.Drawing.Size(133, 21);
            this.cboNivelDeEstudios.TabIndex = 14;
            this.cboNivelDeEstudios.SelectedIndexChanged += new System.EventHandler(this.cboNivelDeEstudios_SelectedIndexChanged);
            // 
            // lblNumeroDocumento
            // 
            this.lblNumeroDocumento.AutoSize = true;
            this.lblNumeroDocumento.Location = new System.Drawing.Point(343, 109);
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Size = new System.Drawing.Size(102, 13);
            this.lblNumeroDocumento.TabIndex = 15;
            this.lblNumeroDocumento.Text = "Número Documento";
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Location = new System.Drawing.Point(465, 107);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(133, 20);
            this.txtNumeroDocumento.TabIndex = 16;
            this.txtNumeroDocumento.TextChanged += new System.EventHandler(this.txtNumeroDocumento_TextChanged);
            // 
            // dtgEmpleado
            // 
            this.dtgEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEmpleado.Location = new System.Drawing.Point(60, 265);
            this.dtgEmpleado.Name = "dtgEmpleado";
            this.dtgEmpleado.Size = new System.Drawing.Size(605, 158);
            this.dtgEmpleado.TabIndex = 17;
            this.dtgEmpleado.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgEmpleado_MouseClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(535, 436);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(143, 42);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(373, 436);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(143, 42);
            this.btnModificar.TabIndex = 20;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(212, 436);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(143, 42);
            this.btnConsultar.TabIndex = 19;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(44, 436);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(143, 42);
            this.btnInsertar.TabIndex = 18;
            this.btnInsertar.Text = "INSERTAR";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // lblTituloAcademico
            // 
            this.lblTituloAcademico.AutoSize = true;
            this.lblTituloAcademico.Location = new System.Drawing.Point(226, 229);
            this.lblTituloAcademico.Name = "lblTituloAcademico";
            this.lblTituloAcademico.Size = new System.Drawing.Size(89, 13);
            this.lblTituloAcademico.TabIndex = 23;
            this.lblTituloAcademico.Text = "Titulo Academico";
            // 
            // txtTituloAcademico
            // 
            this.txtTituloAcademico.Location = new System.Drawing.Point(337, 226);
            this.txtTituloAcademico.Name = "txtTituloAcademico";
            this.txtTituloAcademico.Size = new System.Drawing.Size(133, 20);
            this.txtTituloAcademico.TabIndex = 22;
            this.txtTituloAcademico.TextChanged += new System.EventHandler(this.txtTituloAcademico_TextChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(566, 1);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(156, 23);
            this.btnLimpiar.TabIndex = 24;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmModuloEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::wOficinaEmpleo.Properties.Resources.BackgroundEmpleado;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(722, 492);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblTituloAcademico);
            this.Controls.Add(this.txtTituloAcademico);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.dtgEmpleado);
            this.Controls.Add(this.txtNumeroDocumento);
            this.Controls.Add(this.lblNumeroDocumento);
            this.Controls.Add(this.cboNivelDeEstudios);
            this.Controls.Add(this.lblFechaDeNacimiento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNivelDeEstudio);
            this.Controls.Add(this.datFechaDeNacimiento);
            this.Controls.Add(this.cboTipoDocumento);
            this.Controls.Add(this.lblTipoDocumento);
            this.Controls.Add(this.lblApellidoEmpleado);
            this.Controls.Add(this.lblNombreEmpleado);
            this.Controls.Add(this.txtApellidoEmpleado);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmModuloEmpleado";
            this.Text = "Módulo Empleado";
            this.Load += new System.EventHandler(this.frmModuloEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.TextBox txtApellidoEmpleado;
        private System.Windows.Forms.Label lblNombreEmpleado;
        private System.Windows.Forms.Label lblApellidoEmpleado;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.ComboBox cboTipoDocumento;
        private System.Windows.Forms.DateTimePicker datFechaDeNacimiento;
        private System.Windows.Forms.Label lblNivelDeEstudio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFechaDeNacimiento;
        private System.Windows.Forms.ComboBox cboNivelDeEstudios;
        private System.Windows.Forms.Label lblNumeroDocumento;
        private System.Windows.Forms.TextBox txtNumeroDocumento;
        private System.Windows.Forms.DataGridView dtgEmpleado;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label lblTituloAcademico;
        private System.Windows.Forms.TextBox txtTituloAcademico;
        private System.Windows.Forms.Button btnLimpiar;
    }
}