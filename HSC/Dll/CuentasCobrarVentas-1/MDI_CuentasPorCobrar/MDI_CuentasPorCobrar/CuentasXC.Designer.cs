namespace MDI_CuentasPorCobrar
{
    partial class CuentasXC
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
            this.cxC_gestion1 = new CxC_Gestion.CxC_gestion();
            this.SuspendLayout();
            // 
            // cxC_gestion1
            // 
            this.cxC_gestion1.Location = new System.Drawing.Point(4, 1);
            this.cxC_gestion1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cxC_gestion1.Name = "cxC_gestion1";
            this.cxC_gestion1.Size = new System.Drawing.Size(1120, 580);
            this.cxC_gestion1.TabIndex = 0;
            // 
            // CuentasXC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 577);
            this.Controls.Add(this.cxC_gestion1);
            this.Name = "CuentasXC";
            this.Text = "CuentasXC";
            this.ResumeLayout(false);

        }

        #endregion

        private CxC_Gestion.CxC_gestion cxC_gestion1;
    }
}