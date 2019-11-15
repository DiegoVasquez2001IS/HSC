namespace CxC_Gestion
{
    partial class CxC_gestion
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbc_ListarMovimientos = new System.Windows.Forms.TabPage();
            this.dgv_Cuentas = new System.Windows.Forms.DataGridView();
            this.gbp_Listar = new System.Windows.Forms.GroupBox();
            this.cbo_clientes = new System.Windows.Forms.ComboBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.lbl_Cliente = new System.Windows.Forms.Label();
            this.cbo_Periodo = new System.Windows.Forms.ComboBox();
            this.lbl_Período = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbc_ListarMovimientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cuentas)).BeginInit();
            this.gbp_Listar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbc_ListarMovimientos);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1491, 708);
            this.tabControl1.TabIndex = 0;
            // 
            // tbc_ListarMovimientos
            // 
            this.tbc_ListarMovimientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.tbc_ListarMovimientos.Controls.Add(this.dgv_Cuentas);
            this.tbc_ListarMovimientos.Controls.Add(this.gbp_Listar);
            this.tbc_ListarMovimientos.Location = new System.Drawing.Point(4, 25);
            this.tbc_ListarMovimientos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbc_ListarMovimientos.Name = "tbc_ListarMovimientos";
            this.tbc_ListarMovimientos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbc_ListarMovimientos.Size = new System.Drawing.Size(1483, 679);
            this.tbc_ListarMovimientos.TabIndex = 2;
            this.tbc_ListarMovimientos.Text = "Listar Movimientos";
            this.tbc_ListarMovimientos.Click += new System.EventHandler(this.tbc_ListarMovimientos_Click);
            // 
            // dgv_Cuentas
            // 
            this.dgv_Cuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Cuentas.Location = new System.Drawing.Point(41, 233);
            this.dgv_Cuentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_Cuentas.Name = "dgv_Cuentas";
            this.dgv_Cuentas.RowHeadersWidth = 51;
            this.dgv_Cuentas.Size = new System.Drawing.Size(1307, 314);
            this.dgv_Cuentas.TabIndex = 2;
            // 
            // gbp_Listar
            // 
            this.gbp_Listar.Controls.Add(this.cbo_clientes);
            this.gbp_Listar.Controls.Add(this.btn_buscar);
            this.gbp_Listar.Controls.Add(this.lbl_Cliente);
            this.gbp_Listar.Controls.Add(this.cbo_Periodo);
            this.gbp_Listar.Controls.Add(this.lbl_Período);
            this.gbp_Listar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbp_Listar.Location = new System.Drawing.Point(37, 20);
            this.gbp_Listar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbp_Listar.Name = "gbp_Listar";
            this.gbp_Listar.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbp_Listar.Size = new System.Drawing.Size(1311, 135);
            this.gbp_Listar.TabIndex = 1;
            this.gbp_Listar.TabStop = false;
            this.gbp_Listar.Text = "Listado Movimiento";
            // 
            // cbo_clientes
            // 
            this.cbo_clientes.FormattingEnabled = true;
            this.cbo_clientes.Location = new System.Drawing.Point(571, 64);
            this.cbo_clientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbo_clientes.Name = "cbo_clientes";
            this.cbo_clientes.Size = new System.Drawing.Size(179, 24);
            this.cbo_clientes.TabIndex = 5;
            this.cbo_clientes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbo_clientes_KeyPress);
            // 
            // btn_buscar
            // 
            this.btn_buscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_buscar.Image = global::CxC_Gestion.Properties.Resources.Search_Property;
            this.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_buscar.Location = new System.Drawing.Point(936, 41);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(73, 62);
            this.btn_buscar.TabIndex = 4;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // lbl_Cliente
            // 
            this.lbl_Cliente.AutoSize = true;
            this.lbl_Cliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Cliente.Location = new System.Drawing.Point(433, 64);
            this.lbl_Cliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Cliente.Name = "lbl_Cliente";
            this.lbl_Cliente.Size = new System.Drawing.Size(119, 17);
            this.lbl_Cliente.TabIndex = 2;
            this.lbl_Cliente.Text = "Codigo de Cliente";
            // 
            // cbo_Periodo
            // 
            this.cbo_Periodo.FormattingEnabled = true;
            this.cbo_Periodo.Location = new System.Drawing.Point(168, 60);
            this.cbo_Periodo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbo_Periodo.Name = "cbo_Periodo";
            this.cbo_Periodo.Size = new System.Drawing.Size(179, 24);
            this.cbo_Periodo.TabIndex = 1;
            this.cbo_Periodo.SelectedIndexChanged += new System.EventHandler(this.cbo_Periodo_SelectedIndexChanged);
            this.cbo_Periodo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbo_Periodo_KeyPress);
            // 
            // lbl_Período
            // 
            this.lbl_Período.AutoSize = true;
            this.lbl_Período.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Período.Location = new System.Drawing.Point(73, 64);
            this.lbl_Período.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Período.Name = "lbl_Período";
            this.lbl_Período.Size = new System.Drawing.Size(57, 17);
            this.lbl_Período.TabIndex = 0;
            this.lbl_Período.Text = "Período";
            // 
            // CxC_gestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CxC_gestion";
            this.Size = new System.Drawing.Size(1493, 714);
            this.tabControl1.ResumeLayout(false);
            this.tbc_ListarMovimientos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cuentas)).EndInit();
            this.gbp_Listar.ResumeLayout(false);
            this.gbp_Listar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbc_ListarMovimientos;
        private System.Windows.Forms.DataGridView dgv_Cuentas;
        private System.Windows.Forms.GroupBox gbp_Listar;
        private System.Windows.Forms.ComboBox cbo_clientes;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label lbl_Cliente;
        private System.Windows.Forms.ComboBox cbo_Periodo;
        private System.Windows.Forms.Label lbl_Período;
    }
}
