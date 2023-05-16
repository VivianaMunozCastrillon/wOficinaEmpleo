namespace wOficinaEmpleo
{
    partial class frmModuloBuscarEmpleo
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
            this.txtCodigoDeEmpleo = new System.Windows.Forms.TextBox();
            this.lblCodigoDeEmpleo = new System.Windows.Forms.Label();
            this.dtgBuscarEmpleo = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblModuloBuscarEmpleo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuscarEmpleo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(783, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // txtCodigoDeEmpleo
            // 
            this.txtCodigoDeEmpleo.Location = new System.Drawing.Point(311, 117);
            this.txtCodigoDeEmpleo.Name = "txtCodigoDeEmpleo";
            this.txtCodigoDeEmpleo.Size = new System.Drawing.Size(157, 20);
            this.txtCodigoDeEmpleo.TabIndex = 1;
            this.txtCodigoDeEmpleo.TextChanged += new System.EventHandler(this.txtCodigoDeEmpleo_TextChanged);
            // 
            // lblCodigoDeEmpleo
            // 
            this.lblCodigoDeEmpleo.AutoSize = true;
            this.lblCodigoDeEmpleo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoDeEmpleo.Location = new System.Drawing.Point(317, 82);
            this.lblCodigoDeEmpleo.Name = "lblCodigoDeEmpleo";
            this.lblCodigoDeEmpleo.Size = new System.Drawing.Size(147, 18);
            this.lblCodigoDeEmpleo.TabIndex = 2;
            this.lblCodigoDeEmpleo.Text = "Codigo de Empleo";
            // 
            // dtgBuscarEmpleo
            // 
            this.dtgBuscarEmpleo.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dtgBuscarEmpleo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBuscarEmpleo.Location = new System.Drawing.Point(85, 171);
            this.dtgBuscarEmpleo.Name = "dtgBuscarEmpleo";
            this.dtgBuscarEmpleo.Size = new System.Drawing.Size(633, 211);
            this.dtgBuscarEmpleo.TabIndex = 3;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(324, 401);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(143, 42);
            this.btnConsultar.TabIndex = 20;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblModuloBuscarEmpleo
            // 
            this.lblModuloBuscarEmpleo.AutoSize = true;
            this.lblModuloBuscarEmpleo.BackColor = System.Drawing.Color.White;
            this.lblModuloBuscarEmpleo.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuloBuscarEmpleo.Location = new System.Drawing.Point(260, 42);
            this.lblModuloBuscarEmpleo.Name = "lblModuloBuscarEmpleo";
            this.lblModuloBuscarEmpleo.Size = new System.Drawing.Size(275, 26);
            this.lblModuloBuscarEmpleo.TabIndex = 21;
            this.lblModuloBuscarEmpleo.Text = "MÓDULO BUSCAR EMPLEO";
            // 
            // frmModuloBuscarEmpleo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::wOficinaEmpleo.Properties.Resources.White_Squiggles_Superminimalism_Linktree_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(783, 455);
            this.Controls.Add(this.lblModuloBuscarEmpleo);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dtgBuscarEmpleo);
            this.Controls.Add(this.lblCodigoDeEmpleo);
            this.Controls.Add(this.txtCodigoDeEmpleo);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmModuloBuscarEmpleo";
            this.Text = "Módulo Buscar Empleo";
            this.Load += new System.EventHandler(this.frmModuloBuscarEmpleo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuscarEmpleo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox txtCodigoDeEmpleo;
        private System.Windows.Forms.Label lblCodigoDeEmpleo;
        private System.Windows.Forms.DataGridView dtgBuscarEmpleo;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblModuloBuscarEmpleo;
    }
}