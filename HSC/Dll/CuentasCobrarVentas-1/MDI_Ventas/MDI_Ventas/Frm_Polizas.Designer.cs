namespace MDI_Ventas
{
    partial class Frm_Polizas
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
            this.poliza1 = new CapaDisenoPoliza.Poliza();
            this.SuspendLayout();
            // 
            // poliza1
            // 
            this.poliza1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.poliza1.Location = new System.Drawing.Point(13, 13);
            this.poliza1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.poliza1.Name = "poliza1";
            this.poliza1.Size = new System.Drawing.Size(1077, 879);
            this.poliza1.TabIndex = 0;
            // 
            // Frm_Polizas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.poliza1);
            this.Name = "Frm_Polizas";
            this.Text = "Frm_Polizas";
            this.ResumeLayout(false);

        }

        #endregion

        private CapaDisenoPoliza.Poliza poliza1;
    }
}