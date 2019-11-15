namespace MDI_Ventas
{
    partial class Frm_Comision
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
            this.comision1 = new CapaDisenoComision.Comision();
            this.SuspendLayout();
            // 
            // comision1
            // 
            this.comision1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.comision1.Location = new System.Drawing.Point(-28, -57);
            this.comision1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comision1.Name = "comision1";
            this.comision1.Size = new System.Drawing.Size(1563, 704);
            this.comision1.TabIndex = 0;
            // 
            // Frm_Comision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comision1);
            this.Name = "Frm_Comision";
            this.Text = "Frm_Comision";
            this.ResumeLayout(false);

        }

        #endregion

        private CapaDisenoComision.Comision comision1;
    }
}