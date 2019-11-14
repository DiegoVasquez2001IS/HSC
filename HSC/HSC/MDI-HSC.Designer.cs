namespace HSC
{
	partial class MDIParent1
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

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParent1));
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hoteleríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.finanzasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contabilidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bancosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.comprasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.cuentasPorPagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ventasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.cuentasPorCobrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rRHHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.inventariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.ayudasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ayudasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.BackgroundImage = global::HSC.Properties.Resources.Logopng;
			this.menuStrip.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.hoteleríaToolStripMenuItem,
            this.finanzasToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.rRHHToolStripMenuItem,
            this.inventariosToolStripMenuItem,
            this.toolsMenu,
            this.ayudaToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(914, 26);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "MenuStrip";
			// 
			// inicioToolStripMenuItem
			// 
			this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
			this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
			this.inicioToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
			this.inicioToolStripMenuItem.Text = "Inicio";
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.salirToolStripMenuItem.Text = "Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
			// 
			// hoteleríaToolStripMenuItem
			// 
			this.hoteleríaToolStripMenuItem.Name = "hoteleríaToolStripMenuItem";
			this.hoteleríaToolStripMenuItem.Size = new System.Drawing.Size(87, 22);
			this.hoteleríaToolStripMenuItem.Text = "Hotelería";
			// 
			// finanzasToolStripMenuItem
			// 
			this.finanzasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contabilidadToolStripMenuItem,
            this.bancosToolStripMenuItem});
			this.finanzasToolStripMenuItem.Name = "finanzasToolStripMenuItem";
			this.finanzasToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
			this.finanzasToolStripMenuItem.Text = "Finanzas";
			this.finanzasToolStripMenuItem.Click += new System.EventHandler(this.FinanzasToolStripMenuItem_Click);
			// 
			// contabilidadToolStripMenuItem
			// 
			this.contabilidadToolStripMenuItem.Name = "contabilidadToolStripMenuItem";
			this.contabilidadToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.contabilidadToolStripMenuItem.Text = "Contabilidad";
			this.contabilidadToolStripMenuItem.Click += new System.EventHandler(this.ContabilidadToolStripMenuItem_Click);
			// 
			// bancosToolStripMenuItem
			// 
			this.bancosToolStripMenuItem.Name = "bancosToolStripMenuItem";
			this.bancosToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.bancosToolStripMenuItem.Text = "Bancos";
			this.bancosToolStripMenuItem.Click += new System.EventHandler(this.BancosToolStripMenuItem_Click);
			// 
			// comprasToolStripMenuItem
			// 
			this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprasToolStripMenuItem1,
            this.cuentasPorPagarToolStripMenuItem});
			this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
			this.comprasToolStripMenuItem.Size = new System.Drawing.Size(87, 22);
			this.comprasToolStripMenuItem.Text = "Compras";
			// 
			// comprasToolStripMenuItem1
			// 
			this.comprasToolStripMenuItem1.Name = "comprasToolStripMenuItem1";
			this.comprasToolStripMenuItem1.Size = new System.Drawing.Size(210, 22);
			this.comprasToolStripMenuItem1.Text = "Compras";
			// 
			// cuentasPorPagarToolStripMenuItem
			// 
			this.cuentasPorPagarToolStripMenuItem.Name = "cuentasPorPagarToolStripMenuItem";
			this.cuentasPorPagarToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
			this.cuentasPorPagarToolStripMenuItem.Text = "Cuentas Por Pagar";
			// 
			// ventasToolStripMenuItem
			// 
			this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem1,
            this.cuentasPorCobrarToolStripMenuItem});
			this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
			this.ventasToolStripMenuItem.Size = new System.Drawing.Size(70, 22);
			this.ventasToolStripMenuItem.Text = "Ventas";
			// 
			// ventasToolStripMenuItem1
			// 
			this.ventasToolStripMenuItem1.Name = "ventasToolStripMenuItem1";
			this.ventasToolStripMenuItem1.Size = new System.Drawing.Size(221, 22);
			this.ventasToolStripMenuItem1.Text = "Ventas";
			this.ventasToolStripMenuItem1.Click += new System.EventHandler(this.VentasToolStripMenuItem1_Click);
			// 
			// cuentasPorCobrarToolStripMenuItem
			// 
			this.cuentasPorCobrarToolStripMenuItem.Name = "cuentasPorCobrarToolStripMenuItem";
			this.cuentasPorCobrarToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
			this.cuentasPorCobrarToolStripMenuItem.Text = "Cuentas por Cobrar";
			this.cuentasPorCobrarToolStripMenuItem.Click += new System.EventHandler(this.CuentasPorCobrarToolStripMenuItem_Click);
			// 
			// rRHHToolStripMenuItem
			// 
			this.rRHHToolStripMenuItem.Name = "rRHHToolStripMenuItem";
			this.rRHHToolStripMenuItem.Size = new System.Drawing.Size(58, 22);
			this.rRHHToolStripMenuItem.Text = "RRHH";
			this.rRHHToolStripMenuItem.Click += new System.EventHandler(this.RRHHToolStripMenuItem_Click);
			// 
			// inventariosToolStripMenuItem
			// 
			this.inventariosToolStripMenuItem.Name = "inventariosToolStripMenuItem";
			this.inventariosToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
			this.inventariosToolStripMenuItem.Text = "Inventarios";
			// 
			// toolsMenu
			// 
			this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudasToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.ayudasToolStripMenuItem1});
			this.toolsMenu.Name = "toolsMenu";
			this.toolsMenu.Size = new System.Drawing.Size(117, 22);
			this.toolsMenu.Text = "&Herramientas";
			// 
			// ayudasToolStripMenuItem
			// 
			this.ayudasToolStripMenuItem.Name = "ayudasToolStripMenuItem";
			this.ayudasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.ayudasToolStripMenuItem.Text = "Seguridad";
			this.ayudasToolStripMenuItem.Click += new System.EventHandler(this.AyudasToolStripMenuItem_Click);
			// 
			// reportesToolStripMenuItem
			// 
			this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
			this.reportesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.reportesToolStripMenuItem.Text = "Reportes";
			this.reportesToolStripMenuItem.Click += new System.EventHandler(this.ReportesToolStripMenuItem_Click);
			// 
			// ayudasToolStripMenuItem1
			// 
			this.ayudasToolStripMenuItem1.Name = "ayudasToolStripMenuItem1";
			this.ayudasToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.ayudasToolStripMenuItem1.Text = "Ayudas";
			this.ayudasToolStripMenuItem1.Click += new System.EventHandler(this.AyudasToolStripMenuItem1_Click);
			// 
			// ayudaToolStripMenuItem
			// 
			this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
			this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(69, 22);
			this.ayudaToolStripMenuItem.Text = "Ayuda";
			this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.AyudaToolStripMenuItem_Click);
			// 
			// MDIParent1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = global::HSC.Properties.Resources.Logopng;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(914, 453);
			this.Controls.Add(this.menuStrip);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip;
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "MDIParent1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sistema Hotel San Carlos";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MDIParent1_Load);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion


		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem toolsMenu;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem hoteleríaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem finanzasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem contabilidadToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bancosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem cuentasPorPagarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem cuentasPorCobrarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rRHHToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem inventariosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ayudasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ayudasToolStripMenuItem1;
	}
}



