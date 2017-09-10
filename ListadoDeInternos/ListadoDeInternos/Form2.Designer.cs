namespace ListadoDeInternos
{
    partial class frmListadoDeInterno
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
            this.lblSucursale = new System.Windows.Forms.Label();
            this.cboSucursales = new System.Windows.Forms.ComboBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dgvRegListado = new System.Windows.Forms.DataGridView();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegListado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSucursale
            // 
            this.lblSucursale.AutoSize = true;
            this.lblSucursale.Location = new System.Drawing.Point(25, 29);
            this.lblSucursale.Name = "lblSucursale";
            this.lblSucursale.Size = new System.Drawing.Size(48, 13);
            this.lblSucursale.TabIndex = 0;
            this.lblSucursale.Text = "Sucursal";
            // 
            // cboSucursales
            // 
            this.cboSucursales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSucursales.FormattingEnabled = true;
            this.cboSucursales.Items.AddRange(new object[] {
            "Casa Matriz",
            "San Lorenzo",
            "Mariano Roque Alonso",
            "Todos"});
            this.cboSucursales.Location = new System.Drawing.Point(118, 26);
            this.cboSucursales.Name = "cboSucursales";
            this.cboSucursales.Size = new System.Drawing.Size(180, 21);
            this.cboSucursales.TabIndex = 1;
            this.cboSucursales.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(318, 26);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 2;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(431, 303);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(223, 283);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dgvRegListado
            // 
            this.dgvRegListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegListado.Location = new System.Drawing.Point(28, 64);
            this.dgvRegListado.Name = "dgvRegListado";
            this.dgvRegListado.Size = new System.Drawing.Size(478, 216);
            this.dgvRegListado.TabIndex = 3;
            this.dgvRegListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegListado_CellContentClick);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(482, 64);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(24, 216);
            this.vScrollBar1.TabIndex = 6;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(28, 259);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(454, 21);
            this.hScrollBar1.TabIndex = 7;
            // 
            // frmListadoDeInterno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 338);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.dgvRegListado);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.cboSucursales);
            this.Controls.Add(this.lblSucursale);
            this.Name = "frmListadoDeInterno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Interno";
            this.Load += new System.EventHandler(this.frmListadoDeInterno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSucursale;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridView dgvRegListado;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.ComboBox cboSucursales;
    }
}