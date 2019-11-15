namespace MDI_Ventas
{
    partial class Frm_Movimiento_Clientes
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
            this.movimientoClientes1 = new CapaDiseno_CxC_MovClientes.MovimientoClientes();
            this.SuspendLayout();
            // 
            // movimientoClientes1
            // 
            this.movimientoClientes1.Location = new System.Drawing.Point(6, 7);
            this.movimientoClientes1.Name = "movimientoClientes1";
            this.movimientoClientes1.Size = new System.Drawing.Size(1024, 728);
            this.movimientoClientes1.TabIndex = 0;
            // 
            // Frm_Movimiento_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 736);
            this.Controls.Add(this.movimientoClientes1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_Movimiento_Clientes";
            this.Text = "Frm_Movimiento_Clientes";
            this.ResumeLayout(false);

        }

        #endregion

        private CapaDiseno_CxC_MovClientes.MovimientoClientes movimientoClientes1;
    }
}