namespace PRACTICA2
{
    partial class frmPrimeraplicacion
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
            this.lblLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabel.Location = new System.Drawing.Point(281, 125);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(104, 34);
            this.lblLabel.TabIndex = 0;
            this.lblLabel.Text = "LABEL";
            this.lblLabel.MouseLeave += new System.EventHandler(this.lblLabel_MouseLeave);
            this.lblLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblLabel_MouseMove);
            // 
            // frmPrimeraplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 449);
            this.Controls.Add(this.lblLabel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Name = "frmPrimeraplicacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mi Primer Aplicacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLabel;
    }
}

